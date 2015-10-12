namespace Apresentacao
{
    partial class FrmMenuAcaoCurso
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
            this.labelAcaoCursoNome = new System.Windows.Forms.Label();
            this.labelAcaoCursoUnidade = new System.Windows.Forms.Label();
            this.textBoxAcaoCursoNome = new System.Windows.Forms.TextBox();
            this.buttonAcaoCursoConfirmar = new System.Windows.Forms.Button();
            this.buttonAcaoCursoCancelar = new System.Windows.Forms.Button();
            this.comboBoxAcaoCursoUnidadeNome = new System.Windows.Forms.ComboBox();
            this.tblUnidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerencTCCsDataSet = new Apresentacao.GerencTCCsDataSet();
            this.labelAcaoCursoCO = new System.Windows.Forms.Label();
            this.labelAcaoCursoID = new System.Windows.Forms.Label();
            this.textBoxAcaoCursoID = new System.Windows.Forms.TextBox();
            this.tblUnidadeTableAdapter = new Apresentacao.GerencTCCsDataSetTableAdapters.tblUnidadeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAcaoCursoNome
            // 
            this.labelAcaoCursoNome.AutoSize = true;
            this.labelAcaoCursoNome.Location = new System.Drawing.Point(16, 54);
            this.labelAcaoCursoNome.Name = "labelAcaoCursoNome";
            this.labelAcaoCursoNome.Size = new System.Drawing.Size(45, 13);
            this.labelAcaoCursoNome.TabIndex = 0;
            this.labelAcaoCursoNome.Text = "Nome*: ";
            // 
            // labelAcaoCursoUnidade
            // 
            this.labelAcaoCursoUnidade.AutoSize = true;
            this.labelAcaoCursoUnidade.Location = new System.Drawing.Point(16, 91);
            this.labelAcaoCursoUnidade.Name = "labelAcaoCursoUnidade";
            this.labelAcaoCursoUnidade.Size = new System.Drawing.Size(57, 13);
            this.labelAcaoCursoUnidade.TabIndex = 1;
            this.labelAcaoCursoUnidade.Text = "Unidade*: ";
            // 
            // textBoxAcaoCursoNome
            // 
            this.textBoxAcaoCursoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoCursoNome.Location = new System.Drawing.Point(68, 50);
            this.textBoxAcaoCursoNome.Name = "textBoxAcaoCursoNome";
            this.textBoxAcaoCursoNome.Size = new System.Drawing.Size(373, 20);
            this.textBoxAcaoCursoNome.TabIndex = 1;
            // 
            // buttonAcaoCursoConfirmar
            // 
            this.buttonAcaoCursoConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonAcaoCursoConfirmar.Name = "buttonAcaoCursoConfirmar";
            this.buttonAcaoCursoConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoCursoConfirmar.TabIndex = 3;
            this.buttonAcaoCursoConfirmar.Text = "Confirmar";
            this.buttonAcaoCursoConfirmar.UseVisualStyleBackColor = true;
            this.buttonAcaoCursoConfirmar.Click += new System.EventHandler(this.buttonAcaoCursoConfirmar_Click);
            // 
            // buttonAcaoCursoCancelar
            // 
            this.buttonAcaoCursoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAcaoCursoCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonAcaoCursoCancelar.Name = "buttonAcaoCursoCancelar";
            this.buttonAcaoCursoCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoCursoCancelar.TabIndex = 4;
            this.buttonAcaoCursoCancelar.Text = "Cancelar";
            this.buttonAcaoCursoCancelar.UseVisualStyleBackColor = true;
            this.buttonAcaoCursoCancelar.Click += new System.EventHandler(this.buttonAcaoCursoCancelar_Click);
            // 
            // comboBoxAcaoCursoUnidadeNome
            // 
            this.comboBoxAcaoCursoUnidadeNome.DataSource = this.tblUnidadeBindingSource;
            this.comboBoxAcaoCursoUnidadeNome.DisplayMember = "UnidadeNome";
            this.comboBoxAcaoCursoUnidadeNome.FormattingEnabled = true;
            this.comboBoxAcaoCursoUnidadeNome.Location = new System.Drawing.Point(68, 87);
            this.comboBoxAcaoCursoUnidadeNome.Name = "comboBoxAcaoCursoUnidadeNome";
            this.comboBoxAcaoCursoUnidadeNome.Size = new System.Drawing.Size(353, 21);
            this.comboBoxAcaoCursoUnidadeNome.TabIndex = 2;
            this.comboBoxAcaoCursoUnidadeNome.ValueMember = "UnidadeNome";
            // 
            // tblUnidadeBindingSource
            // 
            this.tblUnidadeBindingSource.DataMember = "tblUnidade";
            this.tblUnidadeBindingSource.DataSource = this.gerencTCCsDataSet;
            // 
            // gerencTCCsDataSet
            // 
            this.gerencTCCsDataSet.DataSetName = "GerencTCCsDataSet";
            this.gerencTCCsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelAcaoCursoCO
            // 
            this.labelAcaoCursoCO.AutoSize = true;
            this.labelAcaoCursoCO.Location = new System.Drawing.Point(16, 175);
            this.labelAcaoCursoCO.Name = "labelAcaoCursoCO";
            this.labelAcaoCursoCO.Size = new System.Drawing.Size(210, 13);
            this.labelAcaoCursoCO.TabIndex = 15;
            this.labelAcaoCursoCO.Text = "( * ) - Campos de preenchimento obrigatório";
            // 
            // labelAcaoCursoID
            // 
            this.labelAcaoCursoID.AutoSize = true;
            this.labelAcaoCursoID.Location = new System.Drawing.Point(16, 17);
            this.labelAcaoCursoID.Name = "labelAcaoCursoID";
            this.labelAcaoCursoID.Size = new System.Drawing.Size(46, 13);
            this.labelAcaoCursoID.TabIndex = 24;
            this.labelAcaoCursoID.Text = "Código: ";
            // 
            // textBoxAcaoCursoID
            // 
            this.textBoxAcaoCursoID.Location = new System.Drawing.Point(68, 13);
            this.textBoxAcaoCursoID.Name = "textBoxAcaoCursoID";
            this.textBoxAcaoCursoID.ReadOnly = true;
            this.textBoxAcaoCursoID.Size = new System.Drawing.Size(90, 20);
            this.textBoxAcaoCursoID.TabIndex = 0;
            // 
            // tblUnidadeTableAdapter
            // 
            this.tblUnidadeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMenuAcaoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 213);
            this.Controls.Add(this.labelAcaoCursoID);
            this.Controls.Add(this.textBoxAcaoCursoID);
            this.Controls.Add(this.labelAcaoCursoCO);
            this.Controls.Add(this.comboBoxAcaoCursoUnidadeNome);
            this.Controls.Add(this.buttonAcaoCursoCancelar);
            this.Controls.Add(this.buttonAcaoCursoConfirmar);
            this.Controls.Add(this.textBoxAcaoCursoNome);
            this.Controls.Add(this.labelAcaoCursoUnidade);
            this.Controls.Add(this.labelAcaoCursoNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAcaoCurso";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acao Curso";
            this.Load += new System.EventHandler(this.FrmMenuAcaoCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAcaoCursoNome;
        private System.Windows.Forms.Label labelAcaoCursoUnidade;
        private System.Windows.Forms.TextBox textBoxAcaoCursoNome;
        private System.Windows.Forms.Button buttonAcaoCursoConfirmar;
        private System.Windows.Forms.Button buttonAcaoCursoCancelar;
        private System.Windows.Forms.ComboBox comboBoxAcaoCursoUnidadeNome;
        private System.Windows.Forms.Label labelAcaoCursoCO;
        private System.Windows.Forms.Label labelAcaoCursoID;
        private System.Windows.Forms.TextBox textBoxAcaoCursoID;
        private GerencTCCsDataSet gerencTCCsDataSet;
        private System.Windows.Forms.BindingSource tblUnidadeBindingSource;
        private GerencTCCsDataSetTableAdapters.tblUnidadeTableAdapter tblUnidadeTableAdapter;
    }
}