namespace Apresentacao
{
    partial class FrmLogin
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
            this.labelLoginUsuario = new System.Windows.Forms.Label();
            this.labelLoginSenha = new System.Windows.Forms.Label();
            this.textBoxLoginUsuario = new System.Windows.Forms.TextBox();
            this.textBoxLoginSenha = new System.Windows.Forms.TextBox();
            this.buttonLoginOK = new System.Windows.Forms.Button();
            this.buttonLoginCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLoginUsuario
            // 
            this.labelLoginUsuario.AutoSize = true;
            this.labelLoginUsuario.Location = new System.Drawing.Point(31, 37);
            this.labelLoginUsuario.Name = "labelLoginUsuario";
            this.labelLoginUsuario.Size = new System.Drawing.Size(46, 13);
            this.labelLoginUsuario.TabIndex = 0;
            this.labelLoginUsuario.Text = "Usuário:";
            // 
            // labelLoginSenha
            // 
            this.labelLoginSenha.AutoSize = true;
            this.labelLoginSenha.Location = new System.Drawing.Point(31, 75);
            this.labelLoginSenha.Name = "labelLoginSenha";
            this.labelLoginSenha.Size = new System.Drawing.Size(44, 13);
            this.labelLoginSenha.TabIndex = 1;
            this.labelLoginSenha.Text = "Senha: ";
            // 
            // textBoxLoginUsuario
            // 
            this.textBoxLoginUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxLoginUsuario.Location = new System.Drawing.Point(93, 33);
            this.textBoxLoginUsuario.Name = "textBoxLoginUsuario";
            this.textBoxLoginUsuario.Size = new System.Drawing.Size(173, 20);
            this.textBoxLoginUsuario.TabIndex = 2;
            // 
            // textBoxLoginSenha
            // 
            this.textBoxLoginSenha.Location = new System.Drawing.Point(93, 71);
            this.textBoxLoginSenha.Name = "textBoxLoginSenha";
            this.textBoxLoginSenha.Size = new System.Drawing.Size(173, 20);
            this.textBoxLoginSenha.TabIndex = 3;
            this.textBoxLoginSenha.UseSystemPasswordChar = true;
            // 
            // buttonLoginOK
            // 
            this.buttonLoginOK.Location = new System.Drawing.Point(93, 117);
            this.buttonLoginOK.Name = "buttonLoginOK";
            this.buttonLoginOK.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginOK.TabIndex = 4;
            this.buttonLoginOK.Text = "OK";
            this.buttonLoginOK.UseVisualStyleBackColor = true;
            this.buttonLoginOK.Click += new System.EventHandler(this.buttonLoginOK_Click);
            // 
            // buttonLoginCancelar
            // 
            this.buttonLoginCancelar.Location = new System.Drawing.Point(191, 117);
            this.buttonLoginCancelar.Name = "buttonLoginCancelar";
            this.buttonLoginCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginCancelar.TabIndex = 5;
            this.buttonLoginCancelar.Text = "Cancelar";
            this.buttonLoginCancelar.UseVisualStyleBackColor = true;
            this.buttonLoginCancelar.Click += new System.EventHandler(this.buttonLoginCancelar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 163);
            this.Controls.Add(this.buttonLoginCancelar);
            this.Controls.Add(this.buttonLoginOK);
            this.Controls.Add(this.textBoxLoginSenha);
            this.Controls.Add(this.textBoxLoginUsuario);
            this.Controls.Add(this.labelLoginSenha);
            this.Controls.Add(this.labelLoginUsuario);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login no sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginUsuario;
        private System.Windows.Forms.Label labelLoginSenha;
        private System.Windows.Forms.TextBox textBoxLoginUsuario;
        private System.Windows.Forms.TextBox textBoxLoginSenha;
        private System.Windows.Forms.Button buttonLoginOK;
        private System.Windows.Forms.Button buttonLoginCancelar;
    }
}