
namespace LaTiendaIS2021.Presentacion.Vistas
{
    partial class VistaAgregarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.arriba = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCostoIva = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxRubro = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.abajo = new System.Windows.Forms.Panel();
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.principal = new System.Windows.Forms.Panel();
            this.medio = new System.Windows.Forms.Panel();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.txtMargenGanancia = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bsProducto = new System.Windows.Forms.BindingSource(this.components);
            this.rubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arriba.SuspendLayout();
            this.panel3.SuspendLayout();
            this.abajo.SuspendLayout();
            this.principal.SuspendLayout();
            this.medio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Producto";
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVolver.Location = new System.Drawing.Point(592, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(66, 56);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // arriba
            // 
            this.arriba.BackColor = System.Drawing.Color.Transparent;
            this.arriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arriba.Controls.Add(this.btnVolver);
            this.arriba.Controls.Add(this.panel3);
            this.arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.arriba.Location = new System.Drawing.Point(0, 0);
            this.arriba.Name = "arriba";
            this.arriba.Size = new System.Drawing.Size(658, 56);
            this.arriba.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(728, 56);
            this.panel3.TabIndex = 0;
            // 
            // txtCostoIva
            // 
            this.txtCostoIva.AcceptsTab = true;
            this.txtCostoIva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "CostoConIva", true));
            this.txtCostoIva.Location = new System.Drawing.Point(274, 184);
            this.txtCostoIva.Name = "txtCostoIva";
            this.txtCostoIva.Size = new System.Drawing.Size(121, 20);
            this.txtCostoIva.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(101, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "COSTO CON IVA: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Codigo", true));
            this.txtCodigo.Location = new System.Drawing.Point(274, 14);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(122, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(169, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "CODIGO:";
            // 
            // cbxRubro
            // 
            this.cbxRubro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rubroBindingSource, "Descripcion", true));
            this.cbxRubro.FormattingEnabled = true;
            this.cbxRubro.Location = new System.Drawing.Point(274, 291);
            this.cbxRubro.Name = "cbxRubro";
            this.cbxRubro.Size = new System.Drawing.Size(121, 21);
            this.cbxRubro.TabIndex = 9;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marcaBindingSource, "Descripcion", true));
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(275, 258);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxMarca.TabIndex = 8;
            // 
            // txtIVA
            // 
            this.txtIVA.AcceptsTab = true;
            this.txtIVA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "PorcentajeIva", true));
            this.txtIVA.Location = new System.Drawing.Point(274, 113);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(121, 20);
            this.txtIVA.TabIndex = 4;
            // 
            // abajo
            // 
            this.abajo.BackColor = System.Drawing.Color.Transparent;
            this.abajo.Controls.Add(this.btnCancelarProducto);
            this.abajo.Controls.Add(this.btnGuardarProducto);
            this.abajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.abajo.Location = new System.Drawing.Point(0, 406);
            this.abajo.Name = "abajo";
            this.abajo.Size = new System.Drawing.Size(658, 49);
            this.abajo.TabIndex = 2;
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarProducto.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelarProducto.Font = new System.Drawing.Font("Showcard Gothic", 15.75F);
            this.btnCancelarProducto.Location = new System.Drawing.Point(368, 0);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(145, 49);
            this.btnCancelarProducto.TabIndex = 1;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = false;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarProducto.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.Location = new System.Drawing.Point(513, 0);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(145, 49);
            this.btnGuardarProducto.TabIndex = 10;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // principal
            // 
            this.principal.BackColor = System.Drawing.Color.Transparent;
            this.principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.principal.Controls.Add(this.abajo);
            this.principal.Controls.Add(this.medio);
            this.principal.Controls.Add(this.arriba);
            this.principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.principal.Location = new System.Drawing.Point(0, 0);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(658, 455);
            this.principal.TabIndex = 2;
            // 
            // medio
            // 
            this.medio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medio.Controls.Add(this.txtCostoIva);
            this.medio.Controls.Add(this.label9);
            this.medio.Controls.Add(this.txtCodigo);
            this.medio.Controls.Add(this.label10);
            this.medio.Controls.Add(this.cbxRubro);
            this.medio.Controls.Add(this.cbxMarca);
            this.medio.Controls.Add(this.txtIVA);
            this.medio.Controls.Add(this.txtPrecioCosto);
            this.medio.Controls.Add(this.txtMargenGanancia);
            this.medio.Controls.Add(this.txtPrecioVenta);
            this.medio.Controls.Add(this.txtDescripcionProducto);
            this.medio.Controls.Add(this.label8);
            this.medio.Controls.Add(this.label7);
            this.medio.Controls.Add(this.label6);
            this.medio.Controls.Add(this.label5);
            this.medio.Controls.Add(this.label4);
            this.medio.Controls.Add(this.label3);
            this.medio.Controls.Add(this.label2);
            this.medio.Location = new System.Drawing.Point(61, 62);
            this.medio.Name = "medio";
            this.medio.Size = new System.Drawing.Size(558, 320);
            this.medio.TabIndex = 1;
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.AcceptsTab = true;
            this.txtPrecioCosto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "CostoSinIva", true));
            this.txtPrecioCosto.Location = new System.Drawing.Point(274, 76);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioCosto.TabIndex = 3;
            // 
            // txtMargenGanancia
            // 
            this.txtMargenGanancia.AcceptsTab = true;
            this.txtMargenGanancia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "MargenGanancia", true));
            this.txtMargenGanancia.Location = new System.Drawing.Point(276, 152);
            this.txtMargenGanancia.Name = "txtMargenGanancia";
            this.txtMargenGanancia.Size = new System.Drawing.Size(120, 20);
            this.txtMargenGanancia.TabIndex = 5;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.AcceptsTab = true;
            this.txtPrecioVenta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "PrecioVenta", true));
            this.txtPrecioVenta.Enabled = false;
            this.txtPrecioVenta.Location = new System.Drawing.Point(274, 220);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioVenta.TabIndex = 7;
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.AcceptsTab = true;
            this.txtDescripcionProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Descripcion", true));
            this.txtDescripcionProducto.Location = new System.Drawing.Point(276, 46);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(222, 20);
            this.txtDescripcionProducto.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "MARGEN DE GANANCIA: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "PRECIO DE VENTA: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "MARCA: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "RUBRO: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "IVA: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "PRECIO DE COSTO: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "DESCRIPCIÓN: ";
            // 
            // bsProducto
            // 
            this.bsProducto.DataSource = typeof(LaTiendaIS2021.Dominio.Modelo.Producto);
            // 
            // rubroBindingSource
            // 
            this.rubroBindingSource.DataSource = typeof(LaTiendaIS2021.Dominio.Modelo.Rubro);
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataSource = typeof(LaTiendaIS2021.Dominio.Modelo.Marca);
            // 
            // VistaAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 455);
            this.Controls.Add(this.principal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VistaAgregarProducto";
            this.Text = "VistaAgregarProducto";
            this.Load += new System.EventHandler(this.VistaAgregarProducto_Load);
            this.arriba.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.abajo.ResumeLayout(false);
            this.principal.ResumeLayout(false);
            this.medio.ResumeLayout(false);
            this.medio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel arriba;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCostoIva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxRubro;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Panel abajo;
        private System.Windows.Forms.Button btnCancelarProducto;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Panel principal;
        private System.Windows.Forms.Panel medio;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.TextBox txtMargenGanancia;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsProducto;
        private System.Windows.Forms.BindingSource rubroBindingSource;
        private System.Windows.Forms.BindingSource marcaBindingSource;
    }
}