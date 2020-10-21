namespace Login
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
            this.login = new System.Windows.Forms.TextBox();
            this.iniciar = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(73, 148);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(150, 20);
            this.login.TabIndex = 3;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // iniciar
            // 
            this.iniciar.Location = new System.Drawing.Point(98, 207);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(89, 35);
            this.iniciar.TabIndex = 4;
            this.iniciar.Text = "Iniciar sesión";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // resultado
            // 
            this.resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultado.Location = new System.Drawing.Point(62, 280);
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            this.resultado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resultado.Size = new System.Drawing.Size(172, 13);
            this.resultado.TabIndex = 5;
            this.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resultado.TextChanged += new System.EventHandler(this.resultado_TextChanged);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(73, 70);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(150, 20);
            this.user.TabIndex = 6;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 361);
            this.Controls.Add(this.user);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(320, 400);
            this.MinimumSize = new System.Drawing.Size(320, 400);
            this.Name = "Form1";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.TextBox user;
    }
}

