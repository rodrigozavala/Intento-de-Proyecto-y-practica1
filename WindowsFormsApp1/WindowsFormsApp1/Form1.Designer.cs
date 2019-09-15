namespace WindowsFormsApp1
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
            this.labelNombreDeUsuario = new System.Windows.Forms.Label();
            this.txtBNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtBPassword = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.bttnEntrar = new System.Windows.Forms.Button();
            this.bttnRegistrarse = new System.Windows.Forms.Button();
            this.linkLOlvidePassword = new System.Windows.Forms.LinkLabel();
            this.linkLEmpleado = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelNombreDeUsuario
            // 
            this.labelNombreDeUsuario.AutoSize = true;
            this.labelNombreDeUsuario.Location = new System.Drawing.Point(51, 69);
            this.labelNombreDeUsuario.Name = "labelNombreDeUsuario";
            this.labelNombreDeUsuario.Size = new System.Drawing.Size(98, 13);
            this.labelNombreDeUsuario.TabIndex = 0;
            this.labelNombreDeUsuario.Text = "Nombre de Usuario";
            // 
            // txtBNombreUsuario
            // 
            this.txtBNombreUsuario.Location = new System.Drawing.Point(155, 66);
            this.txtBNombreUsuario.Name = "txtBNombreUsuario";
            this.txtBNombreUsuario.Size = new System.Drawing.Size(173, 20);
            this.txtBNombreUsuario.TabIndex = 1;
            // 
            // txtBPassword
            // 
            this.txtBPassword.Location = new System.Drawing.Point(155, 116);
            this.txtBPassword.Name = "txtBPassword";
            this.txtBPassword.Size = new System.Drawing.Size(173, 20);
            this.txtBPassword.TabIndex = 3;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(51, 116);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(61, 13);
            this.labelContraseña.TabIndex = 2;
            this.labelContraseña.Text = "Contraseña";
            this.labelContraseña.Click += new System.EventHandler(this.label2_Click);
            // 
            // bttnEntrar
            // 
            this.bttnEntrar.Location = new System.Drawing.Point(155, 158);
            this.bttnEntrar.Name = "bttnEntrar";
            this.bttnEntrar.Size = new System.Drawing.Size(78, 29);
            this.bttnEntrar.TabIndex = 4;
            this.bttnEntrar.Text = "Entrar";
            this.bttnEntrar.UseVisualStyleBackColor = true;
            this.bttnEntrar.Click += new System.EventHandler(this.bttnEntrar_Click);
            // 
            // bttnRegistrarse
            // 
            this.bttnRegistrarse.Location = new System.Drawing.Point(250, 158);
            this.bttnRegistrarse.Name = "bttnRegistrarse";
            this.bttnRegistrarse.Size = new System.Drawing.Size(78, 29);
            this.bttnRegistrarse.TabIndex = 5;
            this.bttnRegistrarse.Text = "Registrarse";
            this.bttnRegistrarse.UseVisualStyleBackColor = true;
            this.bttnRegistrarse.Click += new System.EventHandler(this.bttnRegistrarse_Click);
            // 
            // linkLOlvidePassword
            // 
            this.linkLOlvidePassword.AutoSize = true;
            this.linkLOlvidePassword.Location = new System.Drawing.Point(152, 211);
            this.linkLOlvidePassword.Name = "linkLOlvidePassword";
            this.linkLOlvidePassword.Size = new System.Drawing.Size(106, 13);
            this.linkLOlvidePassword.TabIndex = 6;
            this.linkLOlvidePassword.TabStop = true;
            this.linkLOlvidePassword.Text = "Olvidé mi contraseña";
            // 
            // linkLEmpleado
            // 
            this.linkLEmpleado.AutoSize = true;
            this.linkLEmpleado.Location = new System.Drawing.Point(152, 238);
            this.linkLEmpleado.Name = "linkLEmpleado";
            this.linkLEmpleado.Size = new System.Drawing.Size(89, 13);
            this.linkLEmpleado.TabIndex = 7;
            this.linkLEmpleado.TabStop = true;
            this.linkLEmpleado.Text = "Soy un empleado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.linkLEmpleado);
            this.Controls.Add(this.linkLOlvidePassword);
            this.Controls.Add(this.bttnRegistrarse);
            this.Controls.Add(this.bttnEntrar);
            this.Controls.Add(this.txtBPassword);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.txtBNombreUsuario);
            this.Controls.Add(this.labelNombreDeUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreDeUsuario;
        private System.Windows.Forms.TextBox txtBNombreUsuario;
        private System.Windows.Forms.TextBox txtBPassword;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Button bttnEntrar;
        private System.Windows.Forms.Button bttnRegistrarse;
        private System.Windows.Forms.LinkLabel linkLOlvidePassword;
        private System.Windows.Forms.LinkLabel linkLEmpleado;
    }
}

