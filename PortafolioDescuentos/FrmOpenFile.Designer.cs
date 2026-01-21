namespace Portafolio
{
    partial class FrmOpenFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpenFile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_abrir = new System.Windows.Forms.Button();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.pcb_img = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_abrir);
            this.panel1.Controls.Add(this.lbl_descripcion);
            this.panel1.Controls.Add(this.pcb_img);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 489);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Haga clic en Abrir para buscar el archivo.";
            // 
            // btn_abrir
            // 
            this.btn_abrir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_abrir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abrir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrir.ForeColor = System.Drawing.Color.Black;
            this.btn_abrir.ImageKey = "microsoft-excel.png";
            this.btn_abrir.Location = new System.Drawing.Point(227, 443);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(87, 40);
            this.btn_abrir.TabIndex = 10;
            this.btn_abrir.Text = "&Abrir...";
            this.btn_abrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_abrir.UseVisualStyleBackColor = false;
            this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Location = new System.Drawing.Point(7, 367);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(306, 71);
            this.lbl_descripcion.TabIndex = 1;
            this.lbl_descripcion.Text = "...";
            // 
            // pcb_img
            // 
            this.pcb_img.Location = new System.Drawing.Point(1, 1);
            this.pcb_img.Name = "pcb_img";
            this.pcb_img.Size = new System.Drawing.Size(317, 346);
            this.pcb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_img.TabIndex = 0;
            this.pcb_img.TabStop = false;
            // 
            // FrmOpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 489);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOpenFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Abrir archivo";
            this.Load += new System.EventHandler(this.FrmOpenFile_Load);
            this.Shown += new System.EventHandler(this.FrmOpenFile_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.PictureBox pcb_img;
        private System.Windows.Forms.Button btn_abrir;
        private System.Windows.Forms.Label label1;
    }
}