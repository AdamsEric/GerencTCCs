namespace Apresentacao
{
    partial class FrmMenuInserirUsuario
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
            this.labelInserirUsuarioLogin = new System.Windows.Forms.Label();
            this.labelInserirUsuarioGrupo = new System.Windows.Forms.Label();
            this.labelInserirUsuarioSenha = new System.Windows.Forms.Label();
            this.textBoxInserirUsuarioLogin = new System.Windows.Forms.TextBox();
            this.buttonInserirUsuarioConfirmar = new System.Windows.Forms.Button();
            this.buttonInserirUsuarioCancelar = new System.Windows.Forms.Button();
            this.textBoxInserirUsuarioSenha = new System.Windows.Forms.TextBox();
            this.textBoxInserirUsuarioNome = new System.Windows.Forms.TextBox();
            this.labelInserirUsuarioNome = new System.Windows.Forms.Label();
            this.labelInserirUsuarioMatricula = new System.Windows.Forms.Label();
            this.textBoxInserirUsuarioMatricula = new System.Windows.Forms.TextBox();
            this.groupBoxInserirUsuarioInformacoes = new System.Windows.Forms.GroupBox();
            this.comboBoxInserirUsuarioGrupo = new System.Windows.Forms.ComboBox();
            this.labelMenuInserirCO = new System.Windows.Forms.Label();
            this.groupBoxInserirUsuarioInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInserirUsuarioLogin
            // 
            this.labelInserirUsuarioLogin.AutoSize = true;
            this.labelInserirUsuarioLogin.Location = new System.Drawing.Point(16, 22);
            this.labelInserirUsuarioLogin.Name = "labelInserirUsuarioLogin";
            this.labelInserirUsuarioLogin.Size = new System.Drawing.Size(43, 13);
            this.labelInserirUsuarioLogin.TabIndex = 0;
            this.labelInserirUsuarioLogin.Text = "Login*: ";
            // 
            // labelInserirUsuarioGrupo
            // 
            this.labelInserirUsuarioGrupo.AutoSize = true;
            this.labelInserirUsuarioGrupo.Location = new System.Drawing.Point(16, 55);
            this.labelInserirUsuarioGrupo.Name = "labelInserirUsuarioGrupo";
            this.labelInserirUsuarioGrupo.Size = new System.Drawing.Size(46, 13);
            this.labelInserirUsuarioGrupo.TabIndex = 1;
            this.labelInserirUsuarioGrupo.Text = "Grupo*: ";
            // 
            // labelInserirUsuarioSenha
            // 
            this.labelInserirUsuarioSenha.AutoSize = true;
            this.labelInserirUsuarioSenha.Location = new System.Drawing.Point(223, 22);
            this.labelInserirUsuarioSenha.Name = "labelInserirUsuarioSenha";
            this.labelInserirUsuarioSenha.Size = new System.Drawing.Size(45, 13);
            this.labelInserirUsuarioSenha.TabIndex = 3;
            this.labelInserirUsuarioSenha.Text = "Senha*:";
            // 
            // textBoxInserirUsuarioLogin
            // 
            this.textBoxInserirUsuarioLogin.Location = new System.Drawing.Point(57, 18);
            this.textBoxInserirUsuarioLogin.Name = "textBoxInserirUsuarioLogin";
            this.textBoxInserirUsuarioLogin.Size = new System.Drawing.Size(157, 20);
            this.textBoxInserirUsuarioLogin.TabIndex = 0;
            // 
            // buttonInserirUsuarioConfirmar
            // 
            this.buttonInserirUsuarioConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonInserirUsuarioConfirmar.Name = "buttonInserirUsuarioConfirmar";
            this.buttonInserirUsuarioConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirUsuarioConfirmar.TabIndex = 4;
            this.buttonInserirUsuarioConfirmar.Text = "Confirmar";
            this.buttonInserirUsuarioConfirmar.UseVisualStyleBackColor = true;
            this.buttonInserirUsuarioConfirmar.Click += new System.EventHandler(this.buttonInserirUsuarioConfirmar_Click);
            // 
            // buttonInserirUsuarioCancelar
            // 
            this.buttonInserirUsuarioCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonInserirUsuarioCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonInserirUsuarioCancelar.Name = "buttonInserirUsuarioCancelar";
            this.buttonInserirUsuarioCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirUsuarioCancelar.TabIndex = 5;
            this.buttonInserirUsuarioCancelar.Text = "Cancelar";
            this.buttonInserirUsuarioCancelar.UseVisualStyleBackColor = true;
            this.buttonInserirUsuarioCancelar.Click += new System.EventHandler(this.buttonInserirUsuarioCancelar_Click);
            // 
            // textBoxInserirUsuarioSenha
            // 
            this.textBoxInserirUsuarioSenha.Location = new System.Drawing.Point(270, 18);
            this.textBoxInserirUsuarioSenha.Name = "textBoxInserirUsuarioSenha";
            this.textBoxInserirUsuarioSenha.Size = new System.Drawing.Size(160, 20);
            this.textBoxInserirUsuarioSenha.TabIndex = 1;
            this.textBoxInserirUsuarioSenha.UseSystemPasswordChar = true;
            // 
            // textBoxInserirUsuarioNome
            // 
            this.textBoxInserirUsuarioNome.Location = new System.Drawing.Point(105, 24);
            this.textBoxInserirUsuarioNome.Name = "textBoxInserirUsuarioNome";
            this.textBoxInserirUsuarioNome.Size = new System.Drawing.Size(300, 20);
            this.textBoxInserirUsuarioNome.TabIndex = 0;
            // 
            // labelInserirUsuarioNome
            // 
            this.labelInserirUsuarioNome.AutoSize = true;
            this.labelInserirUsuarioNome.Location = new System.Drawing.Point(6, 28);
            this.labelInserirUsuarioNome.Name = "labelInserirUsuarioNome";
            this.labelInserirUsuarioNome.Size = new System.Drawing.Size(97, 13);
            this.labelInserirUsuarioNome.TabIndex = 17;
            this.labelInserirUsuarioNome.Text = "Nome do usuário*: ";
            // 
            // labelInserirUsuarioMatricula
            // 
            this.labelInserirUsuarioMatricula.AutoSize = true;
            this.labelInserirUsuarioMatricula.Location = new System.Drawing.Point(6, 56);
            this.labelInserirUsuarioMatricula.Name = "labelInserirUsuarioMatricula";
            this.labelInserirUsuarioMatricula.Size = new System.Drawing.Size(58, 13);
            this.labelInserirUsuarioMatricula.TabIndex = 19;
            this.labelInserirUsuarioMatricula.Text = "Matrícula: ";
            // 
            // textBoxInserirUsuarioMatricula
            // 
            this.textBoxInserirUsuarioMatricula.Location = new System.Drawing.Point(70, 52);
            this.textBoxInserirUsuarioMatricula.Name = "textBoxInserirUsuarioMatricula";
            this.textBoxInserirUsuarioMatricula.Size = new System.Drawing.Size(128, 20);
            this.textBoxInserirUsuarioMatricula.TabIndex = 1;
            // 
            // groupBoxInserirUsuarioInformacoes
            // 
            this.groupBoxInserirUsuarioInformacoes.Controls.Add(this.labelInserirUsuarioNome);
            this.groupBoxInserirUsuarioInformacoes.Controls.Add(this.textBoxInserirUsuarioMatricula);
            this.groupBoxInserirUsuarioInformacoes.Controls.Add(this.textBoxInserirUsuarioNome);
            this.groupBoxInserirUsuarioInformacoes.Controls.Add(this.labelInserirUsuarioMatricula);
            this.groupBoxInserirUsuarioInformacoes.Location = new System.Drawing.Point(16, 81);
            this.groupBoxInserirUsuarioInformacoes.Name = "groupBoxInserirUsuarioInformacoes";
            this.groupBoxInserirUsuarioInformacoes.Size = new System.Drawing.Size(411, 83);
            this.groupBoxInserirUsuarioInformacoes.TabIndex = 3;
            this.groupBoxInserirUsuarioInformacoes.TabStop = false;
            this.groupBoxInserirUsuarioInformacoes.Text = "Informações do Usuário";
            // 
            // comboBoxInserirUsuarioGrupo
            // 
            this.comboBoxInserirUsuarioGrupo.FormattingEnabled = true;
            this.comboBoxInserirUsuarioGrupo.Location = new System.Drawing.Point(57, 52);
            this.comboBoxInserirUsuarioGrupo.Name = "comboBoxInserirUsuarioGrupo";
            this.comboBoxInserirUsuarioGrupo.Size = new System.Drawing.Size(157, 21);
            this.comboBoxInserirUsuarioGrupo.TabIndex = 2;
            // 
            // labelMenuInserirCO
            // 
            this.labelMenuInserirCO.AutoSize = true;
            this.labelMenuInserirCO.Location = new System.Drawing.Point(16, 180);
            this.labelMenuInserirCO.Name = "labelMenuInserirCO";
            this.labelMenuInserirCO.Size = new System.Drawing.Size(210, 13);
            this.labelMenuInserirCO.TabIndex = 23;
            this.labelMenuInserirCO.Text = "( * ) - Campos de preenchimento obrigatório";
            // 
            // FrmMenuInserirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.labelMenuInserirCO);
            this.Controls.Add(this.comboBoxInserirUsuarioGrupo);
            this.Controls.Add(this.groupBoxInserirUsuarioInformacoes);
            this.Controls.Add(this.textBoxInserirUsuarioSenha);
            this.Controls.Add(this.buttonInserirUsuarioCancelar);
            this.Controls.Add(this.buttonInserirUsuarioConfirmar);
            this.Controls.Add(this.textBoxInserirUsuarioLogin);
            this.Controls.Add(this.labelInserirUsuarioSenha);
            this.Controls.Add(this.labelInserirUsuarioGrupo);
            this.Controls.Add(this.labelInserirUsuarioLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuInserirUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Usuário";
            this.Load += new System.EventHandler(this.FrmMenuInserirUsuario_Load);
            this.groupBoxInserirUsuarioInformacoes.ResumeLayout(false);
            this.groupBoxInserirUsuarioInformacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInserirUsuarioLogin;
        private System.Windows.Forms.Label labelInserirUsuarioGrupo;
        private System.Windows.Forms.Label labelInserirUsuarioSenha;
        private System.Windows.Forms.TextBox textBoxInserirUsuarioLogin;
        private System.Windows.Forms.Button buttonInserirUsuarioConfirmar;
        private System.Windows.Forms.Button buttonInserirUsuarioCancelar;
        private System.Windows.Forms.TextBox textBoxInserirUsuarioSenha;
        private System.Windows.Forms.TextBox textBoxInserirUsuarioNome;
        private System.Windows.Forms.Label labelInserirUsuarioNome;
        private System.Windows.Forms.Label labelInserirUsuarioMatricula;
        private System.Windows.Forms.TextBox textBoxInserirUsuarioMatricula;
        private System.Windows.Forms.GroupBox groupBoxInserirUsuarioInformacoes;
        private System.Windows.Forms.ComboBox comboBoxInserirUsuarioGrupo;
        private System.Windows.Forms.Label labelMenuInserirCO;
    }
}