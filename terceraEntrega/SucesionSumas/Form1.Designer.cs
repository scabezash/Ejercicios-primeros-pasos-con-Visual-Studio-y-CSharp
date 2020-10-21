namespace SucesionSumas
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
            this.verResultados = new System.Windows.Forms.CheckBox();
            this.limite = new System.Windows.Forms.NumericUpDown();
            this.Lista = new System.Windows.Forms.ListBox();
            this.calcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.limite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular suma desde 1 hasta:";
            // 
            // verResultados
            // 
            this.verResultados.AutoSize = true;
            this.verResultados.Location = new System.Drawing.Point(32, 77);
            this.verResultados.Name = "verResultados";
            this.verResultados.Size = new System.Drawing.Size(138, 17);
            this.verResultados.TabIndex = 1;
            this.verResultados.Text = "Ver resultados parciales";
            this.verResultados.UseVisualStyleBackColor = true;
            // 
            // limite
            // 
            this.limite.Location = new System.Drawing.Point(181, 28);
            this.limite.Name = "limite";
            this.limite.Size = new System.Drawing.Size(120, 20);
            this.limite.TabIndex = 3;
            this.limite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(32, 122);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(269, 225);
            this.Lista.TabIndex = 4;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(127, 353);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 5;
            this.calcular.Text = "Iniciar";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 390);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.limite);
            this.Controls.Add(this.verResultados);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(343, 429);
            this.MinimumSize = new System.Drawing.Size(343, 429);
            this.Name = "Form1";
            this.Text = "Sucesión de sumas";
            ((System.ComponentModel.ISupportInitialize)(this.limite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox verResultados;
        private System.Windows.Forms.NumericUpDown limite;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button calcular;
    }
}

