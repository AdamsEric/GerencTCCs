namespace Apresentacao
{
    partial class FrmMenuAcaoUsuario
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
            this.components = new System.ComponentModel.Container();
            this.labelAcaoUsuarioNome = new System.Windows.Forms.Label();
            this.labelAcaoUsuarioLogin = new System.Windows.Forms.Label();
            this.labelAcaoUsuarioMatricula = new System.Windows.Forms.Label();
            this.textBoxAcaoUsuarioSenha = new System.Windows.Forms.TextBox();
            this.buttonAcaoUsuarioConfirmar = new System.Windows.Forms.Button();
            this.buttonAcaoUsuarioCancelar = new System.Windows.Forms.Button();
            this.textBoxAcaoUsuarioLogin = new System.Windows.Forms.TextBox();
            this.textBoxAcaoUsuarioNome = new System.Windows.Forms.TextBox();
            this.labelAcaoUsuarioSenha = new System.Windows.Forms.Label();
            this.labelAcaoUsuarioCO = new System.Windows.Forms.Label();
            this.textBoxAcaoUsuarioID = new System.Windows.Forms.TextBox();
            this.labelAcaoUsuarioID = new System.Windows.Forms.Label();
            this.comboBoxAcaoUsuarioGrupo = new System.Windows.Forms.ComboBox();
            this.tblGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGrupo = new Apresentacao.DataSetGrupo();
            this.labelAcaoUsuarioGrupo = new System.Windows.Forms.Label();
            this.labelAcaoUsuarioSituacao = new System.Windows.Forms.Label();
            this.comboBoxAcaoUsuarioSituacao = new System.Windows.Forms.ComboBox();
            this.tblGrupoTableAdapter = new Apresentacao.DataSetGrupoTableAdapters.tblGrupoTableAdapter();
            this.textBoxAcaoUsuarioMatricula = new System.Windows.Forms.TextBox();
            this.textBoxAcaoUsuarioGrupo = new System.Windows.Forms.TextBox();
            this.textBoxAcaoUsuarioSituacao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAcaoUsuarioNome
            // 
            this.labelAcaoUsuarioNome.AutoSize = true;
            this.labelAcaoUsuarioNome.Location = new System.Drawing.Point(21, 127);
            this.labelAcaoUsuarioNome.Name = "labelAcaoUsuarioNome";
            this.labelAcaoUsuarioNome.Size = new System.Drawing.Size(38, 13);
            this.labelAcaoUsuarioNome.TabIndex = 0;
            this.labelAcaoUsuarioNome.Text = "Nome:";
            // 
            // labelAcaoUsuarioLogin
            // 
            this.labelAcaoUsuarioLogin.AutoSize = true;
            this.labelAcaoUsuarioLogin.Location = new System.Drawing.Point(19, 49);
            this.labelAcaoUsuarioLogin.Name = "labelAcaoUsuarioLogin";
            this.labelAcaoUsuarioLogin.Size = new System.Drawing.Size(40, 13);
            this.labelAcaoUsuarioLogin.TabIndex = 1;
            this.labelAcaoUsuarioLogin.Text = "Login*:";
            // 
            // labelAcaoUsuarioMatricula
            // 
            this.labelAcaoUsuarioMatricula.AutoSize = true;
            this.labelAcaoUsuarioMatricula.Location = new System.Drawing.Point(254, 127);
            this.labelAcaoUsuarioMatricula.Name = "labelAcaoUsuarioMatricula";
            this.labelAcaoUsuarioMatricula.Size = new System.Drawing.Size(55, 13);
            this.labelAcaoUsuarioMatricula.TabIndex = 3;
            this.labelAcaoUsuarioMatricula.Text = "Matrícula:";
            // 
            // textBoxAcaoUsuarioSenha
            // 
            this.textBoxAcaoUsuarioSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoUsuarioSenha.Location = new System.Drawing.Point(64, 74);
            this.textBoxAcaoUsuarioSenha.Name = "textBoxAcaoUsuarioSenha";
            this.textBoxAcaoUsuarioSenha.Size = new System.Drawing.Size(175, 20);
            this.textBoxAcaoUsuarioSenha.TabIndex = 3;
            this.textBoxAcaoUsuarioSenha.UseSystemPasswordChar = true;
            this.textBoxAcaoUsuarioSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAcaoUsuarioNome_KeyPress);
            // 
            // buttonAcaoUsuarioConfirmar
            // 
            this.buttonAcaoUsuarioConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonAcaoUsuarioConfirmar.Name = "buttonAcaoUsuarioConfirmar";
            this.buttonAcaoUsuarioConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoUsuarioConfirmar.TabIndex = 7;
            this.buttonAcaoUsuarioConfirmar.Text = "Confirmar";
            this.buttonAcaoUsuarioConfirmar.UseVisualStyleBackColor = true;
            this.buttonAcaoUsuarioConfirmar.Click += new System.EventHandler(this.buttonAcaoUsuarioConfirmar_Click);
            // 
            // buttonAcaoUsuarioCancelar
            // 
            this.buttonAcaoUsuarioCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAcaoUsuarioCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonAcaoUsuarioCancelar.Name = "buttonAcaoUsuarioCancelar";
            this.buttonAcaoUsuarioCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoUsuarioCancelar.TabIndex = 8;
            this.buttonAcaoUsuarioCancelar.Text = "Cancelar";
            this.buttonAcaoUsuarioCancelar.UseVisualStyleBackColor = true;
            this.buttonAcaoUsuarioCancelar.Click += new System.EventHandler(this.buttonAcaoUsuarioCancelar_Click);
            // 
            // textBoxAcaoUsuarioLogin
            // 
            this.textBoxAcaoUsuarioLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoUsuarioLogin.Location = new System.Drawing.Point(64, 45);
            this.textBoxAcaoUsuarioLogin.Name = "textBoxAcaoUsuarioLogin";
            this.textBoxAcaoUsuarioLogin.Size = new System.Drawing.Size(175, 20);
            this.textBoxAcaoUsuarioLogin.TabIndex = 1;
            this.textBoxAcaoUsuarioLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAcaoUsuarioCidade_KeyPress);
            // 
            // textBoxAcaoUsuarioNome
            // 
            this.textBoxAcaoUsuarioNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoUsuarioNome.Location = new System.Drawing.Point(64, 123);
            this.textBoxAcaoUsuarioNome.Name = "textBoxAcaoUsuarioNome";
            this.textBoxAcaoUsuarioNome.Size = new System.Drawing.Size(175, 20);
            this.textBoxAcaoUsuarioNome.TabIndex = 5;
            this.textBoxAcaoUsuarioNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAcaoUsuarioPais_KeyPress);
            // 
            // labelAcaoUsuarioSenha
            // 
            this.labelAcaoUsuarioSenha.AutoSize = true;
            this.labelAcaoUsuarioSenha.Location = new System.Drawing.Point(14, 78);
            this.labelAcaoUsuarioSenha.Name = "labelAcaoUsuarioSenha";
            this.labelAcaoUsuarioSenha.Size = new System.Drawing.Size(45, 13);
            this.labelAcaoUsuarioSenha.TabIndex = 17;
            this.labelAcaoUsuarioSenha.Text = "Senha*:";
            // 
            // labelAcaoUsuarioCO
            // 
            this.labelAcaoUsuarioCO.AutoSize = true;
            this.labelAcaoUsuarioCO.Location = new System.Drawing.Point(16, 175);
            this.labelAcaoUsuarioCO.Name = "labelAcaoUsuarioCO";
            this.labelAcaoUsuarioCO.Size = new System.Drawing.Size(210, 13);
            this.labelAcaoUsuarioCO.TabIndex = 20;
            this.labelAcaoUsuarioCO.Text = "( * ) - Campos de preenchimento obrigatório";
            // 
            // textBoxAcaoUsuarioID
            // 
            this.textBoxAcaoUsuarioID.Enabled = false;
            this.textBoxAcaoUsuarioID.Location = new System.Drawing.Point(64, 13);
            this.textBoxAcaoUsuarioID.Name = "textBoxAcaoUsuarioID";
            this.textBoxAcaoUsuarioID.ReadOnly = true;
            this.textBoxAcaoUsuarioID.Size = new System.Drawing.Size(90, 20);
            this.textBoxAcaoUsuarioID.TabIndex = 0;
            // 
            // labelAcaoUsuarioID
            // 
            this.labelAcaoUsuarioID.AutoSize = true;
            this.labelAcaoUsuarioID.Location = new System.Drawing.Point(16, 17);
            this.labelAcaoUsuarioID.Name = "labelAcaoUsuarioID";
            this.labelAcaoUsuarioID.Size = new System.Drawing.Size(43, 13);
            this.labelAcaoUsuarioID.TabIndex = 22;
            this.labelAcaoUsuarioID.Text = "Código:";
            // 
            // comboBoxAcaoUsuarioGrupo
            // 
            this.comboBoxAcaoUsuarioGrupo.DataSource = this.tblGrupoBindingSource;
            this.comboBoxAcaoUsuarioGrupo.DisplayMember = "GrupoNome";
            this.comboBoxAcaoUsuarioGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAcaoUsuarioGrupo.Location = new System.Drawing.Point(312, 45);
            this.comboBoxAcaoUsuarioGrupo.Name = "comboBoxAcaoUsuarioGrupo";
            this.comboBoxAcaoUsuarioGrupo.Size = new System.Drawing.Size(118, 21);
            this.comboBoxAcaoUsuarioGrupo.TabIndex = 2;
            this.comboBoxAcaoUsuarioGrupo.ValueMember = "GrupoNome";
            // 
            // tblGrupoBindingSource
            // 
            this.tblGrupoBindingSource.DataMember = "tblGrupo";
            this.tblGrupoBindingSource.DataSource = this.dataSetGrupo;
            // 
            // dataSetGrupo
            // 
            this.dataSetGrupo.DataSetName = "DataSetGrupo";
            this.dataSetGrupo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelAcaoUsuarioGrupo
            // 
            this.labelAcaoUsuarioGrupo.AutoSize = true;
            this.labelAcaoUsuarioGrupo.Location = new System.Drawing.Point(266, 49);
            this.labelAcaoUsuarioGrupo.Name = "labelAcaoUsuarioGrupo";
            this.labelAcaoUsuarioGrupo.Size = new System.Drawing.Size(43, 13);
            this.labelAcaoUsuarioGrupo.TabIndex = 25;
            this.labelAcaoUsuarioGrupo.Text = "Grupo*:";
            // 
            // labelAcaoUsuarioSituacao
            // 
            this.labelAcaoUsuarioSituacao.AutoSize = true;
            this.labelAcaoUsuarioSituacao.Location = new System.Drawing.Point(277, 78);
            this.labelAcaoUsuarioSituacao.Name = "labelAcaoUsuarioSituacao";
            this.labelAcaoUsuarioSituacao.Size = new System.Drawing.Size(73, 13);
            this.labelAcaoUsuarioSituacao.TabIndex = 26;
            this.labelAcaoUsuarioSituacao.Text = "Usuário Ativo:";
            // 
            // comboBoxAcaoUsuarioSituacao
            // 
            this.comboBoxAcaoUsuarioSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAcaoUsuarioSituacao.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.comboBoxAcaoUsuarioSituacao.Location = new System.Drawing.Point(355, 74);
            this.comboBoxAcaoUsuarioSituacao.Name = "comboBoxAcaoUsuarioSituacao";
            this.comboBoxAcaoUsuarioSituacao.Size = new System.Drawing.Size(75, 21);
            this.comboBoxAcaoUsuarioSituacao.TabIndex = 4;
            // 
            // tblGrupoTableAdapter
            // 
            this.tblGrupoTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxAcaoUsuarioMatricula
            // 
            this.textBoxAcaoUsuarioMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoUsuarioMatricula.Location = new System.Drawing.Point(312, 123);
            this.textBoxAcaoUsuarioMatricula.Name = "textBoxAcaoUsuarioMatricula";
            this.textBoxAcaoUsuarioMatricula.Size = new System.Drawing.Size(118, 20);
            this.textBoxAcaoUsuarioMatricula.TabIndex = 6;
            // 
            // textBoxAcaoUsuarioGrupo
            // 
            this.textBoxAcaoUsuarioGrupo.Location = new System.Drawing.Point(312, 45);
            this.textBoxAcaoUsuarioGrupo.Name = "textBoxAcaoUsuarioGrupo";
            this.textBoxAcaoUsuarioGrupo.Size = new System.Drawing.Size(118, 20);
            this.textBoxAcaoUsuarioGrupo.TabIndex = 2;
            this.textBoxAcaoUsuarioGrupo.Visible = false;
            // 
            // textBoxAcaoUsuarioSituacao
            // 
            this.textBoxAcaoUsuarioSituacao.Location = new System.Drawing.Point(355, 74);
            this.textBoxAcaoUsuarioSituacao.Name = "textBoxAcaoUsuarioSituacao";
            this.textBoxAcaoUsuarioSituacao.Size = new System.Drawing.Size(75, 20);
            this.textBoxAcaoUsuarioSituacao.TabIndex = 4;
            this.textBoxAcaoUsuarioSituacao.Visible = false;
            // 
            // FrmMenuAcaoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.textBoxAcaoUsuarioSituacao);
            this.Controls.Add(this.textBoxAcaoUsuarioGrupo);
            this.Controls.Add(this.textBoxAcaoUsuarioMatricula);
            this.Controls.Add(this.comboBoxAcaoUsuarioSituacao);
            this.Controls.Add(this.labelAcaoUsuarioSituacao);
            this.Controls.Add(this.labelAcaoUsuarioGrupo);
            this.Controls.Add(this.comboBoxAcaoUsuarioGrupo);
            this.Controls.Add(this.labelAcaoUsuarioID);
            this.Controls.Add(this.textBoxAcaoUsuarioID);
            this.Controls.Add(this.labelAcaoUsuarioCO);
            this.Controls.Add(this.textBoxAcaoUsuarioNome);
            this.Controls.Add(this.labelAcaoUsuarioSenha);
            this.Controls.Add(this.textBoxAcaoUsuarioLogin);
            this.Controls.Add(this.buttonAcaoUsuarioCancelar);
            this.Controls.Add(this.buttonAcaoUsuarioConfirmar);
            this.Controls.Add(this.textBoxAcaoUsuarioSenha);
            this.Controls.Add(this.labelAcaoUsuarioMatricula);
            this.Controls.Add(this.labelAcaoUsuarioLogin);
            this.Controls.Add(this.labelAcaoUsuarioNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAcaoUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acao Usuario";
            this.Load += new System.EventHandler(this.FrmMenuAcaoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAcaoUsuarioNome;
        private System.Windows.Forms.Label labelAcaoUsuarioLogin;
        private System.Windows.Forms.Label labelAcaoUsuarioMatricula;
        private System.Windows.Forms.TextBox textBoxAcaoUsuarioSenha;
        private System.Windows.Forms.Button buttonAcaoUsuarioConfirmar;
        private System.Windows.Forms.Button buttonAcaoUsuarioCancelar;
        private System.Windows.Forms.TextBox textBoxAcaoUsuarioLogin;
        private System.Windows.Forms.TextBox textBoxAcaoUsuarioNome;
        private System.Windows.Forms.Label labelAcaoUsuarioSenha;
        private System.Windows.Forms.Label labelAcaoUsuarioCO;
        private System.Windows.Forms.TextBox textBoxAcaoUsuarioID;
        private System.Windows.Forms.Label labelAcaoUsuarioID;
        private System.Windows.Forms.ComboBox comboBoxAcaoUsuarioGrupo;
        private System.Windows.Forms.Label labelAcaoUsuarioGrupo;
        private System.Windows.Forms.Label labelAcaoUsuarioSituacao;
        private System.Windows.Forms.ComboBox comboBoxAcaoUsuarioSituacao;
        private DataSetGrupo dataSetGrupo;
        private System.Windows.Forms.BindingSource tblGrupoBindingSource;
        private DataSetGrupoTableAdapters.tblGrupoTableAdapter tblGrupoTableAdapter;
        private System.Windows.Forms.TextBox textBoxAcaoUsuarioMatricula;
        private System.Windows.Forms.TextBox textBoxAcaoUsuarioGrupo;
        private System.Windows.Forms.TextBox textBoxAcaoUsuarioSituacao;
    }
}