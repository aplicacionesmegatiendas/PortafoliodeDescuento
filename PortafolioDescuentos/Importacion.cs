using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Portafolio
{
    public class Importacion
    {
        DataTable dt = null;
        public static String ruta = "";

        public DataTable importarExcel(string ruta)
        {
            try
            {
                XLWorkbook libro = new XLWorkbook(ruta);
                IXLWorksheet items = libro.Worksheet(1);

                var rows = items.RangeUsed();//.Skip(1); // Skip header row
                dt = new DataTable();
                dt.Columns.Add("Portafolio");
                dt.Columns.Add("Item");
                for (int i = 1; i <= rows.RowCount(); i++)
				{
                    dt.Rows.Add(rows.Row(i).Cell("A").Value.ToString(), rows.Row(i).Cell("B").Value.ToString());
				}
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar el archivo: " + ex.Message);
            }
        }

        public string[] ImportarPlano(string ruta)
        {
            string[] data = null;
            try
            {
                data = System.IO.File.ReadAllLines(ruta, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar el archivo: " + ex.Message);
            }
            return data;
        }
    }
}
