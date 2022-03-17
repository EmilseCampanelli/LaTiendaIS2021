
namespace LaTiendaIS2021.Presentacion.Vistas
{
    partial class RealizarVenta
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
            this.components = new System.ComponentModel.Container();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.abajo = new System.Windows.Forms.Panel();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.lblPuntoVenta = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.arriba = new System.Windows.Forms.Panel();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.arribaMedio = new System.Windows.Forms.Panel();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.lblCondicionTributaria = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblTipoDePago = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.principal = new System.Windows.Forms.Panel();
            this.medio = new System.Windows.Forms.Panel();
            this.medioMedio = new System.Windows.Forms.Panel();
            this.dgvLv = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RubroDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.cbxTalle = new System.Windows.Forms.ComboBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lineaVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abajo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.arriba.SuspendLayout();
            this.arribaMedio.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.principal.SuspendLayout();
            this.medio.SuspendLayout();
            this.medioMedio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmarVenta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfirmarVenta.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarVenta.Location = new System.Drawing.Point(631, 0);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(145, 49);
            this.btnConfirmarVenta.TabIndex = 0;
            this.btnConfirmarVenta.Text = "Confirmar";
            this.btnConfirmarVenta.UseVisualStyleBackColor = false;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // abajo
            // 
            this.abajo.BackColor = System.Drawing.Color.Transparent;
            this.abajo.Controls.Add(this.btnCancelarVenta);
            this.abajo.Controls.Add(this.btnConfirmarVenta);
            this.abajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.abajo.Location = new System.Drawing.Point(0, 458);
            this.abajo.Name = "abajo";
            this.abajo.Size = new System.Drawing.Size(776, 49);
            this.abajo.TabIndex = 2;
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarVenta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelarVenta.Font = new System.Drawing.Font("Showcard Gothic", 15.75F);
            this.btnCancelarVenta.Location = new System.Drawing.Point(486, 0);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(145, 49);
            this.btnCancelarVenta.TabIndex = 1;
            this.btnCancelarVenta.Text = "Cancelar";
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
//            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // lblPuntoVenta
            // 
            this.lblPuntoVenta.AutoSize = true;
            this.lblPuntoVenta.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoVenta.Location = new System.Drawing.Point(438, 9);
            this.lblPuntoVenta.Name = "lblPuntoVenta";
            this.lblPuntoVenta.Size = new System.Drawing.Size(93, 14);
            this.lblPuntoVenta.TabIndex = 2;
            this.lblPuntoVenta.Text = "Punto de Venta: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(517, 28);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 14);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realizar Venta";
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVolver.Location = new System.Drawing.Point(710, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(66, 56);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolver.UseVisualStyleBackColor = true;
            //this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblPuntoVenta);
            this.panel3.Controls.Add(this.lblUsuario);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(728, 56);
            this.panel3.TabIndex = 0;
            // 
            // arriba
            // 
            this.arriba.BackColor = System.Drawing.Color.White;
            this.arriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arriba.Controls.Add(this.btnVolver);
            this.arriba.Controls.Add(this.panel3);
            this.arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.arriba.Location = new System.Drawing.Point(0, 0);
            this.arriba.Name = "arriba";
            this.arriba.Size = new System.Drawing.Size(776, 56);
            this.arriba.TabIndex = 0;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(82, 9);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(54, 43);
            this.btnAgregarCliente.TabIndex = 9;
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cliente ";
            // 
            // arribaMedio
            // 
            this.arribaMedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arribaMedio.Controls.Add(this.pnlCliente);
            this.arribaMedio.Controls.Add(this.btnAgregarCliente);
            this.arribaMedio.Controls.Add(this.label3);
            this.arribaMedio.Dock = System.Windows.Forms.DockStyle.Top;
            this.arribaMedio.Location = new System.Drawing.Point(0, 0);
            this.arribaMedio.Name = "arribaMedio";
            this.arribaMedio.Size = new System.Drawing.Size(776, 59);
            this.arribaMedio.TabIndex = 9;
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.lblCondicionTributaria);
            this.pnlCliente.Controls.Add(this.lblRazonSocial);
            this.pnlCliente.Controls.Add(this.lblCuit);
            this.pnlCliente.Location = new System.Drawing.Point(170, 9);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(481, 43);
            this.pnlCliente.TabIndex = 10;
            this.pnlCliente.Visible = false;
            // 
            // lblCondicionTributaria
            // 
            this.lblCondicionTributaria.AutoSize = true;
            this.lblCondicionTributaria.Location = new System.Drawing.Point(312, 7);
            this.lblCondicionTributaria.Name = "lblCondicionTributaria";
            this.lblCondicionTributaria.Size = new System.Drawing.Size(35, 13);
            this.lblCondicionTributaria.TabIndex = 2;
            this.lblCondicionTributaria.Text = "label6";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(171, 7);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(35, 13);
            this.lblRazonSocial.TabIndex = 1;
            this.lblRazonSocial.Text = "label7";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(16, 7);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(25, 13);
            this.lblCuit.TabIndex = 0;
            this.lblCuit.Text = "Cuit";
            // 
            // lblTipoDePago
            // 
            this.lblTipoDePago.AutoSize = true;
            this.lblTipoDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDePago.Location = new System.Drawing.Point(82, 13);
            this.lblTipoDePago.Name = "lblTipoDePago";
            this.lblTipoDePago.Size = new System.Drawing.Size(54, 13);
            this.lblTipoDePago.TabIndex = 14;
            this.lblTipoDePago.Text = "Contado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tipo de pago: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 40);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTipoDePago);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 40);
            this.panel2.TabIndex = 14;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(249, 10);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(91, 20);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total de la venta: ";
            // 
            // principal
            // 
            this.principal.BackColor = System.Drawing.Color.Transparent;
            this.principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.principal.Controls.Add(this.medio);
            this.principal.Controls.Add(this.arriba);
            this.principal.Controls.Add(this.abajo);
            this.principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.principal.Location = new System.Drawing.Point(0, 0);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(776, 507);
            this.principal.TabIndex = 2;
            // 
            // medio
            // 
            this.medio.Controls.Add(this.medioMedio);
            this.medio.Controls.Add(this.arribaMedio);
            this.medio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medio.Location = new System.Drawing.Point(0, 56);
            this.medio.Name = "medio";
            this.medio.Size = new System.Drawing.Size(776, 402);
            this.medio.TabIndex = 1;
            // 
            // medioMedio
            // 
            this.medioMedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medioMedio.Controls.Add(this.dgvLv);
            this.medioMedio.Controls.Add(this.label8);
            this.medioMedio.Controls.Add(this.label7);
            this.medioMedio.Controls.Add(this.label6);
            this.medioMedio.Controls.Add(this.NudCantidad);
            this.medioMedio.Controls.Add(this.cbxColor);
            this.medioMedio.Controls.Add(this.cbxTalle);
            this.medioMedio.Controls.Add(this.btnBuscarProducto);
            this.medioMedio.Controls.Add(this.btnBorrar);
            this.medioMedio.Controls.Add(this.btnAgregar);
            this.medioMedio.Controls.Add(this.txtBuscarProducto);
            this.medioMedio.Controls.Add(this.label2);
            this.medioMedio.Controls.Add(this.panel1);
            this.medioMedio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medioMedio.Location = new System.Drawing.Point(0, 59);
            this.medioMedio.Name = "medioMedio";
            this.medioMedio.Size = new System.Drawing.Size(776, 343);
            this.medioMedio.TabIndex = 8;
            // 
            // dgvLv
            // 
            this.dgvLv.AutoGenerateColumns = false;
            this.dgvLv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.MarcaDescripcion,
            this.RubroDescripcion,
            this.precioVentaDataGridViewTextBoxColumn});
            this.dgvLv.DataSource = this.productoBindingSource;
            this.dgvLv.Location = new System.Drawing.Point(10, 44);
            this.dgvLv.Name = "dgvLv";
            this.dgvLv.Size = new System.Drawing.Size(541, 190);
            this.dgvLv.TabIndex = 20;
            this.dgvLv.Click += new System.EventHandler(this.dgvLV_Click);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // MarcaDescripcion
            // 
            this.MarcaDescripcion.DataPropertyName = "MarcaDescripcion";
            this.MarcaDescripcion.HeaderText = "MarcaDescripcion";
            this.MarcaDescripcion.Name = "MarcaDescripcion";
            this.MarcaDescripcion.ReadOnly = true;
            // 
            // RubroDescripcion
            // 
            this.RubroDescripcion.DataPropertyName = "RubroDescripcion";
            this.RubroDescripcion.HeaderText = "RubroDescripcion";
            this.RubroDescripcion.Name = "RubroDescripcion";
            this.RubroDescripcion.ReadOnly = true;
            // 
            // precioVentaDataGridViewTextBoxColumn
            // 
            this.precioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta";
            this.precioVentaDataGridViewTextBoxColumn.HeaderText = "PrecioVenta";
            this.precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(LaTiendaIS2021.Dominio.Modelo.Producto);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Talle";
            // 
            // NudCantidad
            // 
            this.NudCantidad.Location = new System.Drawing.Point(561, 167);
            this.NudCantidad.Name = "NudCantidad";
            this.NudCantidad.Size = new System.Drawing.Size(120, 20);
            this.NudCantidad.TabIndex = 16;
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(560, 111);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(121, 21);
            this.cbxColor.TabIndex = 15;
            // 
            // cbxTalle
            // 
            this.cbxTalle.FormattingEnabled = true;
            this.cbxTalle.Location = new System.Drawing.Point(560, 58);
            this.cbxTalle.Name = "cbxTalle";
            this.cbxTalle.Size = new System.Drawing.Size(121, 21);
            this.cbxTalle.TabIndex = 14;
           // this.cbxTalle.SelectedIndexChanged += new System.EventHandler(this.cbxTalle_SelectedIndexChanged);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(440, 4);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(23, 20);
            this.btnBuscarProducto.TabIndex = 13;
            this.btnBuscarProducto.Text = "button1";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(701, 152);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(50, 47);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Eliminar Linea De Venta";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(701, 44);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 47);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "AgregarLV";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(226, 4);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(202, 20);
            this.txtBuscarProducto.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "CODIGO PRODUCTO: ";
            // 
            // lineaVentaBindingSource
            // 
            this.lineaVentaBindingSource.DataSource = typeof(LaTiendaIS2021.Dominio.Modelo.LineaVenta);
            // 
            // RealizarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 507);
            this.Controls.Add(this.principal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RealizarVenta";
            this.Text = "RealizarVenta";
            this.Load += new System.EventHandler(this.RealizarVenta_Load);
            this.abajo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.arriba.ResumeLayout(false);
            this.arribaMedio.ResumeLayout(false);
            this.arribaMedio.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.principal.ResumeLayout(false);
            this.medio.ResumeLayout(false);
            this.medioMedio.ResumeLayout(false);
            this.medioMedio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Panel abajo;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Label lblPuntoVenta;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel arriba;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel arribaMedio;
        private System.Windows.Forms.Label lblTipoDePago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel principal;
        private System.Windows.Forms.Panel medio;
        private System.Windows.Forms.Panel medioMedio;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown NudCantidad;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.ComboBox cbxTalle;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.BindingSource lineaVentaBindingSource;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblCondicionTributaria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvLv;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubroDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn RubroDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
    }
}