namespace Apresentacao
{
    partial class FrmMenuAlterarProfessor
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
            this.labelAlterarProfessorNome = new System.Windows.Forms.Label();
            this.labelAlterarProfessorMatricula = new System.Windows.Forms.Label();
            this.textBoxAlterarProfessorNome = new System.Windows.Forms.TextBox();
            this.textBoxAlterarProfessorMatricula = new System.Windows.Forms.TextBox();
            this.buttonAlterarProfessorConfirmar = new System.Windows.Forms.Button();
            this.buttonAlterarProfessorCancelar = new System.Windows.Forms.Button();
            this.labelAlterarProfessorTelefone = new System.Windows.Forms.Label();
            this.labelAlterarProfessorCPF = new System.Windows.Forms.Label();
            this.labelMenuInserirCO = new System.Windows.Forms.Label();
            this.maskedTextBoxAlterarProfessorCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAlterarProfessorTelefone = new System.Windows.Forms.MaskedTextBox();
            this.labelAlterarProfessorID = new System.Windows.Forms.Label();
            this.textBoxAlterarProfessorID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAlterarProfessorNome
            // 
            this.labelAlterarProfessorNome.AutoSize = true;
            this.labelAlterarProfessorNome.Location = new System.Drawing.Point(16, 22);
            this.labelAlterarProfessorNome.Name = "labelAlterarProfessorNome";
            this.labelAlterarProfessorNome.Size = new System.Drawing.Size(45, 13);
            this.labelAlterarProfessorNome.TabIndex = 0;
            this.labelAlterarProfessorNome.Text = "Nome*: ";
            // 
            // labelAlterarProfessorMatricula
            // 
            this.labelAlterarProfessorMatricula.AutoSize = true;
            this.labelAlterarProfessorMatricula.Location = new System.Drawing.Point(16, 62);
            this.labelAlterarProfessorMatricula.Name = "labelAlterarProfessorMatricula";
            this.labelAlterarProfessorMatricula.Size = new System.Drawing.Size(59, 13);
            this.labelAlterarProfessorMatricula.TabIndex = 1;
            this.labelAlterarProfessorMatricula.Text = "Matrícula*:";
            // 
            // textBoxAlterarProfessorNome
            // 
            this.textBoxAlterarProfessorNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAlterarProfessorNome.Location = new System.Drawing.Point(57, 18);
            this.textBoxAlterarProfessorNome.Name = "textBoxAlterarProfessorNome";
            this.textBoxAlterarProfessorNome.Size = new System.Drawing.Size(373, 20);
            this.textBoxAlterarProfessorNome.TabIndex = 6;
            // 
            // textBoxAlterarProfessorMatricula
            // 
            this.textBoxAlterarProfessorMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAlterarProfessorMatricula.Location = new System.Drawing.Point(75, 58);
            this.textBoxAlterarProfessorMatricula.Name = "textBoxAlterarProfessorMatricula";
            this.textBoxAlterarProfessorMatricula.Size = new System.Drawing.Size(79, 20);
            this.textBoxAlterarProfessorMatricula.TabIndex = 7;
            // 
            // buttonAlterarProfessorConfirmar
            // 
            this.buttonAlterarProfessorConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonAlterarProfessorConfirmar.Name = "buttonAlterarProfessorConfirmar";
            this.buttonAlterarProfessorConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarProfessorConfirmar.TabIndex = 11;
            this.buttonAlterarProfessorConfirmar.Text = "Confirmar";
            this.buttonAlterarProfessorConfirmar.UseVisualStyleBackColor = true;
            this.buttonAlterarProfessorConfirmar.Click += new System.EventHandler(this.buttonAlterarProfessorConfirmar_Click);
            // 
            // buttonAlterarProfessorCancelar
            // 
            this.buttonAlterarProfessorCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAlterarProfessorCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonAlterarProfessorCancelar.Name = "buttonAlterarProfessorCancelar";
            this.buttonAlterarProfessorCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarProfessorCancelar.TabIndex = 12;
            this.buttonAlterarProfessorCancelar.Text = "Cancelar";
            this.buttonAlterarProfessorCancelar.UseVisualStyleBackColor = true;
            this.buttonAlterarProfessorCancelar.Click += new System.EventHandler(this.buttonAlterarProfessorCancelar_Click);
            // 
            // labelAlterarProfessorTelefone
            // 
            this.labelAlterarProfessorTelefone.AutoSize = true;
            this.labelAlterarProfessorTelefone.Location = new System.Drawing.Point(291, 62);
            this.labelAlterarProfessorTelefone.Name = "labelAlterarProfessorTelefone";
            this.labelAlterarProfessorTelefone.Size = new System.Drawing.Size(55, 13);
            this.labelAlterarProfessorTelefone.TabIndex = 2;
            this.labelAlterarProfessorTelefone.Text = "Telefone: ";
            // 
            // labelAlterarProfessorCPF
            // 
            this.labelAlterarProfessorCPF.AutoSize = true;
            this.labelAlterarProfessorCPF.Location = new System.Drawing.Point(158, 62);
            this.labelAlterarProfessorCPF.Name = "labelAlterarProfessorCPF";
            this.labelAlterarProfessorCPF.Size = new System.Drawing.Size(37, 13);
            this.labelAlterarProfessorCPF.TabIndex = 5;
            this.labelAlterarProfessorCPF.Text = "CPF*: ";
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
            // maskedTextBoxAlterarProfessorCPF
            // 
            this.maskedTextBoxAlterarProfessorCPF.Location = new System.Drawing.Point(193, 58);
            this.maskedTextBoxAlterarProfessorCPF.Mask = "999,999,999-99";
            this.maskedTextBoxAlterarProfessorCPF.Name = "maskedTextBoxAlterarProfessorCPF";
            this.maskedTextBoxAlterarProfessorCPF.Size = new System.Drawing.Size(92, 20);
            this.maskedTextBoxAlterarProfessorCPF.TabIndex = 17;
            // 
            // maskedTextBoxAlterarProfessorTelefone
            // 
            this.maskedTextBoxAlterarProfessorTelefone.Location = new System.Drawing.Point(345, 58);
            this.maskedTextBoxAlterarProfessorTelefone.Mask = "(99)999999999";
            this.maskedTextBoxAlterarProfessorTelefone.Name = "maskedTextBoxAlterarProfessorTelefone";
            this.maskedTextBoxAlterarProfessorTelefone.Size = new System.Drawing.Size(85, 20);
            this.maskedTextBoxAlterarProfessorTelefone.TabIndex = 18;
            // 
            // labelAlterarProfessorID
            // 
            this.labelAlterarProfessorID.AutoSize = true;
            this.labelAlterarProfessorID.Location = new System.Drawing.Point(16, 141);
            this.labelAlterarProfessorID.Name = "labelAlterarProfessorID";
            this.labelAlterarProfessorID.Size = new System.Drawing.Size(46, 13);
            this.labelAlterarProfessorID.TabIndex = 24;
            this.labelAlterarProfessorID.Text = "Código: ";
            // 
            // textBoxAlterarProfessorID
            // 
            this.textBoxAlterarProfessorID.Location = new System.Drawing.Point(64, 138);
            this.textBoxAlterarProfessorID.Name = "textBoxAlterarProfessorID";
            this.textBoxAlterarProfessorID.ReadOnly = true;
            this.textBoxAlterarProfessorID.Size = new System.Drawing.Size(90, 20);
            this.textBoxAlterarProfessorID.TabIndex = 23;
            // 
            // FrmMenuAlterarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.labelAlterarProfessorID);
            this.Controls.Add(this.textBoxAlterarProfessorID);
            this.Controls.Add(this.maskedTextBoxAlterarProfessorTelefone);
            this.Controls.Add(this.maskedTextBoxAlterarProfessorCPF);
            this.Controls.Add(this.labelMenuInserirCO);
            this.Controls.Add(this.buttonAlterarProfessorCancelar);
            this.Controls.Add(this.buttonAlterarProfessorConfirmar);
            this.Controls.Add(this.textBoxAlterarProfessorMatricula);
            this.Controls.Add(this.textBoxAlterarProfessorNome);
            this.Controls.Add(this.labelAlterarProfessorCPF);
            this.Controls.Add(this.labelAlterarProfessorTelefone);
            this.Controls.Add(this.labelAlterarProfessorMatricula);
            this.Controls.Add(this.labelAlterarProfessorNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAlterarProfessor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlterarProfessorNome;
        private System.Windows.Forms.Label labelAlterarProfessorMatricula;
        private System.Windows.Forms.TextBox textBoxAlterarProfessorNome;
        private System.Windows.Forms.TextBox textBoxAlterarProfessorMatricula;
        private System.Windows.Forms.Button buttonAlterarProfessorConfirmar;
        private System.Windows.Forms.Button buttonAlterarProfessorCancelar;
        private System.Windows.Forms.Label labelAlterarProfessorTelefone;
        private System.Windows.Forms.Label labelAlterarProfessorCPF;
        private System.Windows.Forms.Label labelMenuInserirCO;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAlterarProfessorCPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAlterarProfessorTelefone;
        private System.Windows.Forms.Label labelAlterarProfessorID;
        private System.Windows.Forms.TextBox textBoxAlterarProfessorID;
    }
}