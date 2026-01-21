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
        int tipo_archivo;
        public FrmOpenFile(int tipo_archivo)
        {
            InitializeComponent();
            this.tipo_archivo = tipo_archivo;
        }

        private void FrmOpenFile_Load(object sender, EventArgs e)
        {
            if (tipo_archivo == 1)
            {
                pcb_img.Image = Properties.Resources.ejeExcel;
                lbl_descripcion.Text = "Archivo de excel con extensión xlsx, el libro y la hoja puede tener cualquier nombre, y los códigos de ítem van desde la primera celda.";
            }
            if (tipo_archivo == 2)
            {
                pcb_img.Image = Properties.Resources.ejePlano;
                lbl_descripcion.Text = "Archivo plano con extensión txt, el archivo puede tener cualquier nombre, y los códigos de ítem van uno debajo del otro.";
            }
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (tipo_archivo == 1)
            {
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
            if (tipo_archivo == 2)
            {
                openfile.Filter = "Archivos de texto |*.txt";
                openfile.Title = "Seleccione el archivo de texto";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    if (openfile.FileName.Equals("") == false)
                    {
                        Importacion.ruta = openfile.FileName;
                    }
                    this.Close();
                }
            }
        }

        private void FrmOpenFile_Shown(object sender, EventArgs e)
        {
            btn_abrir.PerformClick();
        }
    }
}
