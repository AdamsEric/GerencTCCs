namespace Apresentacao
{
    partial class FrmMenuAcaoAluno
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
            this.labelAcaoAlunoNome = new System.Windows.Forms.Label();
            this.labelAcaoAlunoMatricula = new System.Windows.Forms.Label();
            this.labelAcaoAlunoTelefone = new System.Windows.Forms.Label();
            this.labelAcaoAlunoCurso = new System.Windows.Forms.Label();
            this.textBoxAcaoAlunoNome = new System.Windows.Forms.TextBox();
            this.textBoxAcaoAlunoMatricula = new System.Windows.Forms.TextBox();
            this.buttonAcaoAlunoConfirmar = new System.Windows.Forms.Button();
            this.buttonAcaoAlunoCancelar = new System.Windows.Forms.Button();
            this.comboBoxAcaoAlunoUnidadeNome = new System.Windows.Forms.ComboBox();
            this.tblUnidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerencTCCsDataSet16 = new Apresentacao.GerencTCCsDataSet16();
            this.labelAcaoAlunoCO = new System.Windows.Forms.Label();
            this.maskedTextBoxAcaoAlunoTelefone = new System.Windows.Forms.MaskedTextBox();
            this.labelAcaoAlunoID = new System.Windows.Forms.Label();
            this.textBoxAcaoAlunoID = new System.Windows.Forms.TextBox();
            this.labelAcaoAlunoUnidade = new System.Windows.Forms.Label();
            this.comboBoxAcaoAlunoCursoNome = new System.Windows.Forms.ComboBox();
            this.tblCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerencTCCsDataSet17 = new Apresentacao.GerencTCCsDataSet17();
            this.tblUnidadeTableAdapter = new Apresentacao.GerencTCCsDataSet16TableAdapters.tblUnidadeTableAdapter();
            this.tblCursoTableAdapter = new Apresentacao.GerencTCCsDataSet17TableAdapters.tblCursoTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.cursoUnidadeIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.cursoUnidadeIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet17)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAcaoAlunoNome
            // 
            this.labelAcaoAlunoNome.AutoSize = true;
            this.labelAcaoAlunoNome.Location = new System.Drawing.Point(16, 46);
            this.labelAcaoAlunoNome.Name = "labelAcaoAlunoNome";
            this.labelAcaoAlunoNome.Size = new System.Drawing.Size(45, 13);
            this.labelAcaoAlunoNome.TabIndex = 0;
            this.labelAcaoAlunoNome.Text = "Nome*: ";
            // 
            // labelAcaoAlunoMatricula
            // 
            this.labelAcaoAlunoMatricula.AutoSize = true;
            this.labelAcaoAlunoMatricula.Location = new System.Drawing.Point(16, 75);
            this.labelAcaoAlunoMatricula.Name = "labelAcaoAlunoMatricula";
            this.labelAcaoAlunoMatricula.Size = new System.Drawing.Size(59, 13);
            this.labelAcaoAlunoMatricula.TabIndex = 1;
            this.labelAcaoAlunoMatricula.Text = "Matrícula*:";
            // 
            // labelAcaoAlunoTelefone
            // 
            this.labelAcaoAlunoTelefone.AutoSize = true;
            this.labelAcaoAlunoTelefone.Location = new System.Drawing.Point(164, 75);
            this.labelAcaoAlunoTelefone.Name = "labelAcaoAlunoTelefone";
            this.labelAcaoAlunoTelefone.Size = new System.Drawing.Size(55, 13);
            this.labelAcaoAlunoTelefone.TabIndex = 2;
            this.labelAcaoAlunoTelefone.Text = "Telefone: ";
            // 
            // labelAcaoAlunoCurso
            // 
            this.labelAcaoAlunoCurso.AutoSize = true;
            this.labelAcaoAlunoCurso.Location = new System.Drawing.Point(16, 133);
            this.labelAcaoAlunoCurso.Name = "labelAcaoAlunoCurso";
            this.labelAcaoAlunoCurso.Size = new System.Drawing.Size(41, 13);
            this.labelAcaoAlunoCurso.TabIndex = 3;
            this.labelAcaoAlunoCurso.Text = "Curso*:";
            // 
            // textBoxAcaoAlunoNome
            // 
            this.textBoxAcaoAlunoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoAlunoNome.Location = new System.Drawing.Point(67, 42);
            this.textBoxAcaoAlunoNome.Name = "textBoxAcaoAlunoNome";
            this.textBoxAcaoAlunoNome.Size = new System.Drawing.Size(363, 20);
            this.textBoxAcaoAlunoNome.TabIndex = 0;
            // 
            // textBoxAcaoAlunoMatricula
            // 
            this.textBoxAcaoAlunoMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoAlunoMatricula.Location = new System.Drawing.Point(79, 71);
            this.textBoxAcaoAlunoMatricula.Name = "textBoxAcaoAlunoMatricula";
            this.textBoxAcaoAlunoMatricula.Size = new System.Drawing.Size(79, 20);
            this.textBoxAcaoAlunoMatricula.TabIndex = 1;
            // 
            // buttonAcaoAlunoConfirmar
            // 
            this.buttonAcaoAlunoConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonAcaoAlunoConfirmar.Name = "buttonAcaoAlunoConfirmar";
            this.buttonAcaoAlunoConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoAlunoConfirmar.TabIndex = 5;
            this.buttonAcaoAlunoConfirmar.Text = "Confirmar";
            this.buttonAcaoAlunoConfirmar.UseVisualStyleBackColor = true;
            this.buttonAcaoAlunoConfirmar.Click += new System.EventHandler(this.buttonAcaoAlunoConfirmar_Click);
            // 
            // buttonAcaoAlunoCancelar
            // 
            this.buttonAcaoAlunoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAcaoAlunoCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonAcaoAlunoCancelar.Name = "buttonAcaoAlunoCancelar";
            this.buttonAcaoAlunoCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoAlunoCancelar.TabIndex = 6;
            this.buttonAcaoAlunoCancelar.Text = "Cancelar";
            this.buttonAcaoAlunoCancelar.UseVisualStyleBackColor = true;
            this.buttonAcaoAlunoCancelar.Click += new System.EventHandler(this.buttonAcaoAlunoCancelar_Click);
            // 
            // comboBoxAcaoAlunoUnidadeNome
            // 
            this.comboBoxAcaoAlunoUnidadeNome.DataSource = this.tblUnidadeBindingSource;
            this.comboBoxAcaoAlunoUnidadeNome.DisplayMember = "UnidadeNome";
            this.comboBoxAcaoAlunoUnidadeNome.FormattingEnabled = true;
            this.comboBoxAcaoAlunoUnidadeNome.Location = new System.Drawing.Point(79, 100);
            this.comboBoxAcaoAlunoUnidadeNome.Name = "comboBoxAcaoAlunoUnidadeNome";
            this.comboBoxAcaoAlunoUnidadeNome.Size = new System.Drawing.Size(349, 21);
            this.comboBoxAcaoAlunoUnidadeNome.TabIndex = 3;
            this.comboBoxAcaoAlunoUnidadeNome.ValueMember = "UnidadeNome";
            this.comboBoxAcaoAlunoUnidadeNome.Click += new System.EventHandler(this.comboBoxAcaoAlunoUnidadeNome_Click);
            // 
            // tblUnidadeBindingSource
            // 
            this.tblUnidadeBindingSource.DataMember = "tblUnidade";
            this.tblUnidadeBindingSource.DataSource = this.gerencTCCsDataSet16;
            // 
            // gerencTCCsDataSet16
            // 
            this.gerencTCCsDataSet16.DataSetName = "GerencTCCsDataSet16";
            this.gerencTCCsDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelAcaoAlunoCO
            // 
            this.labelAcaoAlunoCO.AutoSize = true;
            this.labelAcaoAlunoCO.Location = new System.Drawing.Point(16, 175);
            this.labelAcaoAlunoCO.Name = "labelAcaoAlunoCO";
            this.labelAcaoAlunoCO.Size = new System.Drawing.Size(210, 13);
            this.labelAcaoAlunoCO.TabIndex = 15;
            this.labelAcaoAlunoCO.Text = "( * ) - Campos de preenchimento obrigatório";
            // 
            // maskedTextBoxAcaoAlunoTelefone
            // 
            this.maskedTextBoxAcaoAlunoTelefone.Location = new System.Drawing.Point(224, 71);
            this.maskedTextBoxAcaoAlunoTelefone.Mask = "(99)999999999";
            this.maskedTextBoxAcaoAlunoTelefone.Name = "maskedTextBoxAcaoAlunoTelefone";
            this.maskedTextBoxAcaoAlunoTelefone.Size = new System.Drawing.Size(80, 20);
            this.maskedTextBoxAcaoAlunoTelefone.TabIndex = 2;
            this.maskedTextBoxAcaoAlunoTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelAcaoAlunoID
            // 
            this.labelAcaoAlunoID.AutoSize = true;
            this.labelAcaoAlunoID.Location = new System.Drawing.Point(16, 17);
            this.labelAcaoAlunoID.Name = "labelAcaoAlunoID";
            this.labelAcaoAlunoID.Size = new System.Drawing.Size(46, 13);
            this.labelAcaoAlunoID.TabIndex = 18;
            this.labelAcaoAlunoID.Text = "Código: ";
            // 
            // textBoxAcaoAlunoID
            // 
            this.textBoxAcaoAlunoID.Enabled = false;
            this.textBoxAcaoAlunoID.Location = new System.Drawing.Point(68, 13);
            this.textBoxAcaoAlunoID.Name = "textBoxAcaoAlunoID";
            this.textBoxAcaoAlunoID.Size = new System.Drawing.Size(90, 20);
            this.textBoxAcaoAlunoID.TabIndex = 19;
            // 
            // labelAcaoAlunoUnidade
            // 
            this.labelAcaoAlunoUnidade.AutoSize = true;
            this.labelAcaoAlunoUnidade.Location = new System.Drawing.Point(16, 104);
            this.labelAcaoAlunoUnidade.Name = "labelAcaoAlunoUnidade";
            this.labelAcaoAlunoUnidade.Size = new System.Drawing.Size(57, 13);
            this.labelAcaoAlunoUnidade.TabIndex = 20;
            this.labelAcaoAlunoUnidade.Text = "Unidade*: ";
            // 
            // comboBoxAcaoAlunoCursoNome
            // 
            this.comboBoxAcaoAlunoCursoNome.DataSource = this.tblCursoBindingSource;
            this.comboBoxAcaoAlunoCursoNome.DisplayMember = "CursoNome";
            this.comboBoxAcaoAlunoCursoNome.FormattingEnabled = true;
            this.comboBoxAcaoAlunoCursoNome.Location = new System.Drawing.Point(63, 127);
            this.comboBoxAcaoAlunoCursoNome.Name = "comboBoxAcaoAlunoCursoNome";
            this.comboBoxAcaoAlunoCursoNome.Size = new System.Drawing.Size(365, 21);
            this.comboBoxAcaoAlunoCursoNome.TabIndex = 4;
            this.comboBoxAcaoAlunoCursoNome.ValueMember = "CursoNome";
            this.comboBoxAcaoAlunoCursoNome.Click += new System.EventHandler(this.comboBoxAcaoAlunoCursoNome_Click);
            // 
            // tblCursoBindingSource
            // 
            this.tblCursoBindingSource.DataMember = "tblCurso";
            this.tblCursoBindingSource.DataSource = this.gerencTCCsDataSet17;
            // 
            // gerencTCCsDataSet17
            // 
            this.gerencTCCsDataSet17.DataSetName = "GerencTCCsDataSet17";
            this.gerencTCCsDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUnidadeTableAdapter
            // 
            this.tblUnidadeTableAdapter.ClearBeforeFill = true;
            // 
            // tblCursoTableAdapter
            // 
            this.tblCursoTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursoUnidadeIDToolStripLabel,
            this.cursoUnidadeIDToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(111, 25);
            this.fillByToolStrip.TabIndex = 21;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // cursoUnidadeIDToolStripLabel
            // 
            this.cursoUnidadeIDToolStripLabel.Name = "cursoUnidadeIDToolStripLabel";
            this.cursoUnidadeIDToolStripLabel.Size = new System.Drawing.Size(96, 15);
            this.cursoUnidadeIDToolStripLabel.Text = "CursoUnidadeID:";
            // 
            // cursoUnidadeIDToolStripTextBox
            // 
            this.cursoUnidadeIDToolStripTextBox.Name = "cursoUnidadeIDToolStripTextBox";
            this.cursoUnidadeIDToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 19);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // FrmMenuAcaoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.comboBoxAcaoAlunoCursoNome);
            this.Controls.Add(this.labelAcaoAlunoUnidade);
            this.Controls.Add(this.textBoxAcaoAlunoID);
            this.Controls.Add(this.labelAcaoAlunoID);
            this.Controls.Add(this.maskedTextBoxAcaoAlunoTelefone);
            this.Controls.Add(this.labelAcaoAlunoCO);
            this.Controls.Add(this.comboBoxAcaoAlunoUnidadeNome);
            this.Controls.Add(this.buttonAcaoAlunoCancelar);
            this.Controls.Add(this.buttonAcaoAlunoConfirmar);
            this.Controls.Add(this.textBoxAcaoAlunoMatricula);
            this.Controls.Add(this.textBoxAcaoAlunoNome);
            this.Controls.Add(this.labelAcaoAlunoCurso);
            this.Controls.Add(this.labelAcaoAlunoTelefone);
            this.Controls.Add(this.labelAcaoAlunoMatricula);
            this.Controls.Add(this.labelAcaoAlunoNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAcaoAluno";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acao Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet17)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAcaoAlunoNome;
        private System.Windows.Forms.Label labelAcaoAlunoMatricula;
        private System.Windows.Forms.Label labelAcaoAlunoTelefone;
        private System.Windows.Forms.Label labelAcaoAlunoCurso;
        private System.Windows.Forms.TextBox textBoxAcaoAlunoNome;
        private System.Windows.Forms.TextBox textBoxAcaoAlunoMatricula;
        private System.Windows.Forms.Button buttonAcaoAlunoConfirmar;
        private System.Windows.Forms.Button buttonAcaoAlunoCancelar;
        private System.Windows.Forms.ComboBox comboBoxAcaoAlunoUnidadeNome;
        private System.Windows.Forms.Label labelAcaoAlunoCO;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAcaoAlunoTelefone;
        private System.Windows.Forms.Label labelAcaoAlunoID;
        private System.Windows.Forms.TextBox textBoxAcaoAlunoID;
        private System.Windows.Forms.Label labelAcaoAlunoUnidade;
        private System.Windows.Forms.ComboBox comboBoxAcaoAlunoCursoNome;
        private GerencTCCsDataSet16 gerencTCCsDataSet16;
        private System.Windows.Forms.BindingSource tblUnidadeBindingSource;
        private GerencTCCsDataSet16TableAdapters.tblUnidadeTableAdapter tblUnidadeTableAdapter;
        private GerencTCCsDataSet17 gerencTCCsDataSet17;
        private System.Windows.Forms.BindingSource tblCursoBindingSource;
        private GerencTCCsDataSet17TableAdapters.tblCursoTableAdapter tblCursoTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel cursoUnidadeIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox cursoUnidadeIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}