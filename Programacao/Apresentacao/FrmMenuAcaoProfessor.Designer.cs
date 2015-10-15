namespace Apresentacao
{
    partial class FrmMenuAcaoProfessor
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
            this.labelAcaoProfessorNome = new System.Windows.Forms.Label();
            this.labelAcaoProfessorMatricula = new System.Windows.Forms.Label();
            this.textBoxAcaoProfessorNome = new System.Windows.Forms.TextBox();
            this.textBoxAcaoProfessorMatricula = new System.Windows.Forms.TextBox();
            this.buttonAcaoProfessorConfirmar = new System.Windows.Forms.Button();
            this.buttonAcaoProfessorCancelar = new System.Windows.Forms.Button();
            this.labelAcaoProfessorTelefone = new System.Windows.Forms.Label();
            this.labelAcaoProfessorCO = new System.Windows.Forms.Label();
            this.maskedTextBoxAcaoProfessorTelefone = new System.Windows.Forms.MaskedTextBox();
            this.labelAcaoProfessorID = new System.Windows.Forms.Label();
            this.textBoxAcaoProfessorID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAcaoProfessorNome
            // 
            this.labelAcaoProfessorNome.AutoSize = true;
            this.labelAcaoProfessorNome.Location = new System.Drawing.Point(16, 54);
            this.labelAcaoProfessorNome.Name = "labelAcaoProfessorNome";
            this.labelAcaoProfessorNome.Size = new System.Drawing.Size(45, 13);
            this.labelAcaoProfessorNome.TabIndex = 0;
            this.labelAcaoProfessorNome.Text = "Nome*: ";
            // 
            // labelAcaoProfessorMatricula
            // 
            this.labelAcaoProfessorMatricula.AutoSize = true;
            this.labelAcaoProfessorMatricula.Location = new System.Drawing.Point(16, 91);
            this.labelAcaoProfessorMatricula.Name = "labelAcaoProfessorMatricula";
            this.labelAcaoProfessorMatricula.Size = new System.Drawing.Size(59, 13);
            this.labelAcaoProfessorMatricula.TabIndex = 1;
            this.labelAcaoProfessorMatricula.Text = "Matrícula*:";
            // 
            // textBoxAcaoProfessorNome
            // 
            this.textBoxAcaoProfessorNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoProfessorNome.Location = new System.Drawing.Point(68, 50);
            this.textBoxAcaoProfessorNome.Name = "textBoxAcaoProfessorNome";
            this.textBoxAcaoProfessorNome.Size = new System.Drawing.Size(362, 20);
            this.textBoxAcaoProfessorNome.TabIndex = 6;
            // 
            // textBoxAcaoProfessorMatricula
            // 
            this.textBoxAcaoProfessorMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoProfessorMatricula.Location = new System.Drawing.Point(81, 87);
            this.textBoxAcaoProfessorMatricula.Name = "textBoxAcaoProfessorMatricula";
            this.textBoxAcaoProfessorMatricula.Size = new System.Drawing.Size(84, 20);
            this.textBoxAcaoProfessorMatricula.TabIndex = 7;
            // 
            // buttonAcaoProfessorConfirmar
            // 
            this.buttonAcaoProfessorConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonAcaoProfessorConfirmar.Name = "buttonAcaoProfessorConfirmar";
            this.buttonAcaoProfessorConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoProfessorConfirmar.TabIndex = 11;
            this.buttonAcaoProfessorConfirmar.Text = "Confirmar";
            this.buttonAcaoProfessorConfirmar.UseVisualStyleBackColor = true;
            this.buttonAcaoProfessorConfirmar.Click += new System.EventHandler(this.buttonAcaoProfessorConfirmar_Click);
            // 
            // buttonAcaoProfessorCancelar
            // 
            this.buttonAcaoProfessorCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAcaoProfessorCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonAcaoProfessorCancelar.Name = "buttonAcaoProfessorCancelar";
            this.buttonAcaoProfessorCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoProfessorCancelar.TabIndex = 12;
            this.buttonAcaoProfessorCancelar.Text = "Cancelar";
            this.buttonAcaoProfessorCancelar.UseVisualStyleBackColor = true;
            this.buttonAcaoProfessorCancelar.Click += new System.EventHandler(this.buttonAcaoProfessorCancelar_Click);
            // 
            // labelAcaoProfessorTelefone
            // 
            this.labelAcaoProfessorTelefone.AutoSize = true;
            this.labelAcaoProfessorTelefone.Location = new System.Drawing.Point(171, 91);
            this.labelAcaoProfessorTelefone.Name = "labelAcaoProfessorTelefone";
            this.labelAcaoProfessorTelefone.Size = new System.Drawing.Size(55, 13);
            this.labelAcaoProfessorTelefone.TabIndex = 2;
            this.labelAcaoProfessorTelefone.Text = "Telefone: ";
            // 
            // labelAcaoProfessorCO
            // 
            this.labelAcaoProfessorCO.AutoSize = true;
            this.labelAcaoProfessorCO.Location = new System.Drawing.Point(16, 175);
            this.labelAcaoProfessorCO.Name = "labelAcaoProfessorCO";
            this.labelAcaoProfessorCO.Size = new System.Drawing.Size(210, 13);
            this.labelAcaoProfessorCO.TabIndex = 15;
            this.labelAcaoProfessorCO.Text = "( * ) - Campos de preenchimento obrigatório";
            // 
            // maskedTextBoxAcaoProfessorTelefone
            // 
            this.maskedTextBoxAcaoProfessorTelefone.Location = new System.Drawing.Point(232, 87);
            this.maskedTextBoxAcaoProfessorTelefone.Mask = "(99)999999999";
            this.maskedTextBoxAcaoProfessorTelefone.Name = "maskedTextBoxAcaoProfessorTelefone";
            this.maskedTextBoxAcaoProfessorTelefone.Size = new System.Drawing.Size(85, 20);
            this.maskedTextBoxAcaoProfessorTelefone.TabIndex = 18;
            // 
            // labelAcaoProfessorID
            // 
            this.labelAcaoProfessorID.AutoSize = true;
            this.labelAcaoProfessorID.Location = new System.Drawing.Point(16, 17);
            this.labelAcaoProfessorID.Name = "labelAcaoProfessorID";
            this.labelAcaoProfessorID.Size = new System.Drawing.Size(46, 13);
            this.labelAcaoProfessorID.TabIndex = 24;
            this.labelAcaoProfessorID.Text = "Código: ";
            // 
            // textBoxAcaoProfessorID
            // 
            this.textBoxAcaoProfessorID.Enabled = false;
            this.textBoxAcaoProfessorID.Location = new System.Drawing.Point(68, 14);
            this.textBoxAcaoProfessorID.Name = "textBoxAcaoProfessorID";
            this.textBoxAcaoProfessorID.Size = new System.Drawing.Size(90, 20);
            this.textBoxAcaoProfessorID.TabIndex = 23;
            // 
            // FrmMenuAcaoProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.labelAcaoProfessorID);
            this.Controls.Add(this.textBoxAcaoProfessorID);
            this.Controls.Add(this.maskedTextBoxAcaoProfessorTelefone);
            this.Controls.Add(this.labelAcaoProfessorCO);
            this.Controls.Add(this.buttonAcaoProfessorCancelar);
            this.Controls.Add(this.buttonAcaoProfessorConfirmar);
            this.Controls.Add(this.textBoxAcaoProfessorMatricula);
            this.Controls.Add(this.textBoxAcaoProfessorNome);
            this.Controls.Add(this.labelAcaoProfessorTelefone);
            this.Controls.Add(this.labelAcaoProfessorMatricula);
            this.Controls.Add(this.labelAcaoProfessorNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAcaoProfessor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acao Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAcaoProfessorNome;
        private System.Windows.Forms.Label labelAcaoProfessorMatricula;
        private System.Windows.Forms.TextBox textBoxAcaoProfessorNome;
        private System.Windows.Forms.TextBox textBoxAcaoProfessorMatricula;
        private System.Windows.Forms.Button buttonAcaoProfessorConfirmar;
        private System.Windows.Forms.Button buttonAcaoProfessorCancelar;
        private System.Windows.Forms.Label labelAcaoProfessorTelefone;
        private System.Windows.Forms.Label labelAcaoProfessorCO;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAcaoProfessorTelefone;
        private System.Windows.Forms.Label labelAcaoProfessorID;
        private System.Windows.Forms.TextBox textBoxAcaoProfessorID;
    }
}