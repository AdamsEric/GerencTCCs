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
            this.components = new System.ComponentModel.Container();
            this.labelLoginUsuario = new System.Windows.Forms.Label();
            this.labelLoginSenha = new System.Windows.Forms.Label();
            this.textBoxLoginSenha = new System.Windows.Forms.TextBox();
            this.buttonLoginOK = new System.Windows.Forms.Button();
            this.buttonLoginCancelar = new System.Windows.Forms.Button();
            this.comboBoxLoginUsuario = new System.Windows.Forms.ComboBox();
            this.tblUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelLoginGrupo = new System.Windows.Forms.Label();
            this.dataSetUsuario = new Apresentacao.DataSetUsuario();
            this.tblUsuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsuarioTableAdapter = new Apresentacao.DataSetUsuarioTableAdapters.tblUsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarioBindingSource1)).BeginInit();
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
            // textBoxLoginSenha
            // 
            this.textBoxLoginSenha.Location = new System.Drawing.Point(93, 71);
            this.textBoxLoginSenha.Name = "textBoxLoginSenha";
            this.textBoxLoginSenha.Size = new System.Drawing.Size(173, 20);
            this.textBoxLoginSenha.TabIndex = 3;
            this.textBoxLoginSenha.UseSystemPasswordChar = true;
            this.textBoxLoginSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLoginSenha_KeyPress);
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
            // comboBoxLoginUsuario
            // 
            this.comboBoxLoginUsuario.DataSource = this.tblUsuarioBindingSource1;
            this.comboBoxLoginUsuario.DisplayMember = "UsuarioLogin";
            this.comboBoxLoginUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoginUsuario.FormattingEnabled = true;
            this.comboBoxLoginUsuario.Location = new System.Drawing.Point(93, 33);
            this.comboBoxLoginUsuario.Name = "comboBoxLoginUsuario";
            this.comboBoxLoginUsuario.Size = new System.Drawing.Size(173, 21);
            this.comboBoxLoginUsuario.TabIndex = 6;
            this.comboBoxLoginUsuario.ValueMember = "UsuarioLogin";
            this.comboBoxLoginUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxLoginUsuario_KeyPress);
            // 
            // tblUsuarioBindingSource
            // 
            this.tblUsuarioBindingSource.DataMember = "tblUsuario";
            // 
            // labelLoginGrupo
            // 
            this.labelLoginGrupo.AutoSize = true;
            this.labelLoginGrupo.Location = new System.Drawing.Point(13, 138);
            this.labelLoginGrupo.Name = "labelLoginGrupo";
            this.labelLoginGrupo.Size = new System.Drawing.Size(36, 13);
            this.labelLoginGrupo.TabIndex = 7;
            this.labelLoginGrupo.Text = "Grupo";
            this.labelLoginGrupo.Visible = false;
            // 
            // dataSetUsuario
            // 
            this.dataSetUsuario.DataSetName = "DataSetUsuario";
            this.dataSetUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsuarioBindingSource1
            // 
            this.tblUsuarioBindingSource1.DataMember = "tblUsuario";
            this.tblUsuarioBindingSource1.DataSource = this.dataSetUsuario;
            // 
            // tblUsuarioTableAdapter
            // 
            this.tblUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 163);
            this.Controls.Add(this.labelLoginGrupo);
            this.Controls.Add(this.comboBoxLoginUsuario);
            this.Controls.Add(this.buttonLoginCancelar);
            this.Controls.Add(this.buttonLoginOK);
            this.Controls.Add(this.textBoxLoginSenha);
            this.Controls.Add(this.labelLoginSenha);
            this.Controls.Add(this.labelLoginUsuario);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login no sistema";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarioBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginUsuario;
        private System.Windows.Forms.Label labelLoginSenha;
        private System.Windows.Forms.TextBox textBoxLoginSenha;
        private System.Windows.Forms.Button buttonLoginOK;
        private System.Windows.Forms.Button buttonLoginCancelar;
        private System.Windows.Forms.ComboBox comboBoxLoginUsuario;
        private System.Windows.Forms.BindingSource tblUsuarioBindingSource;
        private System.Windows.Forms.Label labelLoginGrupo;
        private DataSetUsuario dataSetUsuario;
        private System.Windows.Forms.BindingSource tblUsuarioBindingSource1;
        private DataSetUsuarioTableAdapters.tblUsuarioTableAdapter tblUsuarioTableAdapter;
    }
}