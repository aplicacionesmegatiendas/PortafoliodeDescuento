using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Diagnostics;
using System.Configuration;
using System.IO;

namespace Portafolio
{
	public partial class FrmPortafolio : Form
	{
		DataTable dt_excel = null;
		string[] dt_plano = null;

		public FrmPortafolio()
		{
			InitializeComponent();
		}

		private void CaracteresPortafolios(object sender, KeyPressEventArgs e)
		{
			if (dgvItems.RowCount == 0)
			{
				if (!(e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7'
					|| e.KeyChar == '8' || e.KeyChar == '9' || e.KeyChar == '0' || e.KeyChar == (char)8 || (e.KeyChar == ',')
					|| (e.KeyChar == 'A') || (e.KeyChar == 'B') || (e.KeyChar == 'C') || (e.KeyChar == 'D') || (e.KeyChar == 'E') || (e.KeyChar == 'F') || (e.KeyChar == 'G')
					|| (e.KeyChar == 'a') || (e.KeyChar == 'b') || (e.KeyChar == 'c') || (e.KeyChar == 'd') || (e.KeyChar == 'e') || (e.KeyChar == 'f') || (e.KeyChar == 'g')
					|| (e.KeyChar == 'H') || (e.KeyChar == 'I') || (e.KeyChar == 'J') || (e.KeyChar == 'K') || (e.KeyChar == 'L') || (e.KeyChar == 'M') || (e.KeyChar == 'N')
					|| (e.KeyChar == 'h') || (e.KeyChar == 'i') || (e.KeyChar == 'j') || (e.KeyChar == 'k') || (e.KeyChar == 'l') || (e.KeyChar == 'm') || (e.KeyChar == 'n')
					|| (e.KeyChar == 'O') || (e.KeyChar == 'P') || (e.KeyChar == 'Q') || (e.KeyChar == 'R') || (e.KeyChar == 'S') || (e.KeyChar == 'T') || (e.KeyChar == 'U')
					|| (e.KeyChar == 'o') || (e.KeyChar == 'p') || (e.KeyChar == 'q') || (e.KeyChar == 'r') || (e.KeyChar == 's') || (e.KeyChar == 't') || (e.KeyChar == 'u')
					|| (e.KeyChar == 'V') || (e.KeyChar == 'W') || (e.KeyChar == 'X') || (e.KeyChar == 'Y') || (e.KeyChar == 'Z')
					|| (e.KeyChar == 'v') || (e.KeyChar == 'w') || (e.KeyChar == 'x') || (e.KeyChar == 'y') || (e.KeyChar == 'z')))
				{
					e.Handled = true;
				}
			}
			else
			{
				e.Handled = true;
			}
		}

