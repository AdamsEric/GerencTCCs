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
            this.labelAcaoSalaNome = new System.Windows.Forms.Label();
            this.labelAcaoSalaUnidade = new System.Windows.Forms.Label();
            this.textBoxAcaoSalaNome = new System.Windows.Forms.TextBox();
            this.buttonAcaoSalaConfirmar = new System.Windows.Forms.Button();
            this.buttonAcaoSalaCancelar = new System.Windows.Forms.Button();
            this.comboBoxAcaoSalaUnidade = new System.Windows.Forms.ComboBox();
            this.tblUnidadeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetUnidade = new Apresentacao.DataSetUnidade();
            this.labelAcaoSalaCO = new System.Windows.Forms.Label();
            this.labelAcaoSalaID = new System.Windows.Forms.Label();
            this.textBoxAcaoSalaID = new System.Windows.Forms.TextBox();
            this.textBoxAcaoSalaDescricao = new System.Windows.Forms.TextBox();
            this.labelAcaoSalaDescricao = new System.Windows.Forms.Label();
            this.comboBoxAcaoSalaTipo = new System.Windows.Forms.ComboBox();
            this.tblSalaTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalaTipo = new Apresentacao.DataSetSalaTipo();
            this.labelAcaoSalaTipo = new System.Windows.Forms.Label();
            this.tblSalaTipoTableAdapter = new Apresentacao.DataSetSalaTipoTableAdapters.tblSalaTipoTableAdapter();
            this.tblUnidadeTableAdapter1 = new Apresentacao.DataSetUnidadeTableAdapters.tblUnidadeTableAdapter();
            this.textBoxAcaoSalaTipo = new System.Windows.Forms.TextBox();
            this.textBoxAcaoSalaUnidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidadeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalaTipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalaTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAcaoSalaNome
            // 
            this.labelAcaoSalaNome.AutoSize = true;
            this.labelAcaoSalaNome.Location = new System.Drawing.Point(24, 54);
            this.labelAcaoSalaNome.Name = "labelAcaoSalaNome";
            this.labelAcaoSalaNome.Size = new System.Drawing.Size(42, 13);
            this.labelAcaoSalaNome.TabIndex = 0;
            this.labelAcaoSalaNome.Text = "Nome*:";
            // 
            // labelAcaoSalaUnidade
            // 
            this.labelAcaoSalaUnidade.AutoSize = true;
            this.labelAcaoSalaUnidade.Location = new System.Drawing.Point(12, 128);
            this.labelAcaoSalaUnidade.Name = "labelAcaoSalaUnidade";
            this.labelAcaoSalaUnidade.Size = new System.Drawing.Size(54, 13);
            this.labelAcaoSalaUnidade.TabIndex = 1;
            this.labelAcaoSalaUnidade.Text = "Unidade*:";
            // 
            // textBoxAcaoSalaNome
            // 
            this.textBoxAcaoSalaNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoSalaNome.Location = new System.Drawing.Point(68, 50);
            this.textBoxAcaoSalaNome.Name = "textBoxAcaoSalaNome";
            this.textBoxAcaoSalaNome.Size = new System.Drawing.Size(90, 20);
            this.textBoxAcaoSalaNome.TabIndex = 0;
            this.textBoxAcaoSalaNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAcaoSalaNome_KeyPress);
            // 
            // buttonAcaoSalaConfirmar
            // 
            this.buttonAcaoSalaConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonAcaoSalaConfirmar.Name = "buttonAcaoSalaConfirmar";
            this.buttonAcaoSalaConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoSalaConfirmar.TabIndex = 4;
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
            this.buttonAcaoSalaCancelar.TabIndex = 5;
            this.buttonAcaoSalaCancelar.Text = "Cancelar";
            this.buttonAcaoSalaCancelar.UseVisualStyleBackColor = true;
            this.buttonAcaoSalaCancelar.Click += new System.EventHandler(this.buttonAcaoSalaCancelar_Click);
            // 
            // comboBoxAcaoSalaUnidade
            // 
            this.comboBoxAcaoSalaUnidade.DataSource = this.tblUnidadeBindingSource1;
            this.comboBoxAcaoSalaUnidade.DisplayMember = "UnidadeNome";
            this.comboBoxAcaoSalaUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAcaoSalaUnidade.FormattingEnabled = true;
            this.comboBoxAcaoSalaUnidade.Location = new System.Drawing.Point(68, 124);
            this.comboBoxAcaoSalaUnidade.Name = "comboBoxAcaoSalaUnidade";
            this.comboBoxAcaoSalaUnidade.Size = new System.Drawing.Size(362, 21);
            this.comboBoxAcaoSalaUnidade.TabIndex = 3;
            this.comboBoxAcaoSalaUnidade.ValueMember = "UnidadeNome";
            this.comboBoxAcaoSalaUnidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxAcaoSalaUnidade_KeyPress);
            // 
            // tblUnidadeBindingSource1
            // 
            this.tblUnidadeBindingSource1.DataMember = "tblUnidade";
            this.tblUnidadeBindingSource1.DataSource = this.dataSetUnidade;
            // 
            // dataSetUnidade
            // 
            this.dataSetUnidade.DataSetName = "DataSetUnidade";
            this.dataSetUnidade.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelAcaoSalaCO
            // 
            this.labelAcaoSalaCO.AutoSize = true;
            this.labelAcaoSalaCO.Location = new System.Drawing.Point(16, 175);
            this.labelAcaoSalaCO.Name = "labelAcaoSalaCO";
            this.labelAcaoSalaCO.Size = new System.Drawing.Size(210, 13);
            this.labelAcaoSalaCO.TabIndex = 15;
            this.labelAcaoSalaCO.Text = "( * ) - Campos de preenchimento obrigatório";
            // 
            // labelAcaoSalaID
            // 
            this.labelAcaoSalaID.AutoSize = true;
            this.labelAcaoSalaID.Location = new System.Drawing.Point(23, 17);
            this.labelAcaoSalaID.Name = "labelAcaoSalaID";
            this.labelAcaoSalaID.Size = new System.Drawing.Size(43, 13);
            this.labelAcaoSalaID.TabIndex = 24;
            this.labelAcaoSalaID.Text = "Código:";
            // 
            // textBoxAcaoSalaID
            // 
            this.textBoxAcaoSalaID.Enabled = false;
            this.textBoxAcaoSalaID.Location = new System.Drawing.Point(68, 13);
            this.textBoxAcaoSalaID.Name = "textBoxAcaoSalaID";
            this.textBoxAcaoSalaID.Size = new System.Drawing.Size(90, 20);
            this.textBoxAcaoSalaID.TabIndex = 0;
            // 
            // textBoxAcaoSalaDescricao
            // 
            this.textBoxAcaoSalaDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoSalaDescricao.Location = new System.Drawing.Point(68, 87);
            this.textBoxAcaoSalaDescricao.Name = "textBoxAcaoSalaDescricao";
            this.textBoxAcaoSalaDescricao.Size = new System.Drawing.Size(362, 20);
            this.textBoxAcaoSalaDescricao.TabIndex = 2;
            this.textBoxAcaoSalaDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAcaoSalaDescricao_KeyPress);
            // 
            // labelAcaoSalaDescricao
            // 
            this.labelAcaoSalaDescricao.AutoSize = true;
            this.labelAcaoSalaDescricao.Location = new System.Drawing.Point(8, 91);
            this.labelAcaoSalaDescricao.Name = "labelAcaoSalaDescricao";
            this.labelAcaoSalaDescricao.Size = new System.Drawing.Size(58, 13);
            this.labelAcaoSalaDescricao.TabIndex = 25;
            this.labelAcaoSalaDescricao.Text = "Descricao:";
            // 
            // comboBoxAcaoSalaTipo
            // 
            this.comboBoxAcaoSalaTipo.DataSource = this.tblSalaTipoBindingSource;
            this.comboBoxAcaoSalaTipo.DisplayMember = "SalaTipoTipo";
            this.comboBoxAcaoSalaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAcaoSalaTipo.Location = new System.Drawing.Point(224, 50);
            this.comboBoxAcaoSalaTipo.Name = "comboBoxAcaoSalaTipo";
            this.comboBoxAcaoSalaTipo.Size = new System.Drawing.Size(110, 21);
            this.comboBoxAcaoSalaTipo.TabIndex = 1;
            this.comboBoxAcaoSalaTipo.ValueMember = "SalaTipoTipo";
            this.comboBoxAcaoSalaTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxAcaoSalaTipo_KeyPress);
            // 
            // tblSalaTipoBindingSource
            // 
            this.tblSalaTipoBindingSource.DataMember = "tblSalaTipo";
            this.tblSalaTipoBindingSource.DataSource = this.dataSetSalaTipo;
            // 
            // dataSetSalaTipo
            // 
            this.dataSetSalaTipo.DataSetName = "DataSetSalaTipo";
            this.dataSetSalaTipo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelAcaoSalaTipo
            // 
            this.labelAcaoSalaTipo.AutoSize = true;
            this.labelAcaoSalaTipo.Location = new System.Drawing.Point(183, 54);
            this.labelAcaoSalaTipo.Name = "labelAcaoSalaTipo";
            this.labelAcaoSalaTipo.Size = new System.Drawing.Size(35, 13);
            this.labelAcaoSalaTipo.TabIndex = 27;
            this.labelAcaoSalaTipo.Text = "Tipo*:";
            // 
            // tblSalaTipoTableAdapter
            // 
            this.tblSalaTipoTableAdapter.ClearBeforeFill = true;
            // 
            // tblUnidadeTableAdapter1
            // 
            this.tblUnidadeTableAdapter1.ClearBeforeFill = true;
            // 
            // textBoxAcaoSalaTipo
            // 
            this.textBoxAcaoSalaTipo.Location = new System.Drawing.Point(224, 50);
            this.textBoxAcaoSalaTipo.Name = "textBoxAcaoSalaTipo";
            this.textBoxAcaoSalaTipo.ReadOnly = true;
            this.textBoxAcaoSalaTipo.Size = new System.Drawing.Size(110, 20);
            this.textBoxAcaoSalaTipo.TabIndex = 28;
            this.textBoxAcaoSalaTipo.Visible = false;
            // 
            // textBoxAcaoSalaUnidade
            // 
            this.textBoxAcaoSalaUnidade.Location = new System.Drawing.Point(68, 124);
            this.textBoxAcaoSalaUnidade.Name = "textBoxAcaoSalaUnidade";
            this.textBoxAcaoSalaUnidade.ReadOnly = true;
            this.textBoxAcaoSalaUnidade.Size = new System.Drawing.Size(362, 20);
            this.textBoxAcaoSalaUnidade.TabIndex = 29;
            this.textBoxAcaoSalaUnidade.Visible = false;
            // 
            // FrmMenuAcaoSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 213);
            this.Controls.Add(this.textBoxAcaoSalaUnidade);
            this.Controls.Add(this.textBoxAcaoSalaTipo);
            this.Controls.Add(this.comboBoxAcaoSalaTipo);
            this.Controls.Add(this.labelAcaoSalaTipo);
            this.Controls.Add(this.textBoxAcaoSalaDescricao);
            this.Controls.Add(this.labelAcaoSalaDescricao);
            this.Controls.Add(this.labelAcaoSalaID);
            this.Controls.Add(this.textBoxAcaoSalaID);
            this.Controls.Add(this.labelAcaoSalaCO);
            this.Controls.Add(this.comboBoxAcaoSalaUnidade);
            this.Controls.Add(this.buttonAcaoSalaCancelar);
            this.Controls.Add(this.buttonAcaoSalaConfirmar);
            this.Controls.Add(this.textBoxAcaoSalaNome);
            this.Controls.Add(this.labelAcaoSalaUnidade);
            this.Controls.Add(this.labelAcaoSalaNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAcaoSala";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acao Sala";
            this.Load += new System.EventHandler(this.FrmMenuAcaoSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidadeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalaTipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalaTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAcaoSalaNome;
        private System.Windows.Forms.Label labelAcaoSalaUnidade;
        private System.Windows.Forms.TextBox textBoxAcaoSalaNome;
        private System.Windows.Forms.Button buttonAcaoSalaConfirmar;
        private System.Windows.Forms.Button buttonAcaoSalaCancelar;
        private System.Windows.Forms.ComboBox comboBoxAcaoSalaUnidade;
        private System.Windows.Forms.Label labelAcaoSalaCO;
        private System.Windows.Forms.Label labelAcaoSalaID;
        private System.Windows.Forms.TextBox textBoxAcaoSalaID;
        private System.Windows.Forms.TextBox textBoxAcaoSalaDescricao;
        private System.Windows.Forms.Label labelAcaoSalaDescricao;
        private System.Windows.Forms.ComboBox comboBoxAcaoSalaTipo;
        private System.Windows.Forms.Label labelAcaoSalaTipo;
        private DataSetSalaTipo dataSetSalaTipo;
        private System.Windows.Forms.BindingSource tblSalaTipoBindingSource;
        private DataSetSalaTipoTableAdapters.tblSalaTipoTableAdapter tblSalaTipoTableAdapter;
        private DataSetUnidade dataSetUnidade;
        private System.Windows.Forms.BindingSource tblUnidadeBindingSource1;
        private DataSetUnidadeTableAdapters.tblUnidadeTableAdapter tblUnidadeTableAdapter1;
        private System.Windows.Forms.TextBox textBoxAcaoSalaTipo;
        private System.Windows.Forms.TextBox textBoxAcaoSalaUnidade;
    }
}