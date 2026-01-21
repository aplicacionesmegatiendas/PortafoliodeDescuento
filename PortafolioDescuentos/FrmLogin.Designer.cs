namespace Portafolio
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
			this.btn_cerrar = new System.Windows.Forms.Button();
			this.btn_ingresar = new System.Windows.Forms.Button();
			this.txt_usuario = new System.Windows.Forms.TextBox();
			this.txt_contrasena = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_cerrar
			// 
			this.btn_cerrar.BackColor = System.Drawing.SystemColors.Control;
			this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_cerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cerrar.ForeColor = System.Drawing.Color.Black;
			this.btn_cerrar.ImageIndex = 2;
			this.btn_cerrar.Location = new System.Drawing.Point(138, 77);
			this.btn_cerrar.Name = "btn_cerrar";
			this.btn_cerrar.Size = new System.Drawing.Size(90, 36);
			this.btn_cerrar.TabIndex = 9;
			this.btn_cerrar.Text = "Cerrar";
			this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_cerrar.UseVisualStyleBackColor = false;
			this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
			// 
			// btn_ingresar
			// 
			this.btn_ingresar.BackColor = System.Drawing.SystemColors.Control;
			this.btn_ingresar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_ingresar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ingresar.ForeColor = System.Drawing.Color.Black;
			this.btn_ingresar.ImageIndex = 0;
			this.btn_ingresar.Location = new System.Drawing.Point(42, 77);
			this.btn_ingresar.Name = "btn_ingresar";
			this.btn_ingresar.Size = new System.Drawing.Size(90, 36);
			this.btn_ingresar.TabIndex = 7;
			this.btn_ingresar.Text = "Ingresar";
			this.btn_ingresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_ingresar.UseVisualStyleBackColor = false;
			this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
			// 
			// txt_usuario
			// 
			this.txt_usuario.BackColor = System.Drawing.SystemColors.Window;
			this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_usuario.Location = new System.Drawing.Point(65, 48);
			this.txt_usuario.Name = "txt_usuario";
			this.txt_usuario.Size = new System.Drawing.Size(164, 22);
			this.txt_usuario.TabIndex = 5;
			// 
			// txt_contrasena
			// 
			this.txt_contrasena.BackColor = System.Drawing.SystemColors.Window;
			this.txt_contrasena.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_contrasena.Location = new System.Drawing.Point(13, 139);
			this.txt_contrasena.MaxLength = 12;
			this.txt_contrasena.Name = "txt_contrasena";
			this.txt_contrasena.Size = new System.Drawing.Size(164, 22);
			this.txt_contrasena.TabIndex = 6;
			this.txt_contrasena.UseSystemPasswordChar = true;
			this.txt_contrasena.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Usuario:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Contraseña:";
			this.label2.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(134, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(94, 37);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// FrmLogin
			// 
			this.AcceptButton = this.btn_ingresar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.CancelButton = this.btn_cerrar;
			this.ClientSize = new System.Drawing.Size(238, 122);
			this.ControlBox = false;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_cerrar);
			this.Controls.Add(this.btn_ingresar);
			this.Controls.Add(this.txt_usuario);
			this.Controls.Add(this.txt_contrasena);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FrmLogin";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.FrmLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}