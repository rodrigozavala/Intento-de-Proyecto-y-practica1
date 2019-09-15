namespace WindowsFormsApp1
{
    partial class RegistrarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.txtBNickName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bttnRegistrarse = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.labelEdad = new System.Windows.Forms.Label();
            this.txtBEdad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBSexo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(129, 41);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(233, 20);
            this.txtBNombre.TabIndex = 1;
            // 
            // txtBNickName
            // 
            this.txtBNickName.Location = new System.Drawing.Point(129, 85);
            this.txtBNickName.Name = "txtBNickName";
            this.txtBNickName.Size = new System.Drawing.Size(233, 20);
            this.txtBNickName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de \r\nusuario";
            // 
            // txtBCorreo
            // 
            this.txtBCorreo.Location = new System.Drawing.Point(129, 112);
            this.txtBCorreo.Name = "txtBCorreo";
            this.txtBCorreo.Size = new System.Drawing.Size(233, 20);
            this.txtBCorreo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo";
            // 
            // txtBPassword
            // 
            this.txtBPassword.Location = new System.Drawing.Point(129, 147);
            this.txtBPassword.Name = "txtBPassword";
            this.txtBPassword.Size = new System.Drawing.Size(233, 20);
            this.txtBPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña";
            // 
            // txtBDireccion
            // 
            this.txtBDireccion.Location = new System.Drawing.Point(129, 173);
            this.txtBDireccion.Name = "txtBDireccion";
            this.txtBDireccion.Size = new System.Drawing.Size(233, 20);
            this.txtBDireccion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirección";
            // 
            // txtBTelefono
            // 
            this.txtBTelefono.Location = new System.Drawing.Point(129, 206);
            this.txtBTelefono.Name = "txtBTelefono";
            this.txtBTelefono.Size = new System.Drawing.Size(233, 20);
            this.txtBTelefono.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefono";
            // 
            // bttnRegistrarse
            // 
            this.bttnRegistrarse.Location = new System.Drawing.Point(129, 271);
            this.bttnRegistrarse.Name = "bttnRegistrarse";
            this.bttnRegistrarse.Size = new System.Drawing.Size(118, 30);
            this.bttnRegistrarse.TabIndex = 12;
            this.bttnRegistrarse.Text = "Registrarse";
            this.bttnRegistrarse.UseVisualStyleBackColor = true;
            this.bttnRegistrarse.Click += new System.EventHandler(this.bttnRegistrarse_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Location = new System.Drawing.Point(253, 271);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(118, 30);
            this.bttnCancelar.TabIndex = 13;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(80, 237);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(32, 13);
            this.labelEdad.TabIndex = 14;
            this.labelEdad.Text = "Edad";
            // 
            // txtBEdad
            // 
            this.txtBEdad.Location = new System.Drawing.Point(129, 234);
            this.txtBEdad.Name = "txtBEdad";
            this.txtBEdad.Size = new System.Drawing.Size(29, 20);
            this.txtBEdad.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sexo";
            // 
            // txtBSexo
            // 
            this.txtBSexo.Location = new System.Drawing.Point(218, 237);
            this.txtBSexo.Name = "txtBSexo";
            this.txtBSexo.Size = new System.Drawing.Size(111, 20);
            this.txtBSexo.TabIndex = 17;
            // 
            // RegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 330);
            this.Controls.Add(this.txtBSexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBEdad);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnRegistrarse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBTelefono);
            this.Controls.Add(this.txtBDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBNickName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBNombre);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarCliente";
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.TextBox txtBNickName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnRegistrarse;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox txtBEdad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBSexo;
    }
}