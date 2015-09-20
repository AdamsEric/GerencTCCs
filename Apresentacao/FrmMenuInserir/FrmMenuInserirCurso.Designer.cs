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
            this.comboBoxInserirCursoUnidade = new System.Windows.Forms.ComboBox();
            this.comboBoxInserirCursoCoordenador = new System.Windows.Forms.ComboBox();
            this.labelMenuInserirCO = new System.Windows.Forms.Label();
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
            // comboBoxInserirCursoUnidade
            // 
            this.comboBoxInserirCursoUnidade.FormattingEnabled = true;
            this.comboBoxInserirCursoUnidade.Location = new System.Drawing.Point(75, 59);
            this.comboBoxInserirCursoUnidade.Name = "comboBoxInserirCursoUnidade";
            this.comboBoxInserirCursoUnidade.Size = new System.Drawing.Size(355, 21);
            this.comboBoxInserirCursoUnidade.TabIndex = 13;
            // 
            // comboBoxInserirCursoCoordenador
            // 
            this.comboBoxInserirCursoCoordenador.FormattingEnabled = true;
            this.comboBoxInserirCursoCoordenador.Location = new System.Drawing.Point(96, 98);
            this.comboBoxInserirCursoCoordenador.Name = "comboBoxInserirCursoCoordenador";
            this.comboBoxInserirCursoCoordenador.Size = new System.Drawing.Size(334, 21);
            this.comboBoxInserirCursoCoordenador.TabIndex = 14;
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
            // FrmMenuInserirCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.labelMenuInserirCO);
            this.Controls.Add(this.comboBoxInserirCursoCoordenador);
            this.Controls.Add(this.comboBoxInserirCursoUnidade);
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
            this.Load += new System.EventHandler(this.FrmMenuInserirCurso_Load);
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
        private System.Windows.Forms.ComboBox comboBoxInserirCursoUnidade;
        private System.Windows.Forms.ComboBox comboBoxInserirCursoCoordenador;
        private System.Windows.Forms.Label labelMenuInserirCO;
    }
}