		private void SoloNumeros(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private bool VerificarItem(string portafolio, string item)
		{
			bool exite = false;
			try
			{
				for (int i = 0; i < dgvItems.Rows.Count; i++)
				{
					if (Convert.ToString(dgvItems[0, i].Value).Equals(portafolio) && Convert.ToString(dgvItems[1, i].Value).Equals(item))
					{
						exite = true;
						dgvItems[0, i].Selected = true;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return exite;
		}

		private void AgregarItem(string portafolio, string item)
		{
			try
			{
				dgvItems.Rows.Add(portafolio, item);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void AgregarItemDT(string portafolio, string item)
		{
			try
			{
				DataRow dr = dt_excel.NewRow();
				dr[0] = portafolio;
				dr[1] = item;
				dt_excel.Rows.Add(dr);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void QuitarItem()
		{
			try
			{
				dgvItems.Rows.Remove(dgvItems.CurrentRow);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if (txtItem.Text.Trim().Equals(""))
			{
				MessageBox.Show("Escriba el código del ítem", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtItem.Focus();
				return;
			}
			dgvItems.ClearSelection();
			string[] portafolios = txtPortafolio.Text.Split(',');
			foreach (string portafolio in portafolios)
			{
				if (!VerificarItem(portafolio, txtItem.Text))
				{
					if (dt_excel == null)
					{
						AgregarItem(portafolio, txtItem.Text.Trim());
					}
					else
					{
						AgregarItemDT(portafolio, txtItem.Text.Trim());
					}
				}
			}
			txtItem.Focus();
			txtItem.Text = "";
		}

		private void btnQuitar_Click(object sender, EventArgs e)
		{
			if (dgvItems.SelectedRows.Count == 0)
			{
				MessageBox.Show("Seleccione un iten de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			QuitarItem();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void txtItem_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnAgregar.PerformClick();
			}
		}

		private void btn_importar_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				Importacion.ruta = "";
				Importacion impo = new Importacion();

				new FrmOpenFile().ShowDialog(this);

				if (!Importacion.ruta.Equals(""))
				{
					dt_excel = impo.importarExcel(Importacion.ruta);
					dgvItems.Rows.Clear();
					for (int i = 0; i < dt_excel.Rows.Count; i++)
					{
						if (!Convert.ToString(dt_excel.Rows[i][0]).Trim().Equals(""))
						{
							dgvItems.Rows.Add(Convert.ToString(dt_excel.Rows[i][0]).Trim(), Convert.ToString(dt_excel.Rows[i][1]).Trim());
						}
					}
				}
				if (dt_excel != null)
				{
					btn_importar.Enabled = false;
					btn_limpiar.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			this.Cursor = Cursors.Default;
		}

		private void btn_limpiar_Click(object sender, EventArgs e)
		{
			dgvItems.Rows.Clear();
			dt_excel = null;
			btn_importar.Enabled = true;
			btn_limpiar.Enabled = false;
		}

		private void btnProcesarSal_Click(object sender, EventArgs e)
		{
			if (txtPortafolio.Text.Trim().Equals(""))
			{
				MessageBox.Show("Escriba el código del portafolio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			if (dgvItems.Rows.Count == 0)
			{
				MessageBox.Show("Agregue ítems a la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			btnProcesarEnt.Enabled = false;
			btnProcesarSal.Enabled = false;
			try
			{
				if (MessageBox.Show("¿Confirma dar salida a estos ítems del portafolio?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Configuration config = ConfigurationManager.OpenExeConfiguration(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".exe");
					AppSettingsSection section = config.AppSettings;
					string id_cia = section.Settings["id_cia"].Value;

					Datos datos = new Datos();

					List<string> portafolios = dgvItems.Rows.Cast<DataGridViewRow>()
					.Select(x => x.Cells["col_portafolio"].Value.ToString())
					.Distinct()
					.ToList();

					foreach (string portafolio in portafolios)
					{
						string items = "";

						for (int j = 0; j < dgvItems.RowCount; j++)
						{
							if (dgvItems[0, j].Value.ToString().Equals(portafolio))
								items = items + "'" + dgvItems[1, j].Value.ToString() + "',";
						}
						items = items.Trim(',');
						string items_no_comercializados = datos.ValidarItemsNoComecializados(items, Convert.ToInt32(id_cia));
						string items_salida = "";
						string validado = datos.ValidarPortafolio(portafolio);

						if (!validado.Equals(string.Empty))
						{
							items_salida = items_no_comercializados;
						}
						else
						{
							items_salida = items;
						}

						Application.DoEvents();

						if (!items_salida.Equals(string.Empty))
						{
							datos.EjecutarConsultaSalida(portafolio, items_salida, lbl_usuario.Text, Convert.ToInt32(id_cia));
						}
					}

					MessageBox.Show("La consulta se ejecuto exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				txtItem.Text = "";
				if (dt_excel == null)
					dgvItems.Rows.Clear();
				else
					dgvItems.DataSource = null;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				btnProcesarSal.Enabled = true;
				btnProcesarEnt.Enabled = true;
			}
		}

		private void FrmProtafolio_Load(object sender, EventArgs e)
		{
			FrmLogin frm_login = new FrmLogin();
			frm_login.ShowDialog();
			if (frm_login.DialogResult == DialogResult.OK)
			{
				dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
				this.dgvItems.ColumnHeadersHeight = 25;
				lbl_usuario.Text = Datos.Usuario;
				lbl_version.Text = "V " + Application.ProductVersion.ToString();
			}
			else
			{
				Application.Exit();
			}
		}

		private void btnProcesarEnt_Click(object sender, EventArgs e)
		{
			if (dgvItems.Rows.Count == 0)
			{
				MessageBox.Show("Agregue ítems a la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			btnProcesarEnt.Enabled = false;
			btnProcesarSal.Enabled = false;
			try
			{
				if (MessageBox.Show("¿Confirma dar entrada a estos ítems al portafolio?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Configuration config = ConfigurationManager.OpenExeConfiguration(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".exe");
					AppSettingsSection section = config.AppSettings;
					string id_cia = section.Settings["id_cia"].Value;

					Datos datos = new Datos();

					List<string> portafolios = dgvItems.Rows.Cast<DataGridViewRow>()
					.Select(x => x.Cells["col_portafolio"].Value.ToString())
					.Distinct()
					.ToList();

					foreach (string portafolio in portafolios)
					{
						string items = "";

						for (int j = 0; j < dgvItems.RowCount; j++)
						{
							if (dgvItems[0, j].Value.ToString().Equals(portafolio))
								items = items + "'" + dgvItems[1, j].Value.ToString() + "',";
						}
						items = items.Trim(',');
						string items_no_comercializados = datos.ValidarItemsNoComecializados(items, Convert.ToInt32(id_cia));

						string items_entrada = "";
						string validado = datos.ValidarPortafolio(portafolio);

						if (!validado.Equals(string.Empty))
						{
							items_entrada = items_no_comercializados;
						}
						else
						{
							items_entrada = items;
						}

						Application.DoEvents();

						if (!items_no_comercializados.Equals(string.Empty))
						{
							datos.EjecutarConsultaEntrada(portafolio, items_entrada, lbl_usuario.Text, Convert.ToInt32(id_cia));
						}
					}

					MessageBox.Show("La consulta se ejecuto exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				txtItem.Text = "";
				if (dt_excel == null)
					dgvItems.Rows.Clear();
				else
					dgvItems.DataSource = null;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				btnProcesarSal.Enabled = true;
				btnProcesarEnt.Enabled = true;
			}
		}

		private void dgvItems_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			var grid = sender as DataGridView;
			var rowIdx = (e.RowIndex + 1).ToString();

			var centerFormat = new StringFormat()
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			};

			var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
			e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
		}

		private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				QuitarItem();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
