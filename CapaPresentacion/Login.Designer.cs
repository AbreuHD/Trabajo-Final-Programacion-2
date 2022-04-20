namespace NetFramework.Layers.WinApp
{
    partial class Login
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tBUsuario = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(27, 32);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(101, 37);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(98, 317);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(164, 44);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tBUsuario
            // 
            this.tBUsuario.Location = new System.Drawing.Point(89, 158);
            this.tBUsuario.Name = "tBUsuario";
            this.tBUsuario.Size = new System.Drawing.Size(202, 20);
            this.tBUsuario.TabIndex = 2;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(94, 135);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(71, 20);
            this.lbUsuario.TabIndex = 3;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(94, 209);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(102, 20);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Contraseña";
            // 
            // tBPassword
            // 
            this.tBPassword.Location = new System.Drawing.Point(89, 232);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.Size = new System.Drawing.Size(202, 20);
            this.tBPassword.TabIndex = 4;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 429);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tBPassword);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.tBUsuario);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tBUsuario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tBPassword;
    }
}