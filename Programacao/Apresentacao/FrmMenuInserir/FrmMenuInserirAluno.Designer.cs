namespace Apresentacao
{
    partial class FrmMenuInserirAluno
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
            this.labelInserirAlunoNome = new System.Windows.Forms.Label();
            this.labelInserirAlunoMatricula = new System.Windows.Forms.Label();
            this.labelInserirAlunoTelefone = new System.Windows.Forms.Label();
            this.labelInserirAlunoCurso = new System.Windows.Forms.Label();
            this.labelInserirAlunoCPF = new System.Windows.Forms.Label();
            this.textBoxInserirAlunoNome = new System.Windows.Forms.TextBox();
            this.textBoxInserirAlunoMatricula = new System.Windows.Forms.TextBox();
            this.buttonInserirAlunoConfirmar = new System.Windows.Forms.Button();
            this.buttonInserirAlunoCancelar = new System.Windows.Forms.Button();
            this.comboBoxInserirAlunoCurso = new System.Windows.Forms.ComboBox();
            this.labelMenuInserirCO = new System.Windows.Forms.Label();
            this.maskedTextBoxInserirAlunoCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxInserirAlunoTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelInserirAlunoNome
            // 
            this.labelInserirAlunoNome.AutoSize = true;
            this.labelInserirAlunoNome.Location = new System.Drawing.Point(16, 22);
            this.labelInserirAlunoNome.Name = "labelInserirAlunoNome";
            this.labelInserirAlunoNome.Size = new System.Drawing.Size(45, 13);
            this.labelInserirAlunoNome.TabIndex = 0;
            this.labelInserirAlunoNome.Text = "Nome*: ";
            // 
            // labelInserirAlunoMatricula
            // 
            this.labelInserirAlunoMatricula.AutoSize = true;
            this.labelInserirAlunoMatricula.Location = new System.Drawing.Point(16, 62);
            this.labelInserirAlunoMatricula.Name = "labelInserirAlunoMatricula";
            this.labelInserirAlunoMatricula.Size = new System.Drawing.Size(59, 13);
            this.labelInserirAlunoMatricula.TabIndex = 1;
            this.labelInserirAlunoMatricula.Text = "Matrícula*:";
            // 
            // labelInserirAlunoTelefone
            // 
            this.labelInserirAlunoTelefone.AutoSize = true;
            this.labelInserirAlunoTelefone.Location = new System.Drawing.Point(291, 62);
            this.labelInserirAlunoTelefone.Name = "labelInserirAlunoTelefone";
            this.labelInserirAlunoTelefone.Size = new System.Drawing.Size(55, 13);
            this.labelInserirAlunoTelefone.TabIndex = 2;
            this.labelInserirAlunoTelefone.Text = "Telefone: ";
            // 
            // labelInserirAlunoCurso
            // 
            this.labelInserirAlunoCurso.AutoSize = true;
            this.labelInserirAlunoCurso.Location = new System.Drawing.Point(16, 102);
            this.labelInserirAlunoCurso.Name = "labelInserirAlunoCurso";
            this.labelInserirAlunoCurso.Size = new System.Drawing.Size(41, 13);
            this.labelInserirAlunoCurso.TabIndex = 3;
            this.labelInserirAlunoCurso.Text = "Curso*:";
            // 
            // labelInserirAlunoCPF
            // 
            this.labelInserirAlunoCPF.AutoSize = true;
            this.labelInserirAlunoCPF.Location = new System.Drawing.Point(158, 62);
            this.labelInserirAlunoCPF.Name = "labelInserirAlunoCPF";
            this.labelInserirAlunoCPF.Size = new System.Drawing.Size(37, 13);
            this.labelInserirAlunoCPF.TabIndex = 5;
            this.labelInserirAlunoCPF.Text = "CPF*: ";
            // 
            // textBoxInserirAlunoNome
            // 
            this.textBoxInserirAlunoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInserirAlunoNome.Location = new System.Drawing.Point(57, 18);
            this.textBoxInserirAlunoNome.Name = "textBoxInserirAlunoNome";
            this.textBoxInserirAlunoNome.Size = new System.Drawing.Size(373, 20);
            this.textBoxInserirAlunoNome.TabIndex = 6;
            // 
            // textBoxInserirAlunoMatricula
            // 
            this.textBoxInserirAlunoMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInserirAlunoMatricula.Location = new System.Drawing.Point(75, 58);
            this.textBoxInserirAlunoMatricula.Name = "textBoxInserirAlunoMatricula";
            this.textBoxInserirAlunoMatricula.Size = new System.Drawing.Size(79, 20);
            this.textBoxInserirAlunoMatricula.TabIndex = 7;
            // 
            // buttonInserirAlunoConfirmar
            // 
            this.buttonInserirAlunoConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonInserirAlunoConfirmar.Name = "buttonInserirAlunoConfirmar";
            this.buttonInserirAlunoConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirAlunoConfirmar.TabIndex = 11;
            this.buttonInserirAlunoConfirmar.Text = "Confirmar";
            this.buttonInserirAlunoConfirmar.UseVisualStyleBackColor = true;
            this.buttonInserirAlunoConfirmar.Click += new System.EventHandler(this.buttonInserirAlunoConfirmar_Click);
            // 
            // buttonInserirAlunoCancelar
            // 
            this.buttonInserirAlunoCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonInserirAlunoCancelar.Name = "buttonInserirAlunoCancelar";
            this.buttonInserirAlunoCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirAlunoCancelar.TabIndex = 12;
            this.buttonInserirAlunoCancelar.Text = "Cancelar";
            this.buttonInserirAlunoCancelar.UseVisualStyleBackColor = true;
            this.buttonInserirAlunoCancelar.Click += new System.EventHandler(this.buttonInserirAlunoCancelar_Click);
            // 
            // comboBoxInserirAlunoCurso
            // 
            this.comboBoxInserirAlunoCurso.AutoCompleteCustomSource.AddRange(new string[] {
            "COMPUTAÇÂO",
            "MECÂNICA"});
            this.comboBoxInserirAlunoCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxInserirAlunoCurso.ForeColor = System.Drawing.SystemColors.Desktop;
            this.comboBoxInserirAlunoCurso.FormattingEnabled = true;
            this.comboBoxInserirAlunoCurso.Location = new System.Drawing.Point(56, 99);
            this.comboBoxInserirAlunoCurso.Name = "comboBoxInserirAlunoCurso";
            this.comboBoxInserirAlunoCurso.Size = new System.Drawing.Size(372, 21);
            this.comboBoxInserirAlunoCurso.TabIndex = 13;
            // 
            // labelMenuInserirCO
            // 
            this.labelMenuInserirCO.AutoSize = true;
            this.labelMenuInserirCO.Location = new System.Drawing.Point(16, 180);
            this.labelMenuInserirCO.Name = "labelMenuInserirCO";
            this.labelMenuInserirCO.Size = new System.Drawing.Size(210, 13);
            this.labelMenuInserirCO.TabIndex = 14;
            this.labelMenuInserirCO.Text = "( * ) - Campos de preenchimento obrigatório";
            // 
            // maskedTextBoxInserirAlunoCPF
            // 
            this.maskedTextBoxInserirAlunoCPF.Location = new System.Drawing.Point(193, 58);
            this.maskedTextBoxInserirAlunoCPF.Mask = "999,999,999-99";
            this.maskedTextBoxInserirAlunoCPF.Name = "maskedTextBoxInserirAlunoCPF";
            this.maskedTextBoxInserirAlunoCPF.Size = new System.Drawing.Size(92, 20);
            this.maskedTextBoxInserirAlunoCPF.TabIndex = 15;
            this.maskedTextBoxInserirAlunoCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxInserirAlunoTelefone
            // 
            this.maskedTextBoxInserirAlunoTelefone.Location = new System.Drawing.Point(350, 58);
            this.maskedTextBoxInserirAlunoTelefone.Mask = "(99) 9999-9999";
            this.maskedTextBoxInserirAlunoTelefone.Name = "maskedTextBoxInserirAlunoTelefone";
            this.maskedTextBoxInserirAlunoTelefone.Size = new System.Drawing.Size(80, 20);
            this.maskedTextBoxInserirAlunoTelefone.TabIndex = 16;
            this.maskedTextBoxInserirAlunoTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // FrmMenuInserirAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.maskedTextBoxInserirAlunoTelefone);
            this.Controls.Add(this.maskedTextBoxInserirAlunoCPF);
            this.Controls.Add(this.labelMenuInserirCO);
            this.Controls.Add(this.comboBoxInserirAlunoCurso);
            this.Controls.Add(this.buttonInserirAlunoCancelar);
            this.Controls.Add(this.buttonInserirAlunoConfirmar);
            this.Controls.Add(this.textBoxInserirAlunoMatricula);
            this.Controls.Add(this.textBoxInserirAlunoNome);
            this.Controls.Add(this.labelInserirAlunoCPF);
            this.Controls.Add(this.labelInserirAlunoCurso);
            this.Controls.Add(this.labelInserirAlunoTelefone);
            this.Controls.Add(this.labelInserirAlunoMatricula);
            this.Controls.Add(this.labelInserirAlunoNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuInserirAluno";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInserirAlunoNome;
        private System.Windows.Forms.Label labelInserirAlunoMatricula;
        private System.Windows.Forms.Label labelInserirAlunoTelefone;
        private System.Windows.Forms.Label labelInserirAlunoCurso;
        private System.Windows.Forms.Label labelInserirAlunoCPF;
        private System.Windows.Forms.TextBox textBoxInserirAlunoNome;
        private System.Windows.Forms.TextBox textBoxInserirAlunoMatricula;
        private System.Windows.Forms.Button buttonInserirAlunoConfirmar;
        private System.Windows.Forms.Button buttonInserirAlunoCancelar;
        private System.Windows.Forms.ComboBox comboBoxInserirAlunoCurso;
        private System.Windows.Forms.Label labelMenuInserirCO;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInserirAlunoCPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInserirAlunoTelefone;
    }
}