
namespace Formulario_Proyecto_Final
{
    partial class Form1
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
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtEficiencia = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.cbTrabajos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnConsultarEficiencia = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(431, 86);
            this.txtNumeroCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(245, 38);
            this.txtNumeroCuenta.TabIndex = 0;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(308, 147);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(358, 38);
            this.txtPrimerNombre.TabIndex = 1;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(934, 150);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(350, 38);
            this.txtSegundoNombre.TabIndex = 2;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(308, 217);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(358, 38);
            this.txtApellidoPaterno.TabIndex = 3;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(934, 215);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(350, 38);
            this.txtApellidoMaterno.TabIndex = 4;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(253, 519);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(1031, 38);
            this.txtReferencia.TabIndex = 6;
            // 
            // txtEficiencia
            // 
            this.txtEficiencia.Location = new System.Drawing.Point(484, 588);
            this.txtEficiencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEficiencia.Name = "txtEficiencia";
            this.txtEficiencia.Size = new System.Drawing.Size(134, 38);
            this.txtEficiencia.TabIndex = 7;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(382, 286);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFecha.Mask = "0000/00/00";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(236, 38);
            this.txtFecha.TabIndex = 8;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // cbTrabajos
            // 
            this.cbTrabajos.FormattingEnabled = true;
            this.cbTrabajos.Location = new System.Drawing.Point(392, 449);
            this.cbTrabajos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTrabajos.MaxLength = 100;
            this.cbTrabajos.Name = "cbTrabajos";
            this.cbTrabajos.Size = new System.Drawing.Size(284, 39);
            this.cbTrabajos.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numero de Cuenta Coppel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Primer Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Segundo Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Apellido Paterno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Apellido Materno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Trabajo Desempeñado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Referencias:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 591);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(397, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Eficiencia de Pago en Coppel:";
            // 
            // BtnConsultarEficiencia
            // 
            this.BtnConsultarEficiencia.Location = new System.Drawing.Point(676, 585);
            this.BtnConsultarEficiencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConsultarEficiencia.Name = "BtnConsultarEficiencia";
            this.BtnConsultarEficiencia.Size = new System.Drawing.Size(297, 54);
            this.BtnConsultarEficiencia.TabIndex = 19;
            this.BtnConsultarEficiencia.Text = "Consultar Eficiencia";
            this.BtnConsultarEficiencia.UseVisualStyleBackColor = true;
            this.BtnConsultarEficiencia.Click += new System.EventHandler(this.BtnConsultarEficiencia_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Location = new System.Drawing.Point(831, 661);
            this.BtnGrabar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(177, 61);
            this.BtnGrabar.TabIndex = 20;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(1062, 661);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(177, 61);
            this.BtnSalir.TabIndex = 21;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 32);
            this.label10.TabIndex = 23;
            this.label10.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(233, 369);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(245, 38);
            this.txtDomicilio.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 773);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGrabar);
            this.Controls.Add(this.BtnConsultarEficiencia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTrabajos);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtEficiencia);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Solicitud de Targeta de Credito BanCoppel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtEficiencia;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.ComboBox cbTrabajos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnConsultarEficiencia;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDomicilio;
    }
}

