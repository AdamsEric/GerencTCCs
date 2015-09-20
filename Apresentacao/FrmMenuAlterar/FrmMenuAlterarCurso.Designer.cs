namespace Apresentacao
{
    partial class FrmMenuAlterarCurso
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
            this.labelAlterarCursoNome = new System.Windows.Forms.Label();
            this.labelAlterarCursoUnidade = new System.Windows.Forms.Label();
            this.labelAlterarCursoCoordenador = new System.Windows.Forms.Label();
            this.textBoxAlterarCursoNome = new System.Windows.Forms.TextBox();
            this.buttonAlterarCursoConfirmar = new System.Windows.Forms.Button();
            this.buttonAlterarCursoCancelar = new System.Windows.Forms.Button();
            this.comboBoxAlterarCursoUnidade = new System.Windows.Forms.ComboBox();
            this.comboBoxAlterarCursoCoordenador = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelAlterarCursoNome
            // 
            this.labelAlterarCursoNome.AutoSize = true;
            this.labelAlterarCursoNome.Location = new System.Drawing.Point(16, 22);
            this.labelAlterarCursoNome.Name = "labelAlterarCursoNome";
            this.labelAlterarCursoNome.Size = new System.Drawing.Size(41, 13);
            this.labelAlterarCursoNome.TabIndex = 0;
            this.labelAlterarCursoNome.Text = "Nome: ";
            // 
            // labelAlterarCursoUnidade
            // 
            this.labelAlterarCursoUnidade.AutoSize = true;
            this.labelAlterarCursoUnidade.Location = new System.Drawing.Point(16, 62);
            this.labelAlterarCursoUnidade.Name = "labelAlterarCursoUnidade";
            this.labelAlterarCursoUnidade.Size = new System.Drawing.Size(53, 13);
            this.labelAlterarCursoUnidade.TabIndex = 1;
            this.labelAlterarCursoUnidade.Text = "Unidade: ";
            // 
            // labelAlterarCursoCoordenador
            // 
            this.labelAlterarCursoCoordenador.AutoSize = true;
            this.labelAlterarCursoCoordenador.Location = new System.Drawing.Point(16, 101);
            this.labelAlterarCursoCoordenador.Name = "labelAlterarCursoCoordenador";
            this.labelAlterarCursoCoordenador.Size = new System.Drawing.Size(74, 13);
            this.labelAlterarCursoCoordenador.TabIndex = 3;
            this.labelAlterarCursoCoordenador.Text = "Coordenador: ";
            // 
            // textBoxAlterarCursoNome
            // 
            this.textBoxAlterarCursoNome.Location = new System.Drawing.Point(57, 18);
            this.textBoxAlterarCursoNome.Name = "textBoxAlterarCursoNome";
            this.textBoxAlterarCursoNome.Size = new System.Drawing.Size(373, 20);
            this.textBoxAlterarCursoNome.TabIndex = 6;
            // 
            // buttonAlterarCursoConfirmar
            // 
            this.buttonAlterarCursoConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonAlterarCursoConfirmar.Name = "buttonAlterarCursoConfirmar";
            this.buttonAlterarCursoConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarCursoConfirmar.TabIndex = 11;
            this.buttonAlterarCursoConfirmar.Text = "Confirmar";
            this.buttonAlterarCursoConfirmar.UseVisualStyleBackColor = true;
            // 
            // buttonAlterarCursoCancelar
            // 
            this.buttonAlterarCursoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAlterarCursoCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonAlterarCursoCancelar.Name = "buttonAlterarCursoCancelar";
            this.buttonAlterarCursoCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarCursoCancelar.TabIndex = 12;
            this.buttonAlterarCursoCancelar.Text = "Cancelar";
            this.buttonAlterarCursoCancelar.UseVisualStyleBackColor = true;
            this.buttonAlterarCursoCancelar.Click += new System.EventHandler(this.buttonAlterarCursoCancelar_Click);
            // 
            // comboBoxAlterarCursoUnidade
            // 
            this.comboBoxAlterarCursoUnidade.FormattingEnabled = true;
            this.comboBoxAlterarCursoUnidade.Location = new System.Drawing.Point(75, 59);
            this.comboBoxAlterarCursoUnidade.Name = "comboBoxAlterarCursoUnidade";
            this.comboBoxAlterarCursoUnidade.Size = new System.Drawing.Size(355, 21);
            this.comboBoxAlterarCursoUnidade.TabIndex = 13;
            // 
            // comboBoxAlterarCursoCoordenador
            // 
            this.comboBoxAlterarCursoCoordenador.FormattingEnabled = true;
            this.comboBoxAlterarCursoCoordenador.Location = new System.Drawing.Point(96, 98);
            this.comboBoxAlterarCursoCoordenador.Name = "comboBoxAlterarCursoCoordenador";
            this.comboBoxAlterarCursoCoordenador.Size = new System.Drawing.Size(334, 21);
            this.comboBoxAlterarCursoCoordenador.TabIndex = 14;
            // 
            // FrmMenuAlterarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.comboBoxAlterarCursoCoordenador);
            this.Controls.Add(this.comboBoxAlterarCursoUnidade);
            this.Controls.Add(this.buttonAlterarCursoCancelar);
            this.Controls.Add(this.buttonAlterarCursoConfirmar);
            this.Controls.Add(this.textBoxAlterarCursoNome);
            this.Controls.Add(this.labelAlterarCursoCoordenador);
            this.Controls.Add(this.labelAlterarCursoUnidade);
            this.Controls.Add(this.labelAlterarCursoNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAlterarCurso";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Curso";
            this.Load += new System.EventHandler(this.FrmMenuAlterarCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlterarCursoNome;
        private System.Windows.Forms.Label labelAlterarCursoUnidade;
        private System.Windows.Forms.Label labelAlterarCursoCoordenador;
        private System.Windows.Forms.TextBox textBoxAlterarCursoNome;
        private System.Windows.Forms.Button buttonAlterarCursoConfirmar;
        private System.Windows.Forms.Button buttonAlterarCursoCancelar;
        private System.Windows.Forms.ComboBox comboBoxAlterarCursoUnidade;
        private System.Windows.Forms.ComboBox comboBoxAlterarCursoCoordenador;
    }
}