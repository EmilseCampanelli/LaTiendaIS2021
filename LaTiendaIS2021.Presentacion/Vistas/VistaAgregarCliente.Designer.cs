
namespace LaTiendaIS2021.Presentacion.Vistas
{
    partial class VistaAgregarCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCuilCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtDomicilioCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bsCliente = new System.Windows.Forms.BindingSource(this.components);
            this.condicionTributariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicionTributariaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "CUIL: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "RAZON SOCIAL: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "DOMICILIO: ";
            // 
            // txtCuilCliente
            // 
            this.txtCuilCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "Cuit", true));
            this.txtCuilCliente.Location = new System.Drawing.Point(423, 153);
            this.txtCuilCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCuilCliente.Name = "txtCuilCliente";
            this.txtCuilCliente.Size = new System.Drawing.Size(307, 22);
            this.txtCuilCliente.TabIndex = 23;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "RazonSocial", true));
            this.txtNombreCliente.Location = new System.Drawing.Point(423, 228);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(308, 22);
            this.txtNombreCliente.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(191, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 48);
            this.label1.TabIndex = 17;
            this.label1.Text = "Agregar Cliente";
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(820, 565);
            this.btnGuardarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(147, 46);
            this.btnGuardarCliente.TabIndex = 26;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(878, 15);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 70);
            this.btnVolver.TabIndex = 27;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtDomicilioCliente
            // 
            this.txtDomicilioCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "Domicilio", true));
            this.txtDomicilioCliente.Location = new System.Drawing.Point(423, 295);
            this.txtDomicilioCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomicilioCliente.Name = "txtDomicilioCliente";
            this.txtDomicilioCliente.Size = new System.Drawing.Size(308, 22);
            this.txtDomicilioCliente.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "CONDICION TRIBUTARIA:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.condicionTributariaBindingSource, "Descripcion", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(423, 432);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 24);
            this.comboBox1.TabIndex = 25;
            // 
            // bsCliente
            // 
            this.bsCliente.DataSource = typeof(LaTiendaIS2021.Dominio.Modelo.Cliente);
            // 
            // condicionTributariaBindingSource
            // 
            this.condicionTributariaBindingSource.DataSource = typeof(LaTiendaIS2021.Dominio.Modelo.CondicionTributaria);
            // 
            // VistaAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 624);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDomicilioCliente);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtCuilCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "VistaAgregarCliente";
            this.Text = "VistaAgregarCliente";
            this.Load += new System.EventHandler(this.VistaAgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicionTributariaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCuilCliente;
        private System.Windows.Forms.BindingSource bsCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtDomicilioCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource condicionTributariaBindingSource;
    }
}