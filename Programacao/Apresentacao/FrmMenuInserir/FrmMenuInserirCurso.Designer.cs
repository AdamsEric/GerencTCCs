namespace Apresentacao
{
    partial class FrmMenuInserirCurso
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
            this.labelInserirCursoNome = new System.Windows.Forms.Label();
            this.labelInserirCursoUnidade = new System.Windows.Forms.Label();
            this.labelInserirCursoCoordenador = new System.Windows.Forms.Label();
            this.textBoxInserirCursoNome = new System.Windows.Forms.TextBox();
            this.buttonInserirCursoConfirmar = new System.Windows.Forms.Button();
            this.buttonInserirCursoCancelar = new System.Windows.Forms.Button();
            this.labelMenuInserirCO = new System.Windows.Forms.Label();
            this.textBoxInserirCursoCoordenadorID = new System.Windows.Forms.TextBox();
            this.textBoxInserirCursoUnidadeID = new System.Windows.Forms.TextBox();
            this.comboBoxInserirCursoCoordenadorNome = new System.Windows.Forms.ComboBox();
            this.comboBoxInserirCursoUnidadeNome = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelInserirCursoNome
            // 
            this.labelInserirCursoNome.AutoSize = true;
            this.labelInserirCursoNome.Location = new System.Drawing.Point(16, 22);
            this.labelInserirCursoNome.Name = "labelInserirCursoNome";
            this.labelInserirCursoNome.Size = new System.Drawing.Size(45, 13);
            this.labelInserirCursoNome.TabIndex = 0;
            this.labelInserirCursoNome.Text = "Nome*: ";
            // 
            // labelInserirCursoUnidade
            // 
            this.labelInserirCursoUnidade.AutoSize = true;
            this.labelInserirCursoUnidade.Location = new System.Drawing.Point(16, 62);
            this.labelInserirCursoUnidade.Name = "labelInserirCursoUnidade";
            this.labelInserirCursoUnidade.Size = new System.Drawing.Size(57, 13);
            this.labelInserirCursoUnidade.TabIndex = 1;
            this.labelInserirCursoUnidade.Text = "Unidade*: ";
            // 
            // labelInserirCursoCoordenador
            // 
            this.labelInserirCursoCoordenador.AutoSize = true;
            this.labelInserirCursoCoordenador.Location = new System.Drawing.Point(16, 101);
            this.labelInserirCursoCoordenador.Name = "labelInserirCursoCoordenador";
            this.labelInserirCursoCoordenador.Size = new System.Drawing.Size(78, 13);
            this.labelInserirCursoCoordenador.TabIndex = 3;
            this.labelInserirCursoCoordenador.Text = "Coordenador*: ";
            // 
            // textBoxInserirCursoNome
            // 
            this.textBoxInserirCursoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInserirCursoNome.Location = new System.Drawing.Point(57, 18);
            this.textBoxInserirCursoNome.Name = "textBoxInserirCursoNome";
            this.textBoxInserirCursoNome.Size = new System.Drawing.Size(373, 20);
            this.textBoxInserirCursoNome.TabIndex = 6;
            // 
            // buttonInserirCursoConfirmar
            // 
            this.buttonInserirCursoConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonInserirCursoConfirmar.Name = "buttonInserirCursoConfirmar";
            this.buttonInserirCursoConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirCursoConfirmar.TabIndex = 11;
            this.buttonInserirCursoConfirmar.Text = "Confirmar";
            this.buttonInserirCursoConfirmar.UseVisualStyleBackColor = true;
            this.buttonInserirCursoConfirmar.Click += new System.EventHandler(this.buttonInserirCursoConfirmar_Click);
            // 
            // buttonInserirCursoCancelar
            // 
            this.buttonInserirCursoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonInserirCursoCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonInserirCursoCancelar.Name = "buttonInserirCursoCancelar";
            this.buttonInserirCursoCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirCursoCancelar.TabIndex = 12;
            this.buttonInserirCursoCancelar.Text = "Cancelar";
            this.buttonInserirCursoCancelar.UseVisualStyleBackColor = true;
            this.buttonInserirCursoCancelar.Click += new System.EventHandler(this.buttonInserirCursoCancelar_Click);
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
            // textBoxInserirCursoCoordenadorID
            // 
            this.textBoxInserirCursoCoordenadorID.Location = new System.Drawing.Point(91, 97);
            this.textBoxInserirCursoCoordenadorID.Name = "textBoxInserirCursoCoordenadorID";
            this.textBoxInserirCursoCoordenadorID.Size = new System.Drawing.Size(43, 20);
            this.textBoxInserirCursoCoordenadorID.TabIndex = 21;
            // 
            // textBoxInserirCursoUnidadeID
            // 
            this.textBoxInserirCursoUnidadeID.Location = new System.Drawing.Point(72, 58);
            this.textBoxInserirCursoUnidadeID.Name = "textBoxInserirCursoUnidadeID";
            this.textBoxInserirCursoUnidadeID.Size = new System.Drawing.Size(43, 20);
            this.textBoxInserirCursoUnidadeID.TabIndex = 20;
            // 
            // comboBoxInserirCursoCoordenadorNome
            // 
            this.comboBoxInserirCursoCoordenadorNome.FormattingEnabled = true;
            this.comboBoxInserirCursoCoordenadorNome.Location = new System.Drawing.Point(140, 97);
            this.comboBoxInserirCursoCoordenadorNome.Name = "comboBoxInserirCursoCoordenadorNome";
            this.comboBoxInserirCursoCoordenadorNome.Size = new System.Drawing.Size(290, 21);
            this.comboBoxInserirCursoCoordenadorNome.TabIndex = 19;
            // 
            // comboBoxInserirCursoUnidadeNome
            // 
            this.comboBoxInserirCursoUnidadeNome.FormattingEnabled = true;
            this.comboBoxInserirCursoUnidadeNome.Location = new System.Drawing.Point(128, 58);
            this.comboBoxInserirCursoUnidadeNome.Name = "comboBoxInserirCursoUnidadeNome";
            this.comboBoxInserirCursoUnidadeNome.Size = new System.Drawing.Size(302, 21);
            this.comboBoxInserirCursoUnidadeNome.TabIndex = 18;
            // 
            // FrmMenuInserirCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.textBoxInserirCursoCoordenadorID);
            this.Controls.Add(this.textBoxInserirCursoUnidadeID);
            this.Controls.Add(this.comboBoxInserirCursoCoordenadorNome);
            this.Controls.Add(this.comboBoxInserirCursoUnidadeNome);
            this.Controls.Add(this.labelMenuInserirCO);
            this.Controls.Add(this.buttonInserirCursoCancelar);
            this.Controls.Add(this.buttonInserirCursoConfirmar);
            this.Controls.Add(this.textBoxInserirCursoNome);
            this.Controls.Add(this.labelInserirCursoCoordenador);
            this.Controls.Add(this.labelInserirCursoUnidade);
            this.Controls.Add(this.labelInserirCursoNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuInserirCurso";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInserirCursoNome;
        private System.Windows.Forms.Label labelInserirCursoUnidade;
        private System.Windows.Forms.Label labelInserirCursoCoordenador;
        private System.Windows.Forms.TextBox textBoxInserirCursoNome;
        private System.Windows.Forms.Button buttonInserirCursoConfirmar;
        private System.Windows.Forms.Button buttonInserirCursoCancelar;
        private System.Windows.Forms.Label labelMenuInserirCO;
        private System.Windows.Forms.TextBox textBoxInserirCursoCoordenadorID;
        private System.Windows.Forms.TextBox textBoxInserirCursoUnidadeID;
        private System.Windows.Forms.ComboBox comboBoxInserirCursoCoordenadorNome;
        private System.Windows.Forms.ComboBox comboBoxInserirCursoUnidadeNome;
    }
}