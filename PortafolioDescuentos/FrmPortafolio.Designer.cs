namespace Portafolio
{
    partial class FrmPortafolio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPortafolio));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPortafolio = new System.Windows.Forms.TextBox();
			this.txtItem = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.btnProcesarSal = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this._statusStrip = new System.Windows.Forms.StatusStrip();
			this.lbl_usuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.btn_importar = new System.Windows.Forms.Button();
			this.btn_limpiar = new System.Windows.Forms.Button();
			this.btnProcesarEnt = new System.Windows.Forms.Button();
			this.dgvItems = new System.Windows.Forms.DataGridView();
			this.col_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_quitar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.lbl_version = new System.Windows.Forms.Label();
			this.rdb_excel = new System.Windows.Forms.RadioButton();
			this.rdb_plano = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this._statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Portafolio:";
			// 
			// txtPortafolio
			// 
			this.txtPortafolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtPortafolio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPortafolio.Location = new System.Drawing.Point(92, 52);
			this.txtPortafolio.MaxLength = 200;
			this.txtPortafolio.Name = "txtPortafolio";
			this.txtPortafolio.Size = new System.Drawing.Size(258, 22);
			this.txtPortafolio.TabIndex = 3;
			this.txtPortafolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumerosComa);
			// 
			// txtItem
			// 
			this.txtItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtItem.Location = new System.Drawing.Point(92, 79);
			this.txtItem.MaxLength = 200;
			this.txtItem.Name = "txtItem";
			this.txtItem.Size = new System.Drawing.Size(66, 22);
			this.txtItem.TabIndex = 5;
			this.txtItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyDown);
			this.txtItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Item:";
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
			this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.Color.Black;
			this.btnAgregar.ImageIndex = 0;
			this.btnAgregar.Location = new System.Drawing.Point(164, 79);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(62, 24);
			this.btnAgregar.TabIndex = 6;
			this.btnAgregar.Text = "&Agregar";
			this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "round75.png");
			this.imageList1.Images.SetKeyName(1, "round60.png");
			this.imageList1.Images.SetKeyName(2, "microsoft-excel.png");
			this.imageList1.Images.SetKeyName(3, "erase16.png");
			this.imageList1.Images.SetKeyName(4, "clockwise11.png");
			this.imageList1.Images.SetKeyName(5, "close7.png");
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(18, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Ítems:";
			// 
			// btnProcesarSal
			// 
			this.btnProcesarSal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnProcesarSal.BackColor = System.Drawing.SystemColors.Control;
			this.btnProcesarSal.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btnProcesarSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProcesarSal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProcesarSal.ForeColor = System.Drawing.Color.Black;
			this.btnProcesarSal.ImageKey = "clockwise11.png";
			this.btnProcesarSal.Location = new System.Drawing.Point(187, 533);
			this.btnProcesarSal.Name = "btnProcesarSal";
			this.btnProcesarSal.Size = new System.Drawing.Size(163, 30);
			this.btnProcesarSal.TabIndex = 14;
			this.btnProcesarSal.Text = "&Salida de Portafolio";
			this.btnProcesarSal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnProcesarSal.UseVisualStyleBackColor = false;
			this.btnProcesarSal.Click += new System.EventHandler(this.btnProcesarSal_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
			this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.Color.Black;
			this.btnCancelar.ImageKey = "close7.png";
			this.btnCancelar.Location = new System.Drawing.Point(272, 568);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(78, 30);
			this.btnCancelar.TabIndex = 15;
			this.btnCancelar.Text = "&Cerrar";
			this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// _statusStrip
			// 
			this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_usuario});
			this._statusStrip.Location = new System.Drawing.Point(0, 603);
			this._statusStrip.Name = "_statusStrip";
			this._statusStrip.Size = new System.Drawing.Size(362, 22);
			this._statusStrip.TabIndex = 15;
			this._statusStrip.Text = "statusStrip1";
			// 
			// lbl_usuario
			// 
			this.lbl_usuario.Name = "lbl_usuario";
			this.lbl_usuario.Size = new System.Drawing.Size(0, 17);
			// 
			// btn_importar
			// 
			this.btn_importar.BackColor = System.Drawing.SystemColors.Control;
			this.btn_importar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btn_importar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_importar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_importar.ForeColor = System.Drawing.Color.Black;
			this.btn_importar.ImageKey = "microsoft-excel.png";
			this.btn_importar.Location = new System.Drawing.Point(240, 101);
			this.btn_importar.Name = "btn_importar";
			this.btn_importar.Size = new System.Drawing.Size(110, 30);
			this.btn_importar.TabIndex = 9;
			this.btn_importar.Text = "&Importar...";
			this.btn_importar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_importar.UseVisualStyleBackColor = false;
			this.btn_importar.Click += new System.EventHandler(this.btn_importar_Click);
			// 
			// btn_limpiar
			// 
			this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_limpiar.BackColor = System.Drawing.SystemColors.Control;
			this.btn_limpiar.Enabled = false;
			this.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_limpiar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_limpiar.ForeColor = System.Drawing.Color.Black;
			this.btn_limpiar.ImageKey = "erase16.png";
			this.btn_limpiar.Location = new System.Drawing.Point(288, 137);
			this.btn_limpiar.Name = "btn_limpiar";
			this.btn_limpiar.Size = new System.Drawing.Size(62, 24);
			this.btn_limpiar.TabIndex = 10;
			this.btn_limpiar.Text = "&Limpiar";
			this.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_limpiar.UseVisualStyleBackColor = false;
			this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
			// 
			// btnProcesarEnt
			// 
			this.btnProcesarEnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnProcesarEnt.BackColor = System.Drawing.SystemColors.Control;
			this.btnProcesarEnt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btnProcesarEnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProcesarEnt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProcesarEnt.ForeColor = System.Drawing.Color.Black;
			this.btnProcesarEnt.ImageKey = "clockwise11.png";
			this.btnProcesarEnt.Location = new System.Drawing.Point(21, 533);
			this.btnProcesarEnt.Name = "btnProcesarEnt";
			this.btnProcesarEnt.Size = new System.Drawing.Size(163, 30);
			this.btnProcesarEnt.TabIndex = 13;
			this.btnProcesarEnt.Text = "&Entrada a Portafolio";
			this.btnProcesarEnt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnProcesarEnt.UseVisualStyleBackColor = false;
			this.btnProcesarEnt.Click += new System.EventHandler(this.btnProcesarEnt_Click);
			// 
			// dgvItems
			// 
			this.dgvItems.AllowUserToAddRows = false;
			this.dgvItems.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
			this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvItems.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(65)))), ((int)(((byte)(148)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_item,
            this.col_quitar});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvItems.EnableHeadersVisualStyles = false;
			this.dgvItems.Location = new System.Drawing.Point(21, 164);
			this.dgvItems.Name = "dgvItems";
			this.dgvItems.ReadOnly = true;
			this.dgvItems.Size = new System.Drawing.Size(329, 365);
			this.dgvItems.TabIndex = 12;
			this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
			this.dgvItems.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvItems_RowPostPaint);
			// 
			// col_item
			// 
			this.col_item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.col_item.HeaderText = "Ítem";
			this.col_item.Name = "col_item";
			this.col_item.ReadOnly = true;
			// 
			// col_quitar
			// 
			this.col_quitar.HeaderText = "";
			this.col_quitar.Name = "col_quitar";
			this.col_quitar.ReadOnly = true;
			this.col_quitar.Text = "Quitar";
			this.col_quitar.UseColumnTextForButtonValue = true;
			this.col_quitar.Width = 50;
			// 
			// lbl_version
			// 
			this.lbl_version.AutoSize = true;
			this.lbl_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_version.Location = new System.Drawing.Point(11, 6);
			this.lbl_version.Name = "lbl_version";
			this.lbl_version.Size = new System.Drawing.Size(16, 13);
			this.lbl_version.TabIndex = 0;
			this.lbl_version.Text = "...";
			// 
			// rdb_excel
			// 
			this.rdb_excel.AutoSize = true;
			this.rdb_excel.Checked = true;
			this.rdb_excel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdb_excel.Location = new System.Drawing.Point(300, 80);
			this.rdb_excel.Name = "rdb_excel";
			this.rdb_excel.Size = new System.Drawing.Size(50, 17);
			this.rdb_excel.TabIndex = 8;
			this.rdb_excel.TabStop = true;
			this.rdb_excel.Text = "Excel";
			this.rdb_excel.UseVisualStyleBackColor = true;
			// 
			// rdb_plano
			// 
			this.rdb_plano.AutoSize = true;
			this.rdb_plano.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdb_plano.Location = new System.Drawing.Point(240, 80);
			this.rdb_plano.Name = "rdb_plano";
			this.rdb_plano.Size = new System.Drawing.Size(54, 17);
			this.rdb_plano.TabIndex = 7;
			this.rdb_plano.Text = "Plano";
			this.rdb_plano.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(9, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(77, 26);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(89, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(261, 28);
			this.label4.TabIndex = 1;
			this.label4.Text = "Escriba los códigos de portafolio separados por coma.";
			// 
			// FrmPortafolio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(362, 625);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.rdb_plano);
			this.Controls.Add(this.rdb_excel);
			this.Controls.Add(this.lbl_version);
			this.Controls.Add(this.dgvItems);
			this.Controls.Add(this.btnProcesarEnt);
			this.Controls.Add(this.btn_limpiar);
			this.Controls.Add(this.btn_importar);
			this.Controls.Add(this._statusStrip);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnProcesarSal);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtItem);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPortafolio);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "FrmPortafolio";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Portafolios Descuentos";
			this.Load += new System.EventHandler(this.FrmProtafolio_Load);
			this._statusStrip.ResumeLayout(false);
			this._statusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPortafolio;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProcesarSal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.StatusStrip _statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lbl_usuario;
        private System.Windows.Forms.Button btn_importar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btnProcesarEnt;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.RadioButton rdb_excel;
        private System.Windows.Forms.RadioButton rdb_plano;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_item;
		private System.Windows.Forms.DataGridViewButtonColumn col_quitar;
		private System.Windows.Forms.Label label4;
	}
}

