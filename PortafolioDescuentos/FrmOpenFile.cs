using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portafolio
{
	public partial class FrmOpenFile : Form
	{
		public FrmOpenFile()
		{
			InitializeComponent();
		}

		private void FrmOpenFile_Load(object sender, EventArgs e)
		{
			pcb_img.Image = Properties.Resources.eje_excel;
			lbl_descripcion.Text = "Archivo de excel con extensión xlsx, el libro y la hoja puede tener cualquier nombre, en la columna A va el código del portafolio y el código del ítem van en la columna B, desde la celda 1 y sin titulo.";
		}

		private void btn_abrir_Click(object sender, EventArgs e)
		{
			OpenFileDialog openfile = new OpenFileDialog();
			openfile.Filter = "Excel Files |*.xlsx";
			openfile.Title = "Seleccione el archivo de Excel";
			if (openfile.ShowDialog() == DialogResult.OK)
			{
				if (openfile.FileName.Equals("") == false)
				{
					Importacion.ruta = openfile.FileName;
				}
				this.Close();
			}
		}

		private void FrmOpenFile_Shown(object sender, EventArgs e)
		{
			btn_abrir.PerformClick();
		}
	}
}
