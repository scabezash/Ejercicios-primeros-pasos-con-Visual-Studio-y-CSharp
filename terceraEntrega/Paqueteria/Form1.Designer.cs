namespace Paqueteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textoTitulo = new System.Windows.Forms.Label();
            this.envioLento = new System.Windows.Forms.RadioButton();
            this.envioNormal = new System.Windows.Forms.RadioButton();
            this.envioRápido = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.notificacionEmail = new System.Windows.Forms.CheckBox();
            this.notificacionSMS = new System.Windows.Forms.CheckBox();
            this.notificacionFax = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textoTitulo
            // 
            this.textoTitulo.AutoSize = true;
            this.textoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTitulo.Location = new System.Drawing.Point(115, 9);
            this.textoTitulo.Name = "textoTitulo";
            this.textoTitulo.Size = new System.Drawing.Size(275, 24);
            this.textoTitulo.TabIndex = 0;
            this.textoTitulo.Text = "Calcula el coste de un envío";
            // 
            // envioLento
            // 
            this.envioLento.AutoSize = true;
            this.envioLento.Location = new System.Drawing.Point(33, 123);
            this.envioLento.Name = "envioLento";
            this.envioLento.Size = new System.Drawing.Size(128, 17);
            this.envioLento.TabIndex = 1;
            this.envioLento.TabStop = true;
            this.envioLento.Text = "Correo Normal (3,99€)";
            this.envioLento.UseVisualStyleBackColor = true;
            // 
            // envioNormal
            // 
            this.envioNormal.AutoSize = true;
            this.envioNormal.Location = new System.Drawing.Point(33, 180);
            this.envioNormal.Name = "envioNormal";
            this.envioNormal.Size = new System.Drawing.Size(150, 17);
            this.envioNormal.TabIndex = 2;
            this.envioNormal.TabStop = true;
            this.envioNormal.Text = "Paquetería Normal (5,31€)";
            this.envioNormal.UseVisualStyleBackColor = true;
            // 
            // envioRápido
            // 
            this.envioRápido.AutoSize = true;
            this.envioRápido.Location = new System.Drawing.Point(33, 236);
            this.envioRápido.Name = "envioRápido";
            this.envioRápido.Size = new System.Drawing.Size(155, 17);
            this.envioRápido.TabIndex = 3;
            this.envioRápido.TabStop = true;
            this.envioRápido.Text = "Paquetería Urgente (7,99€)";
            this.envioRápido.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elija el método envío";
            // 
            // notificacionEmail
            // 
            this.notificacionEmail.AutoSize = true;
            this.notificacionEmail.Location = new System.Drawing.Point(309, 123);
            this.notificacionEmail.Name = "notificacionEmail";
            this.notificacionEmail.Size = new System.Drawing.Size(87, 17);
            this.notificacionEmail.TabIndex = 5;
            this.notificacionEmail.Text = "Email (Gratis)";
            this.notificacionEmail.UseVisualStyleBackColor = true;
            // 
            // notificacionSMS
            // 
            this.notificacionSMS.AutoSize = true;
            this.notificacionSMS.Location = new System.Drawing.Point(309, 180);
            this.notificacionSMS.Name = "notificacionSMS";
            this.notificacionSMS.Size = new System.Drawing.Size(85, 17);
            this.notificacionSMS.TabIndex = 6;
            this.notificacionSMS.Text = "SMS (0,90€)";
            this.notificacionSMS.UseVisualStyleBackColor = true;
            // 
            // notificacionFax
            // 
            this.notificacionFax.AutoSize = true;
            this.notificacionFax.Location = new System.Drawing.Point(309, 236);
            this.notificacionFax.Name = "notificacionFax";
            this.notificacionFax.Size = new System.Drawing.Size(79, 17);
            this.notificacionFax.TabIndex = 7;
            this.notificacionFax.Text = "Fax (1,20€)";
            this.notificacionFax.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 72);
            this.label2.MaximumSize = new System.Drawing.Size(200, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "¿Quieres recibir notificaciones sobre el estado del pedido?";
            // 
            // botonCalcular
            // 
            this.botonCalcular.Location = new System.Drawing.Point(219, 306);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(75, 23);
            this.botonCalcular.TabIndex = 9;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(251, 366);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 24);
            this.resultado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 457);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notificacionFax);
            this.Controls.Add(this.notificacionSMS);
            this.Controls.Add(this.notificacionEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.envioRápido);
            this.Controls.Add(this.envioNormal);
            this.Controls.Add(this.envioLento);
            this.Controls.Add(this.textoTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Servicio de envios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoTitulo;
        private System.Windows.Forms.RadioButton envioLento;
        private System.Windows.Forms.RadioButton envioNormal;
        private System.Windows.Forms.RadioButton envioRápido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox notificacionEmail;
        private System.Windows.Forms.CheckBox notificacionSMS;
        private System.Windows.Forms.CheckBox notificacionFax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.Label resultado;
    }
}

