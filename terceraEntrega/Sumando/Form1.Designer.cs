namespace Sumando
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.solucion = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.resetear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de sumandos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introduce 1º numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Introduce 2º numero:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultado:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(179, 71);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(100, 20);
            this.numero1.TabIndex = 4;
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(179, 106);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(100, 20);
            this.numero2.TabIndex = 5;
            // 
            // solucion
            // 
            this.solucion.Location = new System.Drawing.Point(119, 167);
            this.solucion.Name = "solucion";
            this.solucion.Size = new System.Drawing.Size(100, 20);
            this.solucion.TabIndex = 6;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(63, 248);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 7;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // resetear
            // 
            this.resetear.Location = new System.Drawing.Point(204, 248);
            this.resetear.Name = "resetear";
            this.resetear.Size = new System.Drawing.Size(75, 23);
            this.resetear.TabIndex = 8;
            this.resetear.Text = "Limpiar";
            this.resetear.UseVisualStyleBackColor = true;
            this.resetear.Click += new System.EventHandler(this.resetear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 316);
            this.Controls.Add(this.resetear);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.solucion);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(362, 355);
            this.MinimumSize = new System.Drawing.Size(362, 355);
            this.Name = "Form1";
            this.Text = "CalculadoraOP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.TextBox solucion;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button resetear;
    }
}

