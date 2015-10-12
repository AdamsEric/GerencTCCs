namespace Apresentacao
{
    partial class FrmMenuAlterarAluno
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
            this.labelAlterarAlunoNome = new System.Windows.Forms.Label();
            this.labelAlterarAlunoMatricula = new System.Windows.Forms.Label();
            this.labelAlterarAlunoTelefone = new System.Windows.Forms.Label();
            this.labelAlterarAlunoCurso = new System.Windows.Forms.Label();
            this.textBoxAlterarAlunoNome = new System.Windows.Forms.TextBox();
            this.textBoxAlterarAlunoMatricula = new System.Windows.Forms.TextBox();
            this.buttonAlterarAlunoConfirmar = new System.Windows.Forms.Button();
            this.buttonAlterarAlunoCancelar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelMenuInserirCO = new System.Windows.Forms.Label();
            this.maskedTextBoxAlterarAlunoTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelAlterarAlunoNome
            // 
            this.labelAlterarAlunoNome.AutoSize = true;
            this.labelAlterarAlunoNome.Location = new System.Drawing.Point(16, 22);
            this.labelAlterarAlunoNome.Name = "labelAlterarAlunoNome";
            this.labelAlterarAlunoNome.Size = new System.Drawing.Size(45, 13);
            this.labelAlterarAlunoNome.TabIndex = 0;
            this.labelAlterarAlunoNome.Text = "Nome*: ";
            // 
            // labelAlterarAlunoMatricula
            // 
            this.labelAlterarAlunoMatricula.AutoSize = true;
            this.labelAlterarAlunoMatricula.Location = new System.Drawing.Point(16, 62);
            this.labelAlterarAlunoMatricula.Name = "labelAlterarAlunoMatricula";
            this.labelAlterarAlunoMatricula.Size = new System.Drawing.Size(59, 13);
            this.labelAlterarAlunoMatricula.TabIndex = 1;
            this.labelAlterarAlunoMatricula.Text = "Matrícula*:";
            // 
            // labelAlterarAlunoTelefone
            // 
            this.labelAlterarAlunoTelefone.AutoSize = true;
            this.labelAlterarAlunoTelefone.Location = new System.Drawing.Point(164, 62);
            this.labelAlterarAlunoTelefone.Name = "labelAlterarAlunoTelefone";
            this.labelAlterarAlunoTelefone.Size = new System.Drawing.Size(55, 13);
            this.labelAlterarAlunoTelefone.TabIndex = 2;
            this.labelAlterarAlunoTelefone.Text = "Telefone: ";
            // 
            // labelAlterarAlunoCurso
            // 
            this.labelAlterarAlunoCurso.AutoSize = true;
            this.labelAlterarAlunoCurso.Location = new System.Drawing.Point(16, 102);
            this.labelAlterarAlunoCurso.Name = "labelAlterarAlunoCurso";
            this.labelAlterarAlunoCurso.Size = new System.Drawing.Size(41, 13);
            this.labelAlterarAlunoCurso.TabIndex = 3;
            this.labelAlterarAlunoCurso.Text = "Curso*:";
            // 
            // textBoxAlterarAlunoNome
            // 
            this.textBoxAlterarAlunoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAlterarAlunoNome.Location = new System.Drawing.Point(57, 18);
            this.textBoxAlterarAlunoNome.Name = "textBoxAlterarAlunoNome";
            this.textBoxAlterarAlunoNome.Size = new System.Drawing.Size(373, 20);
            this.textBoxAlterarAlunoNome.TabIndex = 6;
            // 
            // textBoxAlterarAlunoMatricula
            // 
            this.textBoxAlterarAlunoMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAlterarAlunoMatricula.Location = new System.Drawing.Point(75, 58);
            this.textBoxAlterarAlunoMatricula.Name = "textBoxAlterarAlunoMatricula";
            this.textBoxAlterarAlunoMatricula.Size = new System.Drawing.Size(79, 20);
            this.textBoxAlterarAlunoMatricula.TabIndex = 7;
            // 
            // buttonAlterarAlunoConfirmar
            // 
            this.buttonAlterarAlunoConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonAlterarAlunoConfirmar.Name = "buttonAlterarAlunoConfirmar";
            this.buttonAlterarAlunoConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarAlunoConfirmar.TabIndex = 11;
            this.buttonAlterarAlunoConfirmar.Text = "Confirmar";
            this.buttonAlterarAlunoConfirmar.UseVisualStyleBackColor = true;
            this.buttonAlterarAlunoConfirmar.Click += new System.EventHandler(this.buttonAlterarAlunoConfirmar_Click);
            // 
            // buttonAlterarAlunoCancelar
            // 
            this.buttonAlterarAlunoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAlterarAlunoCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonAlterarAlunoCancelar.Name = "buttonAlterarAlunoCancelar";
            this.buttonAlterarAlunoCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarAlunoCancelar.TabIndex = 12;
            this.buttonAlterarAlunoCancelar.Text = "Cancelar";
            this.buttonAlterarAlunoCancelar.UseVisualStyleBackColor = true;
            this.buttonAlterarAlunoCancelar.Click += new System.EventHandler(this.buttonAlterarAlunoCancelar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(372, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // labelMenuInserirCO
            // 
            this.labelMenuInserirCO.AutoSize = true;
            this.labelMenuInserirCO.Location = new System.Drawing.Point(16, 180);
            this.labelMenuInserirCO.Name = "labelMenuInserirCO";
            this.labelMenuInserirCO.Size = new System.Drawing.Size(210, 13);
            this.labelMenuInserirCO.TabIndex = 15;
            this.labelMenuInserirCO.Text = "( * ) - Campos de preenchimento obrigatório";
            // 
            // maskedTextBoxAlterarAlunoTelefone
            // 
            this.maskedTextBoxAlterarAlunoTelefone.Location = new System.Drawing.Point(224, 58);
            this.maskedTextBoxAlterarAlunoTelefone.Mask = "(99)999999999";
            this.maskedTextBoxAlterarAlunoTelefone.Name = "maskedTextBoxAlterarAlunoTelefone";
            this.maskedTextBoxAlterarAlunoTelefone.Size = new System.Drawing.Size(80, 20);
            this.maskedTextBoxAlterarAlunoTelefone.TabIndex = 17;
            this.maskedTextBoxAlterarAlunoTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // FrmMenuAlterarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.maskedTextBoxAlterarAlunoTelefone);
            this.Controls.Add(this.labelMenuInserirCO);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonAlterarAlunoCancelar);
            this.Controls.Add(this.buttonAlterarAlunoConfirmar);
            this.Controls.Add(this.textBoxAlterarAlunoMatricula);
            this.Controls.Add(this.textBoxAlterarAlunoNome);
            this.Controls.Add(this.labelAlterarAlunoCurso);
            this.Controls.Add(this.labelAlterarAlunoTelefone);
            this.Controls.Add(this.labelAlterarAlunoMatricula);
            this.Controls.Add(this.labelAlterarAlunoNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAlterarAluno";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Aluno";
            this.Load += new System.EventHandler(this.FrmMenuAlterarAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlterarAlunoNome;
        private System.Windows.Forms.Label labelAlterarAlunoMatricula;
        private System.Windows.Forms.Label labelAlterarAlunoTelefone;
        private System.Windows.Forms.Label labelAlterarAlunoCurso;
        private System.Windows.Forms.TextBox textBoxAlterarAlunoNome;
        private System.Windows.Forms.TextBox textBoxAlterarAlunoMatricula;
        private System.Windows.Forms.Button buttonAlterarAlunoConfirmar;
        private System.Windows.Forms.Button buttonAlterarAlunoCancelar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelMenuInserirCO;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAlterarAlunoTelefone;
    }
}