namespace proy_u4
{
    partial class frmHistorialVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialVentas));
            this.menusrbTitulo = new System.Windows.Forms.MenuStrip();
            this.lblsrbTitulo = new System.Windows.Forms.Label();
            this.btnsrbSalir = new System.Windows.Forms.Button();
            this.btnVerFactura = new FontAwesome.Sharp.IconButton();
            this.dtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dgsrbHistorial = new System.Windows.Forms.DataGridView();
            this.btnInAtras = new System.Windows.Forms.Button();
            this.btnInSemAtras = new System.Windows.Forms.Button();
            this.btnInSemAdelante = new System.Windows.Forms.Button();
            this.btnInAdelante = new System.Windows.Forms.Button();
            this.lblFechaIn = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.btnFinSemAdelante = new System.Windows.Forms.Button();
            this.btnFinAdelante = new System.Windows.Forms.Button();
            this.btnFinSemAtras = new System.Windows.Forms.Button();
            this.btnFinAtras = new System.Windows.Forms.Button();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgsrbHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // menusrbTitulo
            // 
            this.menusrbTitulo.AutoSize = false;
            this.menusrbTitulo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menusrbTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menusrbTitulo.Location = new System.Drawing.Point(0, 0);
            this.menusrbTitulo.Name = "menusrbTitulo";
            this.menusrbTitulo.Size = new System.Drawing.Size(1038, 109);
            this.menusrbTitulo.TabIndex = 3;
            this.menusrbTitulo.Text = "menuStrip1";
            // 
            // lblsrbTitulo
            // 
            this.lblsrbTitulo.AutoSize = true;
            this.lblsrbTitulo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblsrbTitulo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblsrbTitulo.ForeColor = System.Drawing.Color.White;
            this.lblsrbTitulo.Location = new System.Drawing.Point(13, 29);
            this.lblsrbTitulo.Name = "lblsrbTitulo";
            this.lblsrbTitulo.Size = new System.Drawing.Size(311, 45);
            this.lblsrbTitulo.TabIndex = 4;
            this.lblsrbTitulo.Text = "Historial de Ventas";
            // 
            // btnsrbSalir
            // 
            this.btnsrbSalir.BackColor = System.Drawing.Color.Red;
            this.btnsrbSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsrbSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrbSalir.ForeColor = System.Drawing.Color.White;
            this.btnsrbSalir.Location = new System.Drawing.Point(968, 13);
            this.btnsrbSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsrbSalir.Name = "btnsrbSalir";
            this.btnsrbSalir.Size = new System.Drawing.Size(48, 29);
            this.btnsrbSalir.TabIndex = 94;
            this.btnsrbSalir.Text = "X";
            this.btnsrbSalir.UseVisualStyleBackColor = false;
            this.btnsrbSalir.Click += new System.EventHandler(this.btnsrbSalir_Click);
            // 
            // btnVerFactura
            // 
            this.btnVerFactura.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnVerFactura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerFactura.ForeColor = System.Drawing.Color.Black;
            this.btnVerFactura.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.btnVerFactura.IconColor = System.Drawing.Color.Black;
            this.btnVerFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerFactura.IconSize = 40;
            this.btnVerFactura.Location = new System.Drawing.Point(384, 627);
            this.btnVerFactura.Name = "btnVerFactura";
            this.btnVerFactura.Size = new System.Drawing.Size(241, 64);
            this.btnVerFactura.TabIndex = 96;
            this.btnVerFactura.Text = "Ver Factura";
            this.btnVerFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerFactura.UseVisualStyleBackColor = false;
            this.btnVerFactura.Click += new System.EventHandler(this.btnVerFactura_Click);
            // 
            // dtFechaInicial
            // 
            this.dtFechaInicial.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicial.Location = new System.Drawing.Point(254, 130);
            this.dtFechaInicial.Name = "dtFechaInicial";
            this.dtFechaInicial.Size = new System.Drawing.Size(128, 34);
            this.dtFechaInicial.TabIndex = 98;
            this.dtFechaInicial.Value = new System.DateTime(2023, 11, 20, 20, 43, 0, 0);
            this.dtFechaInicial.ValueChanged += new System.EventHandler(this.dtFechaInicial_ValueChanged);
            // 
            // dgsrbHistorial
            // 
            this.dgsrbHistorial.AllowUserToAddRows = false;
            this.dgsrbHistorial.AllowUserToDeleteRows = false;
            this.dgsrbHistorial.AllowUserToResizeColumns = false;
            this.dgsrbHistorial.AllowUserToResizeRows = false;
            this.dgsrbHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgsrbHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgsrbHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgsrbHistorial.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgsrbHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgsrbHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgsrbHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgsrbHistorial.EnableHeadersVisualStyles = false;
            this.dgsrbHistorial.Location = new System.Drawing.Point(21, 185);
            this.dgsrbHistorial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgsrbHistorial.MultiSelect = false;
            this.dgsrbHistorial.Name = "dgsrbHistorial";
            this.dgsrbHistorial.ReadOnly = true;
            this.dgsrbHistorial.RowHeadersVisible = false;
            this.dgsrbHistorial.RowHeadersWidth = 51;
            this.dgsrbHistorial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgsrbHistorial.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgsrbHistorial.RowTemplate.Height = 24;
            this.dgsrbHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgsrbHistorial.Size = new System.Drawing.Size(995, 426);
            this.dgsrbHistorial.TabIndex = 99;
            // 
            // btnInAtras
            // 
            this.btnInAtras.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnInAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInAtras.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInAtras.ForeColor = System.Drawing.Color.Snow;
            this.btnInAtras.Location = new System.Drawing.Point(212, 130);
            this.btnInAtras.Name = "btnInAtras";
            this.btnInAtras.Size = new System.Drawing.Size(36, 34);
            this.btnInAtras.TabIndex = 100;
            this.btnInAtras.Text = "<";
            this.btnInAtras.UseVisualStyleBackColor = false;
            this.btnInAtras.Click += new System.EventHandler(this.btnInAtras_Click);
            // 
            // btnInSemAtras
            // 
            this.btnInSemAtras.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnInSemAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInSemAtras.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInSemAtras.ForeColor = System.Drawing.Color.Snow;
            this.btnInSemAtras.Location = new System.Drawing.Point(162, 130);
            this.btnInSemAtras.Name = "btnInSemAtras";
            this.btnInSemAtras.Size = new System.Drawing.Size(44, 34);
            this.btnInSemAtras.TabIndex = 101;
            this.btnInSemAtras.Text = "<<";
            this.btnInSemAtras.UseVisualStyleBackColor = false;
            this.btnInSemAtras.Click += new System.EventHandler(this.btnInSemAtras_Click);
            // 
            // btnInSemAdelante
            // 
            this.btnInSemAdelante.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnInSemAdelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInSemAdelante.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInSemAdelante.ForeColor = System.Drawing.Color.Snow;
            this.btnInSemAdelante.Location = new System.Drawing.Point(430, 130);
            this.btnInSemAdelante.Name = "btnInSemAdelante";
            this.btnInSemAdelante.Size = new System.Drawing.Size(44, 34);
            this.btnInSemAdelante.TabIndex = 103;
            this.btnInSemAdelante.Text = ">>";
            this.btnInSemAdelante.UseVisualStyleBackColor = false;
            this.btnInSemAdelante.Click += new System.EventHandler(this.btnInSemAdelante_Click);
            // 
            // btnInAdelante
            // 
            this.btnInAdelante.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnInAdelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInAdelante.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInAdelante.ForeColor = System.Drawing.Color.Snow;
            this.btnInAdelante.Location = new System.Drawing.Point(388, 130);
            this.btnInAdelante.Name = "btnInAdelante";
            this.btnInAdelante.Size = new System.Drawing.Size(36, 34);
            this.btnInAdelante.TabIndex = 102;
            this.btnInAdelante.Text = ">";
            this.btnInAdelante.UseVisualStyleBackColor = false;
            this.btnInAdelante.Click += new System.EventHandler(this.btnInAdelante_Click);
            // 
            // lblFechaIn
            // 
            this.lblFechaIn.AutoSize = true;
            this.lblFechaIn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFechaIn.Location = new System.Drawing.Point(86, 133);
            this.lblFechaIn.Name = "lblFechaIn";
            this.lblFechaIn.Size = new System.Drawing.Size(70, 28);
            this.lblFechaIn.TabIndex = 104;
            this.lblFechaIn.Text = "Desde:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFechaFin.Location = new System.Drawing.Point(540, 133);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(65, 28);
            this.lblFechaFin.TabIndex = 105;
            this.lblFechaFin.Text = "Hasta:";
            // 
            // btnFinSemAdelante
            // 
            this.btnFinSemAdelante.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnFinSemAdelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinSemAdelante.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinSemAdelante.ForeColor = System.Drawing.Color.Snow;
            this.btnFinSemAdelante.Location = new System.Drawing.Point(886, 130);
            this.btnFinSemAdelante.Name = "btnFinSemAdelante";
            this.btnFinSemAdelante.Size = new System.Drawing.Size(44, 34);
            this.btnFinSemAdelante.TabIndex = 110;
            this.btnFinSemAdelante.Text = ">>";
            this.btnFinSemAdelante.UseVisualStyleBackColor = false;
            this.btnFinSemAdelante.Click += new System.EventHandler(this.btnFinSemAdelante_Click);
            // 
            // btnFinAdelante
            // 
            this.btnFinAdelante.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnFinAdelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinAdelante.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinAdelante.ForeColor = System.Drawing.Color.Snow;
            this.btnFinAdelante.Location = new System.Drawing.Point(844, 130);
            this.btnFinAdelante.Name = "btnFinAdelante";
            this.btnFinAdelante.Size = new System.Drawing.Size(36, 34);
            this.btnFinAdelante.TabIndex = 109;
            this.btnFinAdelante.Text = ">";
            this.btnFinAdelante.UseVisualStyleBackColor = false;
            this.btnFinAdelante.Click += new System.EventHandler(this.btnFinAdelante_Click);
            // 
            // btnFinSemAtras
            // 
            this.btnFinSemAtras.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnFinSemAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinSemAtras.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinSemAtras.ForeColor = System.Drawing.Color.Snow;
            this.btnFinSemAtras.Location = new System.Drawing.Point(611, 130);
            this.btnFinSemAtras.Name = "btnFinSemAtras";
            this.btnFinSemAtras.Size = new System.Drawing.Size(44, 34);
            this.btnFinSemAtras.TabIndex = 108;
            this.btnFinSemAtras.Text = "<<";
            this.btnFinSemAtras.UseVisualStyleBackColor = false;
            this.btnFinSemAtras.Click += new System.EventHandler(this.btnFinSemAtras_Click);
            // 
            // btnFinAtras
            // 
            this.btnFinAtras.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnFinAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinAtras.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinAtras.ForeColor = System.Drawing.Color.Snow;
            this.btnFinAtras.Location = new System.Drawing.Point(661, 130);
            this.btnFinAtras.Name = "btnFinAtras";
            this.btnFinAtras.Size = new System.Drawing.Size(36, 34);
            this.btnFinAtras.TabIndex = 107;
            this.btnFinAtras.Text = "<";
            this.btnFinAtras.UseVisualStyleBackColor = false;
            this.btnFinAtras.Click += new System.EventHandler(this.btnFinAtras_Click);
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFinal.Location = new System.Drawing.Point(710, 133);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(128, 34);
            this.dtFechaFinal.TabIndex = 111;
            this.dtFechaFinal.Value = new System.DateTime(2023, 11, 20, 20, 43, 0, 0);
            this.dtFechaFinal.ValueChanged += new System.EventHandler(this.dtFechaFinal_ValueChanged);
            // 
            // frmHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1038, 713);
            this.ControlBox = false;
            this.Controls.Add(this.dtFechaFinal);
            this.Controls.Add(this.btnFinSemAdelante);
            this.Controls.Add(this.btnFinAdelante);
            this.Controls.Add(this.btnFinSemAtras);
            this.Controls.Add(this.btnFinAtras);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaIn);
            this.Controls.Add(this.btnInSemAdelante);
            this.Controls.Add(this.btnInAdelante);
            this.Controls.Add(this.btnInSemAtras);
            this.Controls.Add(this.btnInAtras);
            this.Controls.Add(this.dgsrbHistorial);
            this.Controls.Add(this.dtFechaInicial);
            this.Controls.Add(this.btnVerFactura);
            this.Controls.Add(this.btnsrbSalir);
            this.Controls.Add(this.lblsrbTitulo);
            this.Controls.Add(this.menusrbTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHistorialVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgsrbHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menusrbTitulo;
        private System.Windows.Forms.Label lblsrbTitulo;
        private System.Windows.Forms.Button btnsrbSalir;
        private FontAwesome.Sharp.IconButton btnVerFactura;
        private System.Windows.Forms.DateTimePicker dtFechaInicial;
        private System.Windows.Forms.DataGridView dgsrbHistorial;
        private System.Windows.Forms.Button btnInAtras;
        private System.Windows.Forms.Button btnInSemAtras;
        private System.Windows.Forms.Button btnInSemAdelante;
        private System.Windows.Forms.Button btnInAdelante;
        private System.Windows.Forms.Label lblFechaIn;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Button btnFinSemAdelante;
        private System.Windows.Forms.Button btnFinAdelante;
        private System.Windows.Forms.Button btnFinSemAtras;
        private System.Windows.Forms.Button btnFinAtras;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
    }
}