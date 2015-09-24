namespace Apresentacao
{
    partial class FrmMenuInserirProfessor
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
            this.labelInserirProfessorNome = new System.Windows.Forms.Label();
            this.labelInserirProfessorMatricula = new System.Windows.Forms.Label();
            this.textBoxInserirProfessorNome = new System.Windows.Forms.TextBox();
            this.textBoxInserirProfessorMatricula = new System.Windows.Forms.TextBox();
            this.buttonInserirProfessorConfirmar = new System.Windows.Forms.Button();
            this.buttonInserirProfessorCancelar = new System.Windows.Forms.Button();
            this.labelInserirProfessorTelefone = new System.Windows.Forms.Label();
            this.labelInserirProfessorCPF = new System.Windows.Forms.Label();
            this.labelMenuInserirCO = new System.Windows.Forms.Label();
            this.maskedTextBoxInserirProfessorCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxInserirProfessorTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelInserirProfessorNome
            // 
            this.labelInserirProfessorNome.AutoSize = true;
            this.labelInserirProfessorNome.Location = new System.Drawing.Point(16, 22);
            this.labelInserirProfessorNome.Name = "labelInserirProfessorNome";
            this.labelInserirProfessorNome.Size = new System.Drawing.Size(45, 13);
            this.labelInserirProfessorNome.TabIndex = 0;
            this.labelInserirProfessorNome.Text = "Nome*: ";
            // 
            // labelInserirProfessorMatricula
            // 
            this.labelInserirProfessorMatricula.AutoSize = true;
            this.labelInserirProfessorMatricula.Location = new System.Drawing.Point(16, 62);
            this.labelInserirProfessorMatricula.Name = "labelInserirProfessorMatricula";
            this.labelInserirProfessorMatricula.Size = new System.Drawing.Size(59, 13);
            this.labelInserirProfessorMatricula.TabIndex = 1;
            this.labelInserirProfessorMatricula.Text = "Matrícula*:";
            // 
            // textBoxInserirProfessorNome
            // 
            this.textBoxInserirProfessorNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInserirProfessorNome.Location = new System.Drawing.Point(57, 18);
            this.textBoxInserirProfessorNome.Name = "textBoxInserirProfessorNome";
            this.textBoxInserirProfessorNome.Size = new System.Drawing.Size(373, 20);
            this.textBoxInserirProfessorNome.TabIndex = 6;
            // 
            // textBoxInserirProfessorMatricula
            // 
            this.textBoxInserirProfessorMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInserirProfessorMatricula.Location = new System.Drawing.Point(75, 58);
            this.textBoxInserirProfessorMatricula.Name = "textBoxInserirProfessorMatricula";
            this.textBoxInserirProfessorMatricula.Size = new System.Drawing.Size(79, 20);
            this.textBoxInserirProfessorMatricula.TabIndex = 7;
            // 
            // buttonInserirProfessorConfirmar
            // 
            this.buttonInserirProfessorConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonInserirProfessorConfirmar.Name = "buttonInserirProfessorConfirmar";
            this.buttonInserirProfessorConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirProfessorConfirmar.TabIndex = 11;
            this.buttonInserirProfessorConfirmar.Text = "Confirmar";
            this.buttonInserirProfessorConfirmar.UseVisualStyleBackColor = true;
            this.buttonInserirProfessorConfirmar.Click += new System.EventHandler(this.buttonInserirProfessorConfirmar_Click);
            // 
            // buttonInserirProfessorCancelar
            // 
            this.buttonInserirProfessorCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonInserirProfessorCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonInserirProfessorCancelar.Name = "buttonInserirProfessorCancelar";
            this.buttonInserirProfessorCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirProfessorCancelar.TabIndex = 12;
            this.buttonInserirProfessorCancelar.Text = "Cancelar";
            this.buttonInserirProfessorCancelar.UseVisualStyleBackColor = true;
            this.buttonInserirProfessorCancelar.Click += new System.EventHandler(this.buttonInserirProfessorCancelar_Click);
            // 
            // labelInserirProfessorTelefone
            // 
            this.labelInserirProfessorTelefone.AutoSize = true;
            this.labelInserirProfessorTelefone.Location = new System.Drawing.Point(291, 62);
            this.labelInserirProfessorTelefone.Name = "labelInserirProfessorTelefone";
            this.labelInserirProfessorTelefone.Size = new System.Drawing.Size(55, 13);
            this.labelInserirProfessorTelefone.TabIndex = 2;
            this.labelInserirProfessorTelefone.Text = "Telefone: ";
            // 
            // labelInserirProfessorCPF
            // 
            this.labelInserirProfessorCPF.AutoSize = true;
            this.labelInserirProfessorCPF.Location = new System.Drawing.Point(158, 62);
            this.labelInserirProfessorCPF.Name = "labelInserirProfessorCPF";
            this.labelInserirProfessorCPF.Size = new System.Drawing.Size(37, 13);
            this.labelInserirProfessorCPF.TabIndex = 5;
            this.labelInserirProfessorCPF.Text = "CPF*: ";
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
            // maskedTextBoxInserirProfessorCPF
            // 
            this.maskedTextBoxInserirProfessorCPF.Location = new System.Drawing.Point(195, 58);
            this.maskedTextBoxInserirProfessorCPF.Mask = "999,999,999-99";
            this.maskedTextBoxInserirProfessorCPF.Name = "maskedTextBoxInserirProfessorCPF";
            this.maskedTextBoxInserirProfessorCPF.Size = new System.Drawing.Size(92, 20);
            this.maskedTextBoxInserirProfessorCPF.TabIndex = 16;
            // 
            // maskedTextBoxInserirProfessorTelefone
            // 
            this.maskedTextBoxInserirProfessorTelefone.Location = new System.Drawing.Point(345, 58);
            this.maskedTextBoxInserirProfessorTelefone.Mask = "(99)999999999";
            this.maskedTextBoxInserirProfessorTelefone.Name = "maskedTextBoxInserirProfessorTelefone";
            this.maskedTextBoxInserirProfessorTelefone.Size = new System.Drawing.Size(85, 20);
            this.maskedTextBoxInserirProfessorTelefone.TabIndex = 17;
            // 
            // FrmMenuInserirProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.maskedTextBoxInserirProfessorTelefone);
            this.Controls.Add(this.maskedTextBoxInserirProfessorCPF);
            this.Controls.Add(this.labelMenuInserirCO);
            this.Controls.Add(this.buttonInserirProfessorCancelar);
            this.Controls.Add(this.buttonInserirProfessorConfirmar);
            this.Controls.Add(this.textBoxInserirProfessorMatricula);
            this.Controls.Add(this.textBoxInserirProfessorNome);
            this.Controls.Add(this.labelInserirProfessorCPF);
            this.Controls.Add(this.labelInserirProfessorTelefone);
            this.Controls.Add(this.labelInserirProfessorMatricula);
            this.Controls.Add(this.labelInserirProfessorNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuInserirProfessor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInserirProfessorNome;
        private System.Windows.Forms.Label labelInserirProfessorMatricula;
        private System.Windows.Forms.TextBox textBoxInserirProfessorNome;
        private System.Windows.Forms.TextBox textBoxInserirProfessorMatricula;
        private System.Windows.Forms.Button buttonInserirProfessorConfirmar;
        private System.Windows.Forms.Button buttonInserirProfessorCancelar;
        private System.Windows.Forms.Label labelInserirProfessorTelefone;
        private System.Windows.Forms.Label labelInserirProfessorCPF;
        private System.Windows.Forms.Label labelMenuInserirCO;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInserirProfessorCPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInserirProfessorTelefone;
    }
}