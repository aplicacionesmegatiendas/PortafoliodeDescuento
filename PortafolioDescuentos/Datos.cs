using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Portafolio
{
	public class Datos
	{
		public static string Usuario { get; set; }

		string cadena_conexion_unoee = ConfigurationManager.ConnectionStrings["unoee"].ConnectionString; //"Data Source=192.168.0.4;User Id=sa;Pwd=M3g@t13nd@s_2013R1;Initial Catalog=unoee_invercomer; MultipleActiveResultSets=True";
		string cadena_conexion_portafolio = ConfigurationManager.ConnectionStrings["portafolio"].ConnectionString;

		public int ValidarUsuario(string usuario)
		{
			string SQL = "select " +
							"count(f552_nombre) " +
						 "from " +
							"t552_ss_usuarios " +
						 "where  f552_nombre=@nomb";
			int n = 0;
			try
			{
				SqlConnection cn = new SqlConnection(cadena_conexion_unoee);
				cn.Open();
				SqlCommand cmd = new SqlCommand(SQL, cn);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@nomb", usuario);
				n = Convert.ToInt32(cmd.ExecuteScalar());
				cn.Close();
				return n;
			}
			catch (Exception ex)
			{
				throw new Exception("Error al validar el usuario: " + ex.Message);
			}
		}

		public void EjecutarConsultaSalida(string portafolio, string items, string usuario, int id_cia)
		{
			try
			{
				string SQL = "declare @portafolio varchar(10); " +
							 "declare @rowid_item int; " +
							 "declare @id_portafolio varchar(10); " +
							 "set @id_portafolio='" + portafolio + "';" +
							 "declare c_items_borrar cursor for " +
							 "select distinct " +
								"f137_id_portafolio, " +
								"f137_rowid_item_ext " +
							"from " +
								"t136_mc_portafolio " +
								"inner join t137_mc_portafolio_items on f137_id_portafolio=f136_id and f137_id_cia=f136_id_cia " +
								"inner join t121_mc_items_extensiones on f121_rowid=f137_rowid_item_ext and f121_id_cia=f137_id_cia " +
								"inner join t120_mc_items on f120_rowid=f121_rowid_item and f120_id_cia=f121_id_cia " +
							"where " +
								"f136_id=@id_portafolio " +
								"and f120_id in (";

				SQL += items;
				SQL += ") and f136_id_cia=@id_cia " +
					"open c_items_borrar; " +
					"fetch next from c_items_borrar into @portafolio, @rowid_item; " +
					"while @@FETCH_STATUS=0 begin " +
						"exec sp_portafolio_det_eli null, 1, @portafolio,@rowid_item,'" + usuario + "',null,1; " +
						"fetch next from c_items_borrar into @portafolio, @rowid_item; " +
					"end; " +
					"close c_items_borrar; " +
					"deallocate c_items_borrar;";

				SqlConnection cn = new SqlConnection(cadena_conexion_unoee);
				cn.Open();
				SqlCommand cmd = new SqlCommand(SQL, cn);
				cmd.CommandTimeout = 1200;
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@id_cia", id_cia);
				cmd.ExecuteNonQuery();
				cn.Close();
			}
			catch (Exception ex)
			{
				throw new Exception("Error al ejecutar la consulta de salida de portafolio: " + ex.Message);
			}
		}

		public void EjecutarConsultaEntrada(string portafolio, string items, string usuario, int id_cia)
		{
			SqlTransaction trans = null;
			try
			{
				SqlConnection cn = new SqlConnection(cadena_conexion_unoee);
				cn.Open();

				trans = cn.BeginTransaction();
				string SQL1 = "create table #item_portafolio( " +
								"id_portafolio varchar(10), " +
								"cod_item int);";

				string SQL2 = $@"select 
                                      f120_id,
                                      f137_id_portafolio
                                 from
                                      t137_mc_portafolio_items 
                                      inner join t121_mc_items_extensiones on f121_rowid=f137_rowid_item_ext and f121_id_cia=f137_id_cia 
                                      inner join t120_mc_items on f120_rowid=f121_rowid_item and f120_id_cia=f121_id_cia 
                                 where
									  f137_id_cia = @id_cia
                                      and f120_id in({items})
                                      and f137_id_portafolio = @PORTAFOLIO";

				string SQL3 = @"insert into 
                                    #item_portafolio
                                (
                                     id_portafolio,
                                     cod_item 
                                ) 
                                values 
                                (
                                     @PORTAFOLIO,
                                     @ITEM
                                );";

				string SQL4 = $@"declare @portafolio varchar(10);
								declare @rowid_item int; 
								declare @secuencia int; 
								declare @fecha datetime = current_timestamp;

								declare c_items_adicionar cursor for 
								select distinct
									id_portafolio, f121_rowid 
								from 
									#item_portafolio 
									inner join t120_mc_items on f120_id=cod_item 
									inner join t121_mc_items_extensiones on f120_rowid=f121_rowid_item and f121_id_cia=f120_id_cia 
									where f120_id_cia=@ID_CIA

								open c_items_adicionar; 
								fetch next from c_items_adicionar into @portafolio, @rowid_item 
								while @@FETCH_STATUS=0 begin 
										select @secuencia=isnull(MAX(f137_secuencia),0)+1 from 
								t137_mc_portafolio_items where f137_id_portafolio=@portafolio and f137_id_cia=@ID_CIA; 
										exec sp_portafolio_det_adicionar @fecha, @ID_CIA, @portafolio,@rowid_item, @secuencia, '{usuario}',null,null;
										fetch next from c_items_adicionar into @portafolio, @rowid_item; 
								end; 
								drop table #item_portafolio; 
								close c_items_adicionar; 
                                deallocate c_items_adicionar";

				SqlCommand cmd = new SqlCommand();
				cmd.CommandTimeout = 1200;
				cmd.CommandText = SQL1;
				cmd.Transaction = trans;
				cmd.Connection = cn;
				cmd.CommandType = CommandType.Text;
				cmd.ExecuteNonQuery();

				SqlCommand cmd2 = new SqlCommand();
				cmd2.CommandTimeout = 1200;
				cmd2.CommandText = SQL2;
				cmd2.Parameters.AddWithValue("@id_cia", id_cia);
				cmd2.Transaction = trans;
				cmd2.Connection = cn;
				cmd2.CommandType = CommandType.Text;

				cmd2.Parameters.AddWithValue("@PORTAFOLIO", portafolio);

				SqlDataReader dr = cmd2.ExecuteReader();
				string items_result = "";
				if (dr.HasRows)
				{
					while (dr.Read())
					{
						items_result = items_result + "'" + Convert.ToString(dr.GetInt32(0)) + "',";
					}
					items_result = items_result.Trim(',').Replace("'", "");
				}
				dr.Close();

				string[] items_todos = items.Replace("'", "").Split(',');
				string[] items_encontrados = items_result.Split(',');
				string[] items_entran = items_todos.Except(items_encontrados).ToArray();

				SqlCommand cmd3 = new SqlCommand();
				cmd3.CommandTimeout = 1200;
				cmd3.CommandText = SQL3;
				cmd3.Transaction = trans;
				cmd3.Connection = cn;
				cmd3.CommandType = CommandType.Text;
				foreach (string item in items_entran)
				{
					if (!item.Trim().Equals(""))
					{
						cmd3.Parameters.AddWithValue("@PORTAFOLIO", portafolio);
						cmd3.Parameters.AddWithValue("@ITEM", item);
						cmd3.ExecuteNonQuery();
						cmd3.Parameters.Clear();
					}
				}

				SqlCommand cmd4 = new SqlCommand();
				cmd4.CommandTimeout = 1200;
				cmd4.CommandText = SQL4;
				cmd4.Parameters.AddWithValue("@id_cia", id_cia);
				cmd4.Transaction = trans;
				cmd4.Connection = cn;
				cmd4.CommandType = CommandType.Text;
				cmd4.ExecuteNonQuery();

				trans.Commit();

				cn.Close();
			}
			catch (Exception ex)
			{
				trans.Rollback();
				throw new Exception("Error al ejecutar la consulta de entrada a portafolio: " + ex.Message);
			}
		}

		public string ValidarPortafolio(string portafolio)
		{
			string SQL = $@"select distinct
	                            f09_cod_portafolio 
                            from 
	                            t09_co_difusiones
                            where
	                            f09_cod_portafolio=@portafolio";

			string res = "";
			try
			{
				SqlConnection cn = new SqlConnection(cadena_conexion_portafolio);
				cn.Open();
				SqlCommand cmd = new SqlCommand(SQL, cn);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@portafolio", portafolio);
				res=Convert.ToString(cmd.ExecuteScalar());
				cn.Close();
			}
			catch (Exception ex)
			{
				throw new Exception("Error al validar portafolios: " + ex.Message);
			}
			return res.Trim();
		}

		public string ValidarItemsNoComecializados(string items, int id_cia)
		{
			string SQL = $@"select 
									f120_id 
								from 
									t120_mc_items
									inner join t125_mc_items_criterios on f125_rowid_item=f120_rowid and f125_id_plan = '001' 
																			and f125_id_criterio_mayor <> '0001' and f125_id_cia = f120_id_cia
                                where
									f120_id_cia = @id_cia and
	                                f120_ind_compra = 1 and
	                                f120_ind_venta = 0 and
	                                f120_id in({items})";
			string res="";
			try
			{
				SqlConnection cn = new SqlConnection(cadena_conexion_unoee);
				cn.Open();
				SqlCommand cmd = new SqlCommand(SQL, cn);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@id_cia", id_cia);
				SqlDataReader dr = cmd.ExecuteReader();
				if (dr.HasRows) 
					while (dr.Read()) 
					{
						res += dr[0].ToString() + ",";
					}
				cn.Close();
			}
			catch (Exception ex)
			{
				throw new Exception("Error al validar ítems suministro: " + ex.Message);
			}
			return res.Trim(',');
		}

		public void GuardarProcesoES(Proceso proceso, DetalleProceso detalle)
		{
			string SQL_PROCESO = @"insert into
	                                    t10_proceso_ES
                                    (
	                                    f10_cod_portafolio,
	                                    f10_usuario_unoee,
	                                    f10_proceso,
                                        f10_aplicacion
                                    )output INSERTED.f10_id
                                    values
                                    (
	                                    @cod_portafolio,
	                                    @usuario_unoee,
	                                    @proceso,
                                        @aplicacion
                                    )";

			string SQL_DET_PROCESO = @"insert into
	                                        t11_detalle_proceso_ES
                                        (
	                                        f11_id_proceso_ES,
	                                        f11_item
                                        )
                                        values
                                        (
	                                        @id_proceso_ES,
	                                        @item
                                        )";
			SqlTransaction trans = null;
			try
			{
				SqlConnection conn = new SqlConnection(cadena_conexion_portafolio);
				conn.Open();
				trans = conn.BeginTransaction();
				SqlCommand cmd_proceso = new SqlCommand(SQL_PROCESO, conn, trans);
				cmd_proceso.CommandType = CommandType.Text;
				cmd_proceso.Parameters.AddWithValue("@cod_portafolio", proceso.Portafolio);
				cmd_proceso.Parameters.AddWithValue("@usuario_unoee", proceso.UsuarioUnoee);
				cmd_proceso.Parameters.AddWithValue("@proceso", proceso.TipoProceso);
				cmd_proceso.Parameters.AddWithValue("@aplicacion", proceso.Aplicacion);
				int id = Convert.ToInt32(cmd_proceso.ExecuteScalar());

				SqlCommand cmd_detalles = new SqlCommand(SQL_DET_PROCESO, conn, trans);
				cmd_detalles.CommandType = CommandType.Text;

				string[] items = detalle.Item.Split(',');
				for (int i = 0; i < items.Length; i++)
				{
					cmd_detalles.Parameters.AddWithValue("@id_proceso_ES", id);
					cmd_detalles.Parameters.AddWithValue("@item", items[i]);
					cmd_detalles.ExecuteNonQuery();
					cmd_detalles.Parameters.Clear();
				}
				trans.Commit();
				conn.Close();
			}
			catch (Exception ex)
			{
				trans.Rollback();
				throw new Exception($"Error al guardar proceso: {ex.Message}");
			}
		}
	}

	public class Proceso
	{
		public int Id { get; set; }
		public string Portafolio { get; set; }
		public string UsuarioUnoee { get; set; }
		public char TipoProceso { get; set; }
		public char Aplicacion { get; set; }
	}
	public class DetalleProceso
	{
		public string Item { get; set; }
	}

}
