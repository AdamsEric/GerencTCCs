namespace Apresentacao
{
    partial class FrmMenuAcaoSala
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
            this.labelAcaoSalaID = new System.Windows.Forms.Label();
            this.textBoxAcaoSalaID = new System.Windows.Forms.TextBox();
            this.buttonAcaoSalaConfirmar = new System.Windows.Forms.Button();
            this.buttonAcaoSalaCancelar = new System.Windows.Forms.Button();
            this.labelAcaoSalaTipo = new System.Windows.Forms.Label();
            this.labelAcaoSalaUnidade = new System.Windows.Forms.Label();
            this.comboBoxAcaoSalaTipoNome = new System.Windows.Forms.ComboBox();
            this.tblSalaTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerencTCCsDataSet18 = new Apresentacao.GerencTCCsDataSet18();
            this.comboBoxAcaoSalaUnidadeNome = new System.Windows.Forms.ComboBox();
            this.tblUnidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerencTCCsDataSet19 = new Apresentacao.GerencTCCsDataSet19();
            this.labelAcaoSalaDescricao = new System.Windows.Forms.Label();
            this.textBoxAcaoSalaDescricao = new System.Windows.Forms.TextBox();
            this.labelAcaoSalaCO = new System.Windows.Forms.Label();
            this.labelAcaoSalaNome = new System.Windows.Forms.Label();
            this.textBoxAcaoSalaNome = new System.Windows.Forms.TextBox();
            this.tblSalaTipoTableAdapter = new Apresentacao.GerencTCCsDataSet18TableAdapters.tblSalaTipoTableAdapter();
            this.tblUnidadeTableAdapter = new Apresentacao.GerencTCCsDataSet19TableAdapters.tblUnidadeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalaTipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet19)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAcaoSalaID
            // 
            this.labelAcaoSalaID.AutoSize = true;
            this.labelAcaoSalaID.Location = new System.Drawing.Point(16, 17);
            this.labelAcaoSalaID.Name = "labelAcaoSalaID";
            this.labelAcaoSalaID.Size = new System.Drawing.Size(50, 13);
            this.labelAcaoSalaID.TabIndex = 0;
            this.labelAcaoSalaID.Text = "Código*: ";
            // 
            // textBoxAcaoSalaID
            // 
            this.textBoxAcaoSalaID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoSalaID.Enabled = false;
            this.textBoxAcaoSalaID.Location = new System.Drawing.Point(67, 13);
            this.textBoxAcaoSalaID.Name = "textBoxAcaoSalaID";
            this.textBoxAcaoSalaID.Size = new System.Drawing.Size(71, 20);
            this.textBoxAcaoSalaID.TabIndex = 0;
            // 
            // buttonAcaoSalaConfirmar
            // 
            this.buttonAcaoSalaConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonAcaoSalaConfirmar.Name = "buttonAcaoSalaConfirmar";
            this.buttonAcaoSalaConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoSalaConfirmar.TabIndex = 5;
            this.buttonAcaoSalaConfirmar.Text = "Confirmar";
            this.buttonAcaoSalaConfirmar.UseVisualStyleBackColor = true;
            this.buttonAcaoSalaConfirmar.Click += new System.EventHandler(this.buttonAcaoSalaConfirmar_Click);
            // 
            // buttonAcaoSalaCancelar
            // 
            this.buttonAcaoSalaCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAcaoSalaCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonAcaoSalaCancelar.Name = "buttonAcaoSalaCancelar";
            this.buttonAcaoSalaCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoSalaCancelar.TabIndex = 6;
            this.buttonAcaoSalaCancelar.Text = "Cancelar";
            this.buttonAcaoSalaCancelar.UseVisualStyleBackColor = true;
            this.buttonAcaoSalaCancelar.Click += new System.EventHandler(this.buttonAcaoSalaCancelar_Click);
            // 
            // labelAcaoSalaTipo
            // 
            this.labelAcaoSalaTipo.AutoSize = true;
            this.labelAcaoSalaTipo.Location = new System.Drawing.Point(286, 54);
            this.labelAcaoSalaTipo.Name = "labelAcaoSalaTipo";
            this.labelAcaoSalaTipo.Size = new System.Drawing.Size(34, 13);
            this.labelAcaoSalaTipo.TabIndex = 17;
            this.labelAcaoSalaTipo.Text = "Tipo: ";
            // 
            // labelAcaoSalaUnidade
            // 
            this.labelAcaoSalaUnidade.AutoSize = true;
            this.labelAcaoSalaUnidade.Location = new System.Drawing.Point(16, 128);
            this.labelAcaoSalaUnidade.Name = "labelAcaoSalaUnidade";
            this.labelAcaoSalaUnidade.Size = new System.Drawing.Size(54, 13);
            this.labelAcaoSalaUnidade.TabIndex = 19;
            this.labelAcaoSalaUnidade.Text = "Unidade*:";
            // 
            // comboBoxAcaoSalaTipoNome
            // 
            this.comboBoxAcaoSalaTipoNome.DataSource = this.tblSalaTipoBindingSource;
            this.comboBoxAcaoSalaTipoNome.DisplayMember = "SalaTipoTipo";
            this.comboBoxAcaoSalaTipoNome.FormattingEnabled = true;
            this.comboBoxAcaoSalaTipoNome.Location = new System.Drawing.Point(326, 50);
            this.comboBoxAcaoSalaTipoNome.Name = "comboBoxAcaoSalaTipoNome";
            this.comboBoxAcaoSalaTipoNome.Size = new System.Drawing.Size(104, 21);
            this.comboBoxAcaoSalaTipoNome.TabIndex = 2;
            this.comboBoxAcaoSalaTipoNome.ValueMember = "SalaTipoTipo";
            this.comboBoxAcaoSalaTipoNome.Click += new System.EventHandler(this.comboBoxAcaoSalaTipo_Click);
            // 
            // tblSalaTipoBindingSource
            // 
            this.tblSalaTipoBindingSource.DataMember = "tblSalaTipo";
            this.tblSalaTipoBindingSource.DataSource = this.gerencTCCsDataSet18;
            // 
            // gerencTCCsDataSet18
            // 
            this.gerencTCCsDataSet18.DataSetName = "GerencTCCsDataSet18";
            this.gerencTCCsDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxAcaoSalaUnidadeNome
            // 
            this.comboBoxAcaoSalaUnidadeNome.DataSource = this.tblUnidadeBindingSource;
            this.comboBoxAcaoSalaUnidadeNome.DisplayMember = "UnidadeNome";
            this.comboBoxAcaoSalaUnidadeNome.FormattingEnabled = true;
            this.comboBoxAcaoSalaUnidadeNome.Location = new System.Drawing.Point(72, 124);
            this.comboBoxAcaoSalaUnidadeNome.Name = "comboBoxAcaoSalaUnidadeNome";
            this.comboBoxAcaoSalaUnidadeNome.Size = new System.Drawing.Size(358, 21);
            this.comboBoxAcaoSalaUnidadeNome.TabIndex = 4;
            this.comboBoxAcaoSalaUnidadeNome.ValueMember = "UnidadeNome";
            this.comboBoxAcaoSalaUnidadeNome.Click += new System.EventHandler(this.comboBoxAcaoSalaUnidadeNome_Click);
            // 
            // tblUnidadeBindingSource
            // 
            this.tblUnidadeBindingSource.DataMember = "tblUnidade";
            this.tblUnidadeBindingSource.DataSource = this.gerencTCCsDataSet19;
            // 
            // gerencTCCsDataSet19
            // 
            this.gerencTCCsDataSet19.DataSetName = "GerencTCCsDataSet19";
            this.gerencTCCsDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelAcaoSalaDescricao
            // 
            this.labelAcaoSalaDescricao.AutoSize = true;
            this.labelAcaoSalaDescricao.Location = new System.Drawing.Point(16, 91);
            this.labelAcaoSalaDescricao.Name = "labelAcaoSalaDescricao";
            this.labelAcaoSalaDescricao.Size = new System.Drawing.Size(61, 13);
            this.labelAcaoSalaDescricao.TabIndex = 22;
            this.labelAcaoSalaDescricao.Text = "Descrição: ";
            // 
            // textBoxAcaoSalaDescricao
            // 
            this.textBoxAcaoSalaDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoSalaDescricao.Location = new System.Drawing.Point(72, 87);
            this.textBoxAcaoSalaDescricao.Name = "textBoxAcaoSalaDescricao";
            this.textBoxAcaoSalaDescricao.Size = new System.Drawing.Size(358, 20);
            this.textBoxAcaoSalaDescricao.TabIndex = 3;
            // 
            // labelAcaoSalaCO
            // 
            this.labelAcaoSalaCO.AutoSize = true;
            this.labelAcaoSalaCO.Location = new System.Drawing.Point(16, 175);
            this.labelAcaoSalaCO.Name = "labelAcaoSalaCO";
            this.labelAcaoSalaCO.Size = new System.Drawing.Size(210, 13);
            this.labelAcaoSalaCO.TabIndex = 25;
            this.labelAcaoSalaCO.Text = "( * ) - Campos de preenchimento obrigatório";
            // 
            // labelAcaoSalaNome
            // 
            this.labelAcaoSalaNome.AutoSize = true;
            this.labelAcaoSalaNome.Location = new System.Drawing.Point(16, 54);
            this.labelAcaoSalaNome.Name = "labelAcaoSalaNome";
            this.labelAcaoSalaNome.Size = new System.Drawing.Size(41, 13);
            this.labelAcaoSalaNome.TabIndex = 26;
            this.labelAcaoSalaNome.Text = "Nome: ";
            // 
            // textBoxAcaoSalaNome
            // 
            this.textBoxAcaoSalaNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoSalaNome.Location = new System.Drawing.Point(67, 50);
            this.textBoxAcaoSalaNome.Name = "textBoxAcaoSalaNome";
            this.textBoxAcaoSalaNome.Size = new System.Drawing.Size(213, 20);
            this.textBoxAcaoSalaNome.TabIndex = 1;
            // 
            // tblSalaTipoTableAdapter
            // 
            this.tblSalaTipoTableAdapter.ClearBeforeFill = true;
            // 
            // tblUnidadeTableAdapter
            // 
            this.tblUnidadeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMenuAcaoSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.textBoxAcaoSalaNome);
            this.Controls.Add(this.labelAcaoSalaNome);
            this.Controls.Add(this.labelAcaoSalaCO);
            this.Controls.Add(this.textBoxAcaoSalaDescricao);
            this.Controls.Add(this.labelAcaoSalaDescricao);
            this.Controls.Add(this.comboBoxAcaoSalaUnidadeNome);
            this.Controls.Add(this.comboBoxAcaoSalaTipoNome);
            this.Controls.Add(this.labelAcaoSalaUnidade);
            this.Controls.Add(this.labelAcaoSalaTipo);
            this.Controls.Add(this.buttonAcaoSalaCancelar);
            this.Controls.Add(this.buttonAcaoSalaConfirmar);
            this.Controls.Add(this.textBoxAcaoSalaID);
            this.Controls.Add(this.labelAcaoSalaID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAcaoSala";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acao Sala";
            ((System.ComponentModel.ISupportInitialize)(this.tblSalaTipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAcaoSalaID;
        private System.Windows.Forms.TextBox textBoxAcaoSalaID;
        private System.Windows.Forms.Button buttonAcaoSalaConfirmar;
        private System.Windows.Forms.Button buttonAcaoSalaCancelar;
        private System.Windows.Forms.Label labelAcaoSalaTipo;
        private System.Windows.Forms.Label labelAcaoSalaUnidade;
        private System.Windows.Forms.ComboBox comboBoxAcaoSalaTipoNome;
        private System.Windows.Forms.ComboBox comboBoxAcaoSalaUnidadeNome;
        private System.Windows.Forms.Label labelAcaoSalaDescricao;
        private System.Windows.Forms.TextBox textBoxAcaoSalaDescricao;
        private System.Windows.Forms.Label labelAcaoSalaCO;
        private System.Windows.Forms.Label labelAcaoSalaNome;
        private System.Windows.Forms.TextBox textBoxAcaoSalaNome;
        private GerencTCCsDataSet18 gerencTCCsDataSet18;
        private System.Windows.Forms.BindingSource tblSalaTipoBindingSource;
        private GerencTCCsDataSet18TableAdapters.tblSalaTipoTableAdapter tblSalaTipoTableAdapter;
        private GerencTCCsDataSet19 gerencTCCsDataSet19;
        private System.Windows.Forms.BindingSource tblUnidadeBindingSource;
        private GerencTCCsDataSet19TableAdapters.tblUnidadeTableAdapter tblUnidadeTableAdapter;
    }
}