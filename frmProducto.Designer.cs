namespace proy_u4
{
    partial class frmProducto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.dgsrbProductos = new System.Windows.Forms.DataGridView();
            this.menusrbTitulo = new System.Windows.Forms.MenuStrip();
            this.lblsrbTitulo = new System.Windows.Forms.Label();
            this.txtsrbfoto = new System.Windows.Forms.TextBox();
            this.lblsrbPPrecio = new System.Windows.Forms.Label();
            this.txtsrbPStock = new System.Windows.Forms.TextBox();
            this.lblsrbPStock = new System.Windows.Forms.Label();
            this.cbsrbPCat = new System.Windows.Forms.ComboBox();
            this.txtsrbPCodigo = new System.Windows.Forms.TextBox();
            this.txtsrbPPVenta = new System.Windows.Forms.TextBox();
            this.txtsrbPDesc = new System.Windows.Forms.TextBox();
            this.lblsrbPPVenta = new System.Windows.Forms.Label();
            this.lblsrbPCodigo = new System.Windows.Forms.Label();
            this.lblsrbPCat = new System.Windows.Forms.Label();
            this.lblsrbPDesc = new System.Windows.Forms.Label();
            this.txtsrbPPrecio = new System.Windows.Forms.TextBox();
            this.btnsrbSalir = new System.Windows.Forms.Button();
            this.btnsrbGuardar = new FontAwesome.Sharp.IconButton();
            this.pbsrbFoto = new System.Windows.Forms.PictureBox();
            this.btnsrbEliminr = new FontAwesome.Sharp.IconButton();
            this.btnsrbAgregar = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgsrbProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsrbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgsrbProductos
            // 
            this.dgsrbProductos.AllowUserToAddRows = false;
            this.dgsrbProductos.AllowUserToDeleteRows = false;
            this.dgsrbProductos.AllowUserToResizeColumns = false;
            this.dgsrbProductos.AllowUserToResizeRows = false;
            this.dgsrbProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgsrbProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgsrbProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgsrbProductos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgsrbProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgsrbProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgsrbProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgsrbProductos.EnableHeadersVisualStyles = false;
            this.dgsrbProductos.Location = new System.Drawing.Point(399, 118);
            this.dgsrbProductos.MultiSelect = false;
            this.dgsrbProductos.Name = "dgsrbProductos";
            this.dgsrbProductos.ReadOnly = true;
            this.dgsrbProductos.RowHeadersVisible = false;
            this.dgsrbProductos.RowHeadersWidth = 51;
            this.dgsrbProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgsrbProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgsrbProductos.RowTemplate.Height = 24;
            this.dgsrbProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgsrbProductos.Size = new System.Drawing.Size(1014, 492);
            this.dgsrbProductos.TabIndex = 0;
            this.dgsrbProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsrbProductos_CellClick_1);
            // 
            // menusrbTitulo
            // 
            this.menusrbTitulo.AutoSize = false;
            this.menusrbTitulo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menusrbTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menusrbTitulo.Location = new System.Drawing.Point(0, 0);
            this.menusrbTitulo.Name = "menusrbTitulo";
            this.menusrbTitulo.Size = new System.Drawing.Size(1441, 87);
            this.menusrbTitulo.TabIndex = 2;
            this.menusrbTitulo.Text = "menuStrip1";
            // 
            // lblsrbTitulo
            // 
            this.lblsrbTitulo.AutoSize = true;
            this.lblsrbTitulo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblsrbTitulo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblsrbTitulo.ForeColor = System.Drawing.Color.White;
            this.lblsrbTitulo.Location = new System.Drawing.Point(20, 23);
            this.lblsrbTitulo.Name = "lblsrbTitulo";
            this.lblsrbTitulo.Size = new System.Drawing.Size(177, 45);
            this.lblsrbTitulo.TabIndex = 3;
            this.lblsrbTitulo.Text = "Productos";
            // 
            // txtsrbfoto
            // 
            this.txtsrbfoto.Location = new System.Drawing.Point(333, 566);
            this.txtsrbfoto.Name = "txtsrbfoto";
            this.txtsrbfoto.Size = new System.Drawing.Size(241, 22);
            this.txtsrbfoto.TabIndex = 7;
            this.txtsrbfoto.Visible = false;
            // 
            // lblsrbPPrecio
            // 
            this.lblsrbPPrecio.AutoSize = true;
            this.lblsrbPPrecio.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblsrbPPrecio.Location = new System.Drawing.Point(35, 370);
            this.lblsrbPPrecio.Name = "lblsrbPPrecio";
            this.lblsrbPPrecio.Size = new System.Drawing.Size(57, 23);
            this.lblsrbPPrecio.TabIndex = 91;
            this.lblsrbPPrecio.Text = "Precio";
            // 
            // txtsrbPStock
            // 
            this.txtsrbPStock.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtsrbPStock.Location = new System.Drawing.Point(201, 337);
            this.txtsrbPStock.Name = "txtsrbPStock";
            this.txtsrbPStock.Size = new System.Drawing.Size(158, 30);
            this.txtsrbPStock.TabIndex = 83;
            this.txtsrbPStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsrbPStock_KeyPress);
            // 
            // lblsrbPStock
            // 
            this.lblsrbPStock.AutoSize = true;
            this.lblsrbPStock.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblsrbPStock.Location = new System.Drawing.Point(35, 326);
            this.lblsrbPStock.Name = "lblsrbPStock";
            this.lblsrbPStock.Size = new System.Drawing.Size(50, 23);
            this.lblsrbPStock.TabIndex = 90;
            this.lblsrbPStock.Text = "Stock";
            // 
            // cbsrbPCat
            // 
            this.cbsrbPCat.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cbsrbPCat.FormattingEnabled = true;
            this.cbsrbPCat.Items.AddRange(new object[] {
            "Botana ",
            "Bebida",
            "Chocolates",
            "Cereales y Barras ",
            "Pan Tostado y Crutones",
            "Arroz, Frijol y Semillas",
            "Aceites de Cocina",
            "Café, Té y Sustitutos",
            "Gelatina de Agua en Polvo"});
            this.cbsrbPCat.Location = new System.Drawing.Point(201, 287);
            this.cbsrbPCat.Name = "cbsrbPCat";
            this.cbsrbPCat.Size = new System.Drawing.Size(158, 31);
            this.cbsrbPCat.TabIndex = 85;
            // 
            // txtsrbPCodigo
            // 
            this.txtsrbPCodigo.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtsrbPCodigo.Location = new System.Drawing.Point(201, 191);
            this.txtsrbPCodigo.MaxLength = 8;
            this.txtsrbPCodigo.Name = "txtsrbPCodigo";
            this.txtsrbPCodigo.ReadOnly = true;
            this.txtsrbPCodigo.Size = new System.Drawing.Size(158, 30);
            this.txtsrbPCodigo.TabIndex = 80;
            // 
            // txtsrbPPVenta
            // 
            this.txtsrbPPVenta.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtsrbPPVenta.Location = new System.Drawing.Point(201, 433);
            this.txtsrbPPVenta.Name = "txtsrbPPVenta";
            this.txtsrbPPVenta.Size = new System.Drawing.Size(158, 30);
            this.txtsrbPPVenta.TabIndex = 82;
            this.txtsrbPPVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsrbPPVenta_KeyPress);
            // 
            // txtsrbPDesc
            // 
            this.txtsrbPDesc.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtsrbPDesc.Location = new System.Drawing.Point(201, 239);
            this.txtsrbPDesc.Name = "txtsrbPDesc";
            this.txtsrbPDesc.Size = new System.Drawing.Size(158, 30);
            this.txtsrbPDesc.TabIndex = 81;
            // 
            // lblsrbPPVenta
            // 
            this.lblsrbPPVenta.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblsrbPPVenta.Location = new System.Drawing.Point(35, 414);
            this.lblsrbPPVenta.Name = "lblsrbPPVenta";
            this.lblsrbPPVenta.Size = new System.Drawing.Size(120, 65);
            this.lblsrbPPVenta.TabIndex = 89;
            this.lblsrbPPVenta.Text = "Precio de Venta";
            // 
            // lblsrbPCodigo
            // 
            this.lblsrbPCodigo.AutoSize = true;
            this.lblsrbPCodigo.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblsrbPCodigo.Location = new System.Drawing.Point(35, 194);
            this.lblsrbPCodigo.Name = "lblsrbPCodigo";
            this.lblsrbPCodigo.Size = new System.Drawing.Size(65, 23);
            this.lblsrbPCodigo.TabIndex = 88;
            this.lblsrbPCodigo.Text = "Código";
            // 
            // lblsrbPCat
            // 
            this.lblsrbPCat.AutoSize = true;
            this.lblsrbPCat.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblsrbPCat.Location = new System.Drawing.Point(35, 282);
            this.lblsrbPCat.Name = "lblsrbPCat";
            this.lblsrbPCat.Size = new System.Drawing.Size(84, 23);
            this.lblsrbPCat.TabIndex = 87;
            this.lblsrbPCat.Text = "Categoría";
            // 
            // lblsrbPDesc
            // 
            this.lblsrbPDesc.AutoSize = true;
            this.lblsrbPDesc.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblsrbPDesc.Location = new System.Drawing.Point(35, 238);
            this.lblsrbPDesc.Name = "lblsrbPDesc";
            this.lblsrbPDesc.Size = new System.Drawing.Size(98, 23);
            this.lblsrbPDesc.TabIndex = 86;
            this.lblsrbPDesc.Text = "Descripción";
            // 
            // txtsrbPPrecio
            // 
            this.txtsrbPPrecio.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtsrbPPrecio.Location = new System.Drawing.Point(201, 385);
            this.txtsrbPPrecio.Name = "txtsrbPPrecio";
            this.txtsrbPPrecio.Size = new System.Drawing.Size(158, 30);
            this.txtsrbPPrecio.TabIndex = 92;
            this.txtsrbPPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsrbPPrecio_KeyPress);
            // 
            // btnsrbSalir
            // 
            this.btnsrbSalir.BackColor = System.Drawing.Color.Red;
            this.btnsrbSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsrbSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrbSalir.ForeColor = System.Drawing.Color.White;
            this.btnsrbSalir.Location = new System.Drawing.Point(1381, 12);
            this.btnsrbSalir.Name = "btnsrbSalir";
            this.btnsrbSalir.Size = new System.Drawing.Size(48, 29);
            this.btnsrbSalir.TabIndex = 93;
            this.btnsrbSalir.Text = "X";
            this.btnsrbSalir.UseVisualStyleBackColor = false;
            this.btnsrbSalir.Click += new System.EventHandler(this.btnsrbSalir_Click);
            // 
            // btnsrbGuardar
            // 
            this.btnsrbGuardar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnsrbGuardar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrbGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnsrbGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnsrbGuardar.IconColor = System.Drawing.Color.Black;
            this.btnsrbGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsrbGuardar.IconSize = 40;
            this.btnsrbGuardar.Location = new System.Drawing.Point(399, 637);
            this.btnsrbGuardar.Name = "btnsrbGuardar";
            this.btnsrbGuardar.Size = new System.Drawing.Size(299, 64);
            this.btnsrbGuardar.TabIndex = 8;
            this.btnsrbGuardar.Text = "Guardar";
            this.btnsrbGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsrbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsrbGuardar.UseVisualStyleBackColor = false;
            this.btnsrbGuardar.Visible = false;
            this.btnsrbGuardar.Click += new System.EventHandler(this.btnsrbGuardar_Click);
            // 
            // pbsrbFoto
            // 
            this.pbsrbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbsrbFoto.Location = new System.Drawing.Point(73, 482);
            this.pbsrbFoto.Name = "pbsrbFoto";
            this.pbsrbFoto.Size = new System.Drawing.Size(241, 219);
            this.pbsrbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsrbFoto.TabIndex = 6;
            this.pbsrbFoto.TabStop = false;
            this.pbsrbFoto.Click += new System.EventHandler(this.pbsrbFoto_Click);
            // 
            // btnsrbEliminr
            // 
            this.btnsrbEliminr.BackColor = System.Drawing.Color.Crimson;
            this.btnsrbEliminr.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrbEliminr.ForeColor = System.Drawing.Color.Black;
            this.btnsrbEliminr.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnsrbEliminr.IconColor = System.Drawing.Color.Black;
            this.btnsrbEliminr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsrbEliminr.IconSize = 40;
            this.btnsrbEliminr.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsrbEliminr.Location = new System.Drawing.Point(1113, 637);
            this.btnsrbEliminr.Name = "btnsrbEliminr";
            this.btnsrbEliminr.Size = new System.Drawing.Size(299, 64);
            this.btnsrbEliminr.TabIndex = 5;
            this.btnsrbEliminr.Text = "Eliminar Producto";
            this.btnsrbEliminr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsrbEliminr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsrbEliminr.UseVisualStyleBackColor = false;
            this.btnsrbEliminr.Visible = false;
            this.btnsrbEliminr.Click += new System.EventHandler(this.btnsrbEliminr_Click);
            // 
            // btnsrbAgregar
            // 
            this.btnsrbAgregar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnsrbAgregar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrbAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnsrbAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnsrbAgregar.IconColor = System.Drawing.Color.Black;
            this.btnsrbAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsrbAgregar.IconSize = 40;
            this.btnsrbAgregar.Location = new System.Drawing.Point(756, 637);
            this.btnsrbAgregar.Name = "btnsrbAgregar";
            this.btnsrbAgregar.Size = new System.Drawing.Size(299, 64);
            this.btnsrbAgregar.TabIndex = 4;
            this.btnsrbAgregar.Text = "Agregar Producto";
            this.btnsrbAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsrbAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsrbAgregar.UseVisualStyleBackColor = false;
            this.btnsrbAgregar.Visible = false;
            this.btnsrbAgregar.Click += new System.EventHandler(this.btnsrbAgregar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtBuscar.Location = new System.Drawing.Point(39, 118);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(158, 30);
            this.txtBuscar.TabIndex = 96;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnBuscar.ForeColor = System.Drawing.Color.Snow;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Snow;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.Location = new System.Drawing.Point(216, 114);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(143, 37);
            this.btnBuscar.TabIndex = 97;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1441, 729);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnsrbSalir);
            this.Controls.Add(this.txtsrbPPrecio);
            this.Controls.Add(this.lblsrbPPrecio);
            this.Controls.Add(this.txtsrbPStock);
            this.Controls.Add(this.lblsrbPStock);
            this.Controls.Add(this.cbsrbPCat);
            this.Controls.Add(this.txtsrbPCodigo);
            this.Controls.Add(this.txtsrbPPVenta);
            this.Controls.Add(this.txtsrbPDesc);
            this.Controls.Add(this.lblsrbPPVenta);
            this.Controls.Add(this.lblsrbPCodigo);
            this.Controls.Add(this.lblsrbPCat);
            this.Controls.Add(this.lblsrbPDesc);
            this.Controls.Add(this.btnsrbGuardar);
            this.Controls.Add(this.txtsrbfoto);
            this.Controls.Add(this.pbsrbFoto);
            this.Controls.Add(this.btnsrbEliminr);
            this.Controls.Add(this.btnsrbAgregar);
            this.Controls.Add(this.lblsrbTitulo);
            this.Controls.Add(this.dgsrbProductos);
            this.Controls.Add(this.menusrbTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menusrbTitulo;
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgsrbProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsrbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgsrbProductos;
        private System.Windows.Forms.MenuStrip menusrbTitulo;
        private System.Windows.Forms.Label lblsrbTitulo;
        private FontAwesome.Sharp.IconButton btnsrbAgregar;
        private FontAwesome.Sharp.IconButton btnsrbEliminr;
        private System.Windows.Forms.PictureBox pbsrbFoto;
        private System.Windows.Forms.TextBox txtsrbfoto;
        private FontAwesome.Sharp.IconButton btnsrbGuardar;
        private System.Windows.Forms.Label lblsrbPPrecio;
        private System.Windows.Forms.TextBox txtsrbPStock;
        private System.Windows.Forms.Label lblsrbPStock;
        private System.Windows.Forms.ComboBox cbsrbPCat;
        private System.Windows.Forms.TextBox txtsrbPCodigo;
        private System.Windows.Forms.TextBox txtsrbPPVenta;
        private System.Windows.Forms.TextBox txtsrbPDesc;
        private System.Windows.Forms.Label lblsrbPPVenta;
        private System.Windows.Forms.Label lblsrbPCodigo;
        private System.Windows.Forms.Label lblsrbPCat;
        private System.Windows.Forms.Label lblsrbPDesc;
        private System.Windows.Forms.TextBox txtsrbPPrecio;
        private System.Windows.Forms.Button btnsrbSalir;
        private System.Windows.Forms.TextBox txtBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
    }
}

