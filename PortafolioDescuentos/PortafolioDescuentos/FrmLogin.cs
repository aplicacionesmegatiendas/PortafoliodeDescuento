using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Portafolio
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text.Trim().Equals("") /*|| txt_contrasena.Text.Trim().Equals("")*/)
            {
                MessageBox.Show("Escriba el nombre de usuario unoee", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                int n = 0;
                Datos datos = new Datos();
                n = datos.ValidarUsuario(txt_usuario.Text.Trim());
                if (n == 0)
                {
                    MessageBox.Show("Nombre de usuario incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_usuario.Focus();
					txt_usuario.SelectAll();
					return;
                }
                Datos.Usuario = txt_usuario.Text.Trim();
				this.DialogResult= DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }


        }
    }
}
