namespace proy_u4
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.btnsrbSalir = new System.Windows.Forms.Button();
            this.lblsrbTitulo = new System.Windows.Forms.Label();
            this.menusrbTitulo = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgsrbProductos = new System.Windows.Forms.DataGridView();
            this.gbsrbProducto = new System.Windows.Forms.GroupBox();
            this.pbsrbFoto = new System.Windows.Forms.PictureBox();
            this.btnsrbAgregar = new FontAwesome.Sharp.IconButton();
            this.txtsrbDesc = new System.Windows.Forms.TextBox();
            this.lblsrbDescProd = new System.Windows.Forms.Label();
            this.txtsrbCat = new System.Windows.Forms.TextBox();
            this.lblsrbCategoria = new System.Windows.Forms.Label();
            this.txtsrbStock = new System.Windows.Forms.TextBox();
            this.lblsrbCant = new System.Windows.Forms.Label();
            this.lblsrbVenta = new System.Windows.Forms.Label();
            this.lblsrbStock = new System.Windows.Forms.Label();
            this.txtsrbPVenta = new System.Windows.Forms.TextBox();
            this.txtsrbCant = new System.Windows.Forms.TextBox();
            this.gbsrbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtsrbNomC = new System.Windows.Forms.TextBox();
            this.lblsrbNomC = new System.Windows.Forms.Label();
            this.lblsrbTelC = new System.Windows.Forms.Label();
            this.lblsrbCorreoC = new System.Windows.Forms.Label();
            this.txtsrbTelC = new System.Windows.Forms.TextBox();
            this.txtsrbCorreoC = new System.Windows.Forms.TextBox();
            this.gbsrbTotales = new System.Windows.Forms.GroupBox();
            this.txtsrbIVA = new System.Windows.Forms.TextBox();
            this.btnsrbTerminarVenta = new FontAwesome.Sharp.IconButton();
            this.lblsrbSub = new System.Windows.Forms.Label();
            this.txtsrbCambio = new System.Windows.Forms.TextBox();
            this.lblsrbIVA = new System.Windows.Forms.Label();
            this.txtsrbPago = new System.Windows.Forms.TextBox();
            this.lblsrbTotal = new System.Windows.Forms.Label();
            this.txtsrbTotal = new System.Windows.Forms.TextBox();
            this.lblsrbPago = new System.Windows.Forms.Label();
            this.lblsrbCambio = new System.Windows.Forms.Label();
            this.txtsrbSub = new System.Windows.Forms.TextBox();
            this.dgsrbDetalles = new System.Windows.Forms.DataGridView();
            this.dgsrbProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgsrbCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgsrbPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgsrbTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsrbEliminar = new FontAwesome.Sharp.IconButton();
            this.cbCliente = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsrbProductos)).BeginInit();
            this.gbsrbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbsrbFoto)).BeginInit();
            this.gbsrbDatosCliente.SuspendLayout();
            this.gbsrbTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsrbDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsrbSalir
            // 
            this.btnsrbSalir.BackColor = System.Drawing.Color.Red;
            this.btnsrbSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsrbSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrbSalir.ForeColor = System.Drawing.Color.White;
            this.btnsrbSalir.Location = new System.Drawing.Point(854, 12);
            this.btnsrbSalir.Name = "btnsrbSalir";
            this.btnsrbSalir.Size = new System.Drawing.Size(48, 29);
            this.btnsrbSalir.TabIndex = 117;
            this.btnsrbSalir.Text = "X";
            this.btnsrbSalir.UseVisualStyleBackColor = false;
            this.btnsrbSalir.Click += new System.EventHandler(this.btnsrbSalir_Click);
            // 
            // lblsrbTitulo
            // 
            this.lblsrbTitulo.AutoSize = true;
            this.lblsrbTitulo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblsrbTitulo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblsrbTitulo.ForeColor = System.Drawing.Color.White;
            this.lblsrbTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblsrbTitulo.Name = "lblsrbTitulo";
            this.lblsrbTitulo.Size = new System.Drawing.Size(218, 45);
            this.lblsrbTitulo.TabIndex = 119;
            this.lblsrbTitulo.Text = "Nueva Venta";
            // 
            // menusrbTitulo
            // 
            this.menusrbTitulo.AutoSize = false;
            this.menusrbTitulo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menusrbTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menusrbTitulo.Location = new System.Drawing.Point(0, 0);
            this.menusrbTitulo.Name = "menusrbTitulo";
            this.menusrbTitulo.Size = new System.Drawing.Size(914, 59);
            this.menusrbTitulo.TabIndex = 118;
            this.menusrbTitulo.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.dgsrbProductos);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.groupBox1.Location = new System.Drawing.Point(20, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 281);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
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
            this.btnBuscar.Location = new System.Drawing.Point(205, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(143, 37);
            this.btnBuscar.TabIndex = 154;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtBuscar.Location = new System.Drawing.Point(28, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(158, 30);
            this.txtBuscar.TabIndex = 153;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // dgsrbProductos
            // 
            this.dgsrbProductos.AllowUserToAddRows = false;
            this.dgsrbProductos.AllowUserToDeleteRows = false;
            this.dgsrbProductos.AllowUserToResizeColumns = false;
            this.dgsrbProductos.AllowUserToResizeRows = false;
            this.dgsrbProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgsrbProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgsrbProductos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgsrbProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgsrbProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgsrbProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgsrbProductos.EnableHeadersVisualStyles = false;
            this.dgsrbProductos.Location = new System.Drawing.Point(11, 71);
            this.dgsrbProductos.MultiSelect = false;
            this.dgsrbProductos.Name = "dgsrbProductos";
            this.dgsrbProductos.ReadOnly = true;
            this.dgsrbProductos.RowHeadersVisible = false;
            this.dgsrbProductos.RowHeadersWidth = 51;
            this.dgsrbProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgsrbProductos.RowTemplate.Height = 24;
            this.dgsrbProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgsrbProductos.Size = new System.Drawing.Size(340, 193);
            this.dgsrbProductos.TabIndex = 152;
            this.dgsrbProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsrbProductos_CellClick);
            // 
            // gbsrbProducto
            // 
            this.gbsrbProducto.Controls.Add(this.pbsrbFoto);
            this.gbsrbProducto.Controls.Add(this.btnsrbAgregar);
            this.gbsrbProducto.Controls.Add(this.txtsrbDesc);
            this.gbsrbProducto.Controls.Add(this.lblsrbDescProd);
            this.gbsrbProducto.Controls.Add(this.txtsrbCat);
            this.gbsrbProducto.Controls.Add(this.lblsrbCategoria);
            this.gbsrbProducto.Controls.Add(this.txtsrbStock);
            this.gbsrbProducto.Controls.Add(this.lblsrbCant);
            this.gbsrbProducto.Controls.Add(this.lblsrbVenta);
            this.gbsrbProducto.Controls.Add(this.lblsrbStock);
            this.gbsrbProducto.Controls.Add(this.txtsrbPVenta);
            this.gbsrbProducto.Controls.Add(this.txtsrbCant);
            this.gbsrbProducto.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.gbsrbProducto.Location = new System.Drawing.Point(388, 72);
            this.gbsrbProducto.Name = "gbsrbProducto";
            this.gbsrbProducto.Size = new System.Drawing.Size(509, 281);
            this.gbsrbProducto.TabIndex = 121;
            this.gbsrbProducto.TabStop = false;
            // 
            // pbsrbFoto
            // 
            this.pbsrbFoto.Location = new System.Drawing.Point(301, 43);
            this.pbsrbFoto.Name = "pbsrbFoto";
            this.pbsrbFoto.Size = new System.Drawing.Size(200, 221);
            this.pbsrbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsrbFoto.TabIndex = 152;
            this.pbsrbFoto.TabStop = false;
            // 
            // btnsrbAgregar
            // 
            this.btnsrbAgregar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnsrbAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsrbAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnsrbAgregar.ForeColor = System.Drawing.Color.White;
            this.btnsrbAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnsrbAgregar.IconColor = System.Drawing.Color.White;
            this.btnsrbAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsrbAgregar.IconSize = 45;
            this.btnsrbAgregar.Location = new System.Drawing.Point(27, 217);
            this.btnsrbAgregar.Name = "btnsrbAgregar";
            this.btnsrbAgregar.Size = new System.Drawing.Size(261, 47);
            this.btnsrbAgregar.TabIndex = 150;
            this.btnsrbAgregar.Text = "Agregar";
            this.btnsrbAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsrbAgregar.UseVisualStyleBackColor = false;
            this.btnsrbAgregar.Click += new System.EventHandler(this.btnsrbAgregar_Click);
            // 
            // txtsrbDesc
            // 
            this.txtsrbDesc.BackColor = System.Drawing.Color.LightCyan;
            this.txtsrbDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtsrbDesc.Location = new System.Drawing.Point(27, 49);
            this.txtsrbDesc.Name = "txtsrbDesc";
            this.txtsrbDesc.ReadOnly = true;
            this.txtsrbDesc.Size = new System.Drawing.Size(261, 32);
            this.txtsrbDesc.TabIndex = 137;
            // 
            // lblsrbDescProd
            // 
            this.lblsrbDescProd.AutoSize = true;
            this.lblsrbDescProd.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblsrbDescProd.Location = new System.Drawing.Point(22, 22);
            this.lblsrbDescProd.Name = "lblsrbDescProd";
            this.lblsrbDescProd.Size = new System.Drawing.Size(108, 25);
            this.lblsrbDescProd.TabIndex = 124;
            this.lblsrbDescProd.Text = "Descripción:";
            // 
            // txtsrbCat
            // 
            this.txtsrbCat.BackColor = System.Drawing.Color.LightCyan;
            this.txtsrbCat.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtsrbCat.Location = new System.Drawing.Point(27, 112);
            this.txtsrbCat.Name = "txtsrbCat";
            this.txtsrbCat.ReadOnly = true;
            this.txtsrbCat.Size = new System.Drawing.Size(261, 32);
            this.txtsrbCat.TabIndex = 138;
            // 
            // lblsrbCategoria
            // 
            this.lblsrbCategoria.AutoSize = true;
            this.lblsrbCategoria.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblsrbCategoria.Location = new System.Drawing.Point(22, 86);
            this.lblsrbCategoria.Name = "lblsrbCategoria";
            this.lblsrbCategoria.Size = new System.Drawing.Size(92, 25);
            this.lblsrbCategoria.TabIndex = 125;
            this.lblsrbCategoria.Text = "Categoría:";
            // 
            // txtsrbStock
            // 
            this.txtsrbStock.BackColor = System.Drawing.Color.LightCyan;
            this.txtsrbStock.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtsrbStock.Location = new System.Drawing.Point(213, 172);
            this.txtsrbStock.Name = "txtsrbStock";
            this.txtsrbStock.ReadOnly = true;
            this.txtsrbStock.Size = new System.Drawing.Size(74, 32);
            this.txtsrbStock.TabIndex = 141;
            // 
            // lblsrbCant
            // 
            this.lblsrbCant.AutoSize = true;
            this.lblsrbCant.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblsrbCant.Location = new System.Drawing.Point(22, 146);
            this.lblsrbCant.Name = "lblsrbCant";
            this.lblsrbCant.Size = new System.Drawing.Size(87, 25);
            this.lblsrbCant.TabIndex = 126;
            this.lblsrbCant.Text = "Cantidad:";
            // 
            // lblsrbVenta
            // 
            this.lblsrbVenta.AutoSize = true;
            this.lblsrbVenta.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblsrbVenta.Location = new System.Drawing.Point(116, 146);
            this.lblsrbVenta.Name = "lblsrbVenta";
            this.lblsrbVenta.Size = new System.Drawing.Size(79, 25);
            this.lblsrbVenta.TabIndex = 127;
            this.lblsrbVenta.Text = "P. Venta:";
            // 
            // lblsrbStock
            // 
            this.lblsrbStock.AutoSize = true;
            this.lblsrbStock.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblsrbStock.Location = new System.Drawing.Point(210, 146);
            this.lblsrbStock.Name = "lblsrbStock";
            this.lblsrbStock.Size = new System.Drawing.Size(59, 25);
            this.lblsrbStock.TabIndex = 128;
            this.lblsrbStock.Text = "Stock:";
            // 
            // txtsrbPVenta
            // 
            this.txtsrbPVenta.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtsrbPVenta.Location = new System.Drawing.Point(120, 172);
            this.txtsrbPVenta.Name = "txtsrbPVenta";
            this.txtsrbPVenta.Size = new System.Drawing.Size(74, 32);
            this.txtsrbPVenta.TabIndex = 140;
            this.txtsrbPVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsrbPVenta_KeyPress);
            // 
            // txtsrbCant
            // 
            this.txtsrbCant.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtsrbCant.Location = new System.Drawing.Point(27, 172);
            this.txtsrbCant.Name = "txtsrbCant";
            this.txtsrbCant.Size = new System.Drawing.Size(74, 32);
            this.txtsrbCant.TabIndex = 139;
            this.txtsrbCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsrbCant_KeyPress);
            this.txtsrbCant.Leave += new System.EventHandler(this.txtsrbCant_Leave);
            // 
            // gbsrbDatosCliente
            // 
            this.gbsrbDatosCliente.Controls.Add(this.txtsrbNomC);
            this.gbsrbDatosCliente.Controls.Add(this.lblsrbNomC);
            this.gbsrbDatosCliente.Controls.Add(this.lblsrbTelC);
            this.gbsrbDatosCliente.Controls.Add(this.lblsrbCorreoC);
            this.gbsrbDatosCliente.Controls.Add(this.txtsrbTelC);
            this.gbsrbDatosCliente.Controls.Add(this.txtsrbCorreoC);
            this.gbsrbDatosCliente.Enabled = false;
            this.gbsrbDatosCliente.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.gbsrbDatosCliente.Location = new System.Drawing.Point(20, 368);
            this.gbsrbDatosCliente.Name = "gbsrbDatosCliente";
            this.gbsrbDatosCliente.Size = new System.Drawing.Size(877, 103);
            this.gbsrbDatosCliente.TabIndex = 122;
            this.gbsrbDatosCliente.TabStop = false;
            this.gbsrbDatosCliente.Text = "Cliente";
            // 
            // txtsrbNomC
            // 
            this.txtsrbNomC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtsrbNomC.Location = new System.Drawing.Point(26, 53);
            this.txtsrbNomC.Name = "txtsrbNomC";
            this.txtsrbNomC.Size = new System.Drawing.Size(247, 32);
            this.txtsrbNomC.TabIndex = 142;
            this.txtsrbNomC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsrbNomC_KeyPress);
            // 
            // lblsrbNomC
            // 
            this.lblsrbNomC.AutoSize = true;
            this.lblsrbNomC.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblsrbNomC.Location = new System.Drawing.Point(22, 24);
            this.lblsrbNomC.Name = "lblsrbNomC";
            this.lblsrbNomC.Size = new System.Drawing.Size(82, 25);
            this.lblsrbNomC.TabIndex = 129;
            this.lblsrbNomC.Text = "Nombre:";
            // 
            // lblsrbTelC
            // 
            this.lblsrbTelC.AutoSize = true;
            this.lblsrbTelC.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblsrbTelC.Location = new System.Drawing.Point(323, 24);
            this.lblsrbTelC.Name = "lblsrbTelC";
            this.lblsrbTelC.Size = new System.Drawing.Size(47, 25);
            this.lblsrbTelC.TabIndex = 130;
            this.lblsrbTelC.Text = "RFC:";
            // 
            // lblsrbCorreoC
            // 
            this.lblsrbCorreoC.AutoSize = true;
            this.lblsrbCorreoC.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblsrbCorreoC.Location = new System.Drawing.Point(568, 24);
            this.lblsrbCorreoC.Name = "lblsrbCorreoC";
            this.lblsrbCorreoC.Size = new System.Drawing.Size(70, 25);
            this.lblsrbCorreoC.TabIndex = 131;
            this.lblsrbCorreoC.Text = "Correo:";
            // 
            // txtsrbTelC
            // 
            this.txtsrbTelC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtsrbTelC.Location = new System.Drawing.Point(327, 53);
            this.txtsrbTelC.Name = "txtsrbTelC";
            this.txtsrbTelC.Size = new System.Drawing.Size(198, 32);
            this.txtsrbTelC.TabIndex = 143;
            // 
            // txtsrbCorreoC
            // 
            this.txtsrbCorreoC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtsrbCorreoC.Location = new System.Drawing.Point(573, 53);
            this.txtsrbCorreoC.Name = "txtsrbCorreoC";
            this.txtsrbCorreoC.Size = new System.Drawing.Size(277, 32);
            this.txtsrbCorreoC.TabIndex = 144;
            // 
            // gbsrbTotales
            // 
            this.gbsrbTotales.Controls.Add(this.txtsrbIVA);
            this.gbsrbTotales.Controls.Add(this.btnsrbTerminarVenta);
            this.gbsrbTotales.Controls.Add(this.lblsrbSub);
            this.gbsrbTotales.Controls.Add(this.txtsrbCambio);
            this.gbsrbTotales.Controls.Add(this.lblsrbIVA);
            this.gbsrbTotales.Controls.Add(this.txtsrbPago);
            this.gbsrbTotales.Controls.Add(this.lblsrbTotal);
            this.gbsrbTotales.Controls.Add(this.txtsrbTotal);
            this.gbsrbTotales.Controls.Add(this.lblsrbPago);
            this.gbsrbTotales.Controls.Add(this.lblsrbCambio);
            this.gbsrbTotales.Controls.Add(this.txtsrbSub);
            this.gbsrbTotales.Enabled = false;
            this.gbsrbTotales.Location = new System.Drawing.Point(619, 483);
            this.gbsrbTotales.Name = "gbsrbTotales";
            this.gbsrbTotales.Size = new System.Drawing.Size(278, 332);
            this.gbsrbTotales.TabIndex = 123;
            this.gbsrbTotales.TabStop = false;
            // 
            // txtsrbIVA
            // 
            this.txtsrbIVA.BackColor = System.Drawing.Color.LightCyan;
            this.txtsrbIVA.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtsrbIVA.Location = new System.Drawing.Point(108, 72);
            this.txtsrbIVA.Name = "txtsrbIVA";
            this.txtsrbIVA.ReadOnly = true;
            this.txtsrbIVA.Size = new System.Drawing.Size(144, 32);
            this.txtsrbIVA.TabIndex = 146;
            // 
            // btnsrbTerminarVenta
            // 
            this.btnsrbTerminarVenta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnsrbTerminarVenta.Enabled = false;
            this.btnsrbTerminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsrbTerminarVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnsrbTerminarVenta.ForeColor = System.Drawing.Color.White;
            this.btnsrbTerminarVenta.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnsrbTerminarVenta.IconColor = System.Drawing.Color.White;
            this.btnsrbTerminarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsrbTerminarVenta.IconSize = 45;
            this.btnsrbTerminarVenta.Location = new System.Drawing.Point(16, 263);
            this.btnsrbTerminarVenta.Name = "btnsrbTerminarVenta";
            this.btnsrbTerminarVenta.Size = new System.Drawing.Size(236, 51);
            this.btnsrbTerminarVenta.TabIndex = 151;
            this.btnsrbTerminarVenta.Text = "Terminar Venta";
            this.btnsrbTerminarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsrbTerminarVenta.UseVisualStyleBackColor = false;
            this.btnsrbTerminarVenta.Click += new System.EventHandler(this.btnsrbTerminarVenta_Click);
            // 
            // lblsrbSub
            // 
            this.lblsrbSub.AutoSize = true;
            this.lblsrbSub.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblsrbSub.Location = new System.Drawing.Point(12, 38);
            this.lblsrbSub.Name = "lblsrbSub";
            this.lblsrbSub.Size = new System.Drawing.Size(89, 25);
            this.lblsrbSub.TabIndex = 132;
            this.lblsrbSub.Text = "Sub Total:";
            // 
            // txtsrbCambio
            // 
            this.txtsrbCambio.BackColor = System.Drawing.Color.LightCyan;
            this.txtsrbCambio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtsrbCambio.Location = new System.Drawing.Point(108, 203);
            this.txtsrbCambio.Name = "txtsrbCambio";
            this.txtsrbCambio.ReadOnly = true;
            this.txtsrbCambio.Size = new System.Drawing.Size(144, 32);
            this.txtsrbCambio.TabIndex = 149;
            // 
            // lblsrbIVA
            // 
            this.lblsrbIVA.AutoSize = true;
            this.lblsrbIVA.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblsrbIVA.Location = new System.Drawing.Point(58, 75);
            this.lblsrbIVA.Name = "lblsrbIVA";
            this.lblsrbIVA.Size = new System.Drawing.Size(43, 25);
            this.lblsrbIVA.TabIndex = 133;
            this.lblsrbIVA.Text = "IVA:";
            // 
            // txtsrbPago
            // 
            this.txtsrbPago.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtsrbPago.Location = new System.Drawing.Point(108, 166);
            this.txtsrbPago.MaxLength = 10;
            this.txtsrbPago.Name = "txtsrbPago";
            this.txtsrbPago.Size = new System.Drawing.Size(144, 32);
            this.txtsrbPago.TabIndex = 148;
            this.txtsrbPago.TextChanged += new System.EventHandler(this.txtsrbPago_TextChanged);
            this.txtsrbPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsrbPago_KeyPress);
            // 
            // lblsrbTotal
            // 
            this.lblsrbTotal.AutoSize = true;
            this.lblsrbTotal.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblsrbTotal.Location = new System.Drawing.Point(48, 115);
            this.lblsrbTotal.Name = "lblsrbTotal";
            this.lblsrbTotal.Size = new System.Drawing.Size(53, 25);
            this.lblsrbTotal.TabIndex = 134;
            this.lblsrbTotal.Text = "Total:";
            // 
            // txtsrbTotal
            // 
            this.txtsrbTotal.BackColor = System.Drawing.Color.LightCyan;
            this.txtsrbTotal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtsrbTotal.Location = new System.Drawing.Point(108, 109);
            this.txtsrbTotal.Name = "txtsrbTotal";
            this.txtsrbTotal.ReadOnly = true;
            this.txtsrbTotal.Size = new System.Drawing.Size(144, 32);
            this.txtsrbTotal.TabIndex = 147;
            // 
            // lblsrbPago
            // 
            this.lblsrbPago.AutoSize = true;
            this.lblsrbPago.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblsrbPago.Location = new System.Drawing.Point(45, 169);
            this.lblsrbPago.Name = "lblsrbPago";
            this.lblsrbPago.Size = new System.Drawing.Size(56, 25);
            this.lblsrbPago.TabIndex = 135;
            this.lblsrbPago.Text = "Pago:";
            // 
            // lblsrbCambio
            // 
            this.lblsrbCambio.AutoSize = true;
            this.lblsrbCambio.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblsrbCambio.Location = new System.Drawing.Point(23, 208);
            this.lblsrbCambio.Name = "lblsrbCambio";
            this.lblsrbCambio.Size = new System.Drawing.Size(78, 25);
            this.lblsrbCambio.TabIndex = 136;
            this.lblsrbCambio.Text = "Cambio:";
            // 
            // txtsrbSub
            // 
            this.txtsrbSub.BackColor = System.Drawing.Color.LightCyan;
            this.txtsrbSub.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtsrbSub.Location = new System.Drawing.Point(108, 35);
            this.txtsrbSub.Name = "txtsrbSub";
            this.txtsrbSub.ReadOnly = true;
            this.txtsrbSub.Size = new System.Drawing.Size(144, 32);
            this.txtsrbSub.TabIndex = 145;
            // 
            // dgsrbDetalles
            // 
            this.dgsrbDetalles.AllowUserToAddRows = false;
            this.dgsrbDetalles.AllowUserToDeleteRows = false;
            this.dgsrbDetalles.AllowUserToResizeColumns = false;
            this.dgsrbDetalles.AllowUserToResizeRows = false;
            this.dgsrbDetalles.BackgroundColor = System.Drawing.Color.White;
            this.dgsrbDetalles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgsrbDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgsrbDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsrbDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgsrbProd,
            this.dgsrbCant,
            this.dgsrbPrecio,
            this.dgsrbTotal});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgsrbDetalles.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgsrbDetalles.EnableHeadersVisualStyles = false;
            this.dgsrbDetalles.Location = new System.Drawing.Point(20, 483);
            this.dgsrbDetalles.MultiSelect = false;
            this.dgsrbDetalles.Name = "dgsrbDetalles";
            this.dgsrbDetalles.ReadOnly = true;
            this.dgsrbDetalles.RowHeadersVisible = false;
            this.dgsrbDetalles.RowHeadersWidth = 51;
            this.dgsrbDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgsrbDetalles.RowTemplate.Height = 24;
            this.dgsrbDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgsrbDetalles.Size = new System.Drawing.Size(593, 286);
            this.dgsrbDetalles.TabIndex = 153;
            // 
            // dgsrbProd
            // 
            this.dgsrbProd.Frozen = true;
            this.dgsrbProd.HeaderText = "Producto";
            this.dgsrbProd.MinimumWidth = 6;
            this.dgsrbProd.Name = "dgsrbProd";
            this.dgsrbProd.ReadOnly = true;
            this.dgsrbProd.Width = 230;
            // 
            // dgsrbCant
            // 
            this.dgsrbCant.Frozen = true;
            this.dgsrbCant.HeaderText = "Cant.";
            this.dgsrbCant.MinimumWidth = 6;
            this.dgsrbCant.Name = "dgsrbCant";
            this.dgsrbCant.ReadOnly = true;
            this.dgsrbCant.Width = 125;
            // 
            // dgsrbPrecio
            // 
            this.dgsrbPrecio.Frozen = true;
            this.dgsrbPrecio.HeaderText = "Precio";
            this.dgsrbPrecio.MinimumWidth = 6;
            this.dgsrbPrecio.Name = "dgsrbPrecio";
            this.dgsrbPrecio.ReadOnly = true;
            this.dgsrbPrecio.Width = 125;
            // 
            // dgsrbTotal
            // 
            this.dgsrbTotal.Frozen = true;
            this.dgsrbTotal.HeaderText = "Total";
            this.dgsrbTotal.MinimumWidth = 6;
            this.dgsrbTotal.Name = "dgsrbTotal";
            this.dgsrbTotal.ReadOnly = true;
            this.dgsrbTotal.Width = 125;
            // 
            // btnsrbEliminar
            // 
            this.btnsrbEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnsrbEliminar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrbEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnsrbEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnsrbEliminar.IconColor = System.Drawing.Color.Black;
            this.btnsrbEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsrbEliminar.IconSize = 40;
            this.btnsrbEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsrbEliminar.Location = new System.Drawing.Point(200, 775);
            this.btnsrbEliminar.Name = "btnsrbEliminar";
            this.btnsrbEliminar.Size = new System.Drawing.Size(206, 43);
            this.btnsrbEliminar.TabIndex = 154;
            this.btnsrbEliminar.Text = "Eliminar Articulo";
            this.btnsrbEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsrbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsrbEliminar.UseVisualStyleBackColor = false;
            this.btnsrbEliminar.Click += new System.EventHandler(this.btnsrbEliminar_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.AutoSize = true;
            this.cbCliente.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.cbCliente.Location = new System.Drawing.Point(15, 363);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(87, 29);
            this.cbCliente.TabIndex = 145;
            this.cbCliente.Text = "Cliente";
            this.cbCliente.UseVisualStyleBackColor = true;
            this.cbCliente.CheckedChanged += new System.EventHandler(this.cbCliente_CheckedChanged);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(914, 827);
            this.ControlBox = false;
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.btnsrbEliminar);
            this.Controls.Add(this.dgsrbDetalles);
            this.Controls.Add(this.gbsrbTotales);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblsrbTitulo);
            this.Controls.Add(this.btnsrbSalir);
            this.Controls.Add(this.gbsrbProducto);
            this.Controls.Add(this.menusrbTitulo);
            this.Controls.Add(this.gbsrbDatosCliente);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsrbProductos)).EndInit();
            this.gbsrbProducto.ResumeLayout(false);
            this.gbsrbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbsrbFoto)).EndInit();
            this.gbsrbDatosCliente.ResumeLayout(false);
            this.gbsrbDatosCliente.PerformLayout();
            this.gbsrbTotales.ResumeLayout(false);
            this.gbsrbTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsrbDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsrbSalir;
        private System.Windows.Forms.Label lblsrbTitulo;
        private System.Windows.Forms.MenuStrip menusrbTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbsrbProducto;
        private System.Windows.Forms.GroupBox gbsrbDatosCliente;
        private System.Windows.Forms.GroupBox gbsrbTotales;
        private System.Windows.Forms.Label lblsrbDescProd;
        private System.Windows.Forms.Label lblsrbCategoria;
        private System.Windows.Forms.Label lblsrbCant;
        private System.Windows.Forms.Label lblsrbVenta;
        private System.Windows.Forms.Label lblsrbStock;
        private System.Windows.Forms.Label lblsrbNomC;
        private System.Windows.Forms.Label lblsrbTelC;
        private System.Windows.Forms.Label lblsrbCorreoC;
        private System.Windows.Forms.Label lblsrbSub;
        private System.Windows.Forms.Label lblsrbIVA;
        private System.Windows.Forms.Label lblsrbTotal;
        private System.Windows.Forms.Label lblsrbPago;
        private System.Windows.Forms.Label lblsrbCambio;
        private System.Windows.Forms.TextBox txtsrbDesc;
        private System.Windows.Forms.TextBox txtsrbCat;
        private System.Windows.Forms.TextBox txtsrbCant;
        private System.Windows.Forms.TextBox txtsrbPVenta;
        private System.Windows.Forms.TextBox txtsrbStock;
        private System.Windows.Forms.TextBox txtsrbNomC;
        private System.Windows.Forms.TextBox txtsrbTelC;
        private System.Windows.Forms.TextBox txtsrbCorreoC;
        private System.Windows.Forms.TextBox txtsrbSub;
        private System.Windows.Forms.TextBox txtsrbIVA;
        private System.Windows.Forms.TextBox txtsrbTotal;
        private System.Windows.Forms.TextBox txtsrbPago;
        private System.Windows.Forms.TextBox txtsrbCambio;
        private FontAwesome.Sharp.IconButton btnsrbAgregar;
        private FontAwesome.Sharp.IconButton btnsrbTerminarVenta;
        private System.Windows.Forms.PictureBox pbsrbFoto;
        private System.Windows.Forms.DataGridView dgsrbDetalles;
        private System.Windows.Forms.DataGridView dgsrbProductos;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private FontAwesome.Sharp.IconButton btnsrbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgsrbProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgsrbCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgsrbPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgsrbTotal;
        private System.Windows.Forms.CheckBox cbCliente;
    }
}