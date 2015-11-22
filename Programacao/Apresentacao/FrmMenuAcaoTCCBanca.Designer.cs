namespace Apresentacao
{
    partial class FrmMenuAcaoBanca
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
            this.labelAcaoBancaNome = new System.Windows.Forms.Label();
            this.labelAcaoBancaCidade = new System.Windows.Forms.Label();
            this.labelAcaoBancaEstado = new System.Windows.Forms.Label();
            this.textBoxAcaoBancaNome = new System.Windows.Forms.TextBox();
            this.buttonAcaoBancaConfirmar = new System.Windows.Forms.Button();
            this.buttonAcaoBancaCancelar = new System.Windows.Forms.Button();
            this.textBoxAcaoBancaCidade = new System.Windows.Forms.TextBox();
            this.textBoxAcaoBancaEstado = new System.Windows.Forms.TextBox();
            this.textBoxAcaoBancaPais = new System.Windows.Forms.TextBox();
            this.labelAcaoBancaPais = new System.Windows.Forms.Label();
            this.labelAcaoBancaCO = new System.Windows.Forms.Label();
            this.textBoxAcaoBancaID = new System.Windows.Forms.TextBox();
            this.labelAcaoBancaID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAcaoBancaNome
            // 
            this.labelAcaoBancaNome.AutoSize = true;
            this.labelAcaoBancaNome.Location = new System.Drawing.Point(16, 54);
            this.labelAcaoBancaNome.Name = "labelAcaoBancaNome";
            this.labelAcaoBancaNome.Size = new System.Drawing.Size(45, 13);
            this.labelAcaoBancaNome.TabIndex = 0;
            this.labelAcaoBancaNome.Text = "Nome*: ";
            // 
            // labelAcaoBancaCidade
            // 
            this.labelAcaoBancaCidade.AutoSize = true;
            this.labelAcaoBancaCidade.Location = new System.Drawing.Point(16, 91);
            this.labelAcaoBancaCidade.Name = "labelAcaoBancaCidade";
            this.labelAcaoBancaCidade.Size = new System.Drawing.Size(50, 13);
            this.labelAcaoBancaCidade.TabIndex = 1;
            this.labelAcaoBancaCidade.Text = "Cidade*: ";
            // 
            // labelAcaoBancaEstado
            // 
            this.labelAcaoBancaEstado.AutoSize = true;
            this.labelAcaoBancaEstado.Location = new System.Drawing.Point(336, 91);
            this.labelAcaoBancaEstado.Name = "labelAcaoBancaEstado";
            this.labelAcaoBancaEstado.Size = new System.Drawing.Size(73, 13);
            this.labelAcaoBancaEstado.TabIndex = 3;
            this.labelAcaoBancaEstado.Text = "Estado (UF)*: ";
            // 
            // textBoxAcaoBancaNome
            // 
            this.textBoxAcaoBancaNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoBancaNome.Location = new System.Drawing.Point(64, 50);
            this.textBoxAcaoBancaNome.Name = "textBoxAcaoBancaNome";
            this.textBoxAcaoBancaNome.Size = new System.Drawing.Size(373, 20);
            this.textBoxAcaoBancaNome.TabIndex = 1;
            // 
            // buttonAcaoBancaConfirmar
            // 
            this.buttonAcaoBancaConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonAcaoBancaConfirmar.Name = "buttonAcaoBancaConfirmar";
            this.buttonAcaoBancaConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoBancaConfirmar.TabIndex = 5;
            this.buttonAcaoBancaConfirmar.Text = "Confirmar";
            this.buttonAcaoBancaConfirmar.UseVisualStyleBackColor = true;
            this.buttonAcaoBancaConfirmar.Click += new System.EventHandler(this.buttonAcaoBancaConfirmar_Click);
            // 
            // buttonAcaoBancaCancelar
            // 
            this.buttonAcaoBancaCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAcaoBancaCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonAcaoBancaCancelar.Name = "buttonAcaoBancaCancelar";
            this.buttonAcaoBancaCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoBancaCancelar.TabIndex = 6;
            this.buttonAcaoBancaCancelar.Text = "Cancelar";
            this.buttonAcaoBancaCancelar.UseVisualStyleBackColor = true;
            this.buttonAcaoBancaCancelar.Click += new System.EventHandler(this.buttonAcaoBancaCancelar_Click);
            // 
            // textBoxAcaoBancaCidade
            // 
            this.textBoxAcaoBancaCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoBancaCidade.Location = new System.Drawing.Point(64, 87);
            this.textBoxAcaoBancaCidade.Name = "textBoxAcaoBancaCidade";
            this.textBoxAcaoBancaCidade.Size = new System.Drawing.Size(266, 20);
            this.textBoxAcaoBancaCidade.TabIndex = 2;
            // 
            // textBoxAcaoBancaEstado
            // 
            this.textBoxAcaoBancaEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoBancaEstado.Location = new System.Drawing.Point(416, 87);
            this.textBoxAcaoBancaEstado.MaxLength = 2;
            this.textBoxAcaoBancaEstado.Name = "textBoxAcaoBancaEstado";
            this.textBoxAcaoBancaEstado.Size = new System.Drawing.Size(26, 20);
            this.textBoxAcaoBancaEstado.TabIndex = 3;
            // 
            // textBoxAcaoBancaPais
            // 
            this.textBoxAcaoBancaPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoBancaPais.Location = new System.Drawing.Point(64, 124);
            this.textBoxAcaoBancaPais.Name = "textBoxAcaoBancaPais";
            this.textBoxAcaoBancaPais.Size = new System.Drawing.Size(277, 20);
            this.textBoxAcaoBancaPais.TabIndex = 4;
            // 
            // labelAcaoBancaPais
            // 
            this.labelAcaoBancaPais.AutoSize = true;
            this.labelAcaoBancaPais.Location = new System.Drawing.Point(16, 128);
            this.labelAcaoBancaPais.Name = "labelAcaoBancaPais";
            this.labelAcaoBancaPais.Size = new System.Drawing.Size(39, 13);
            this.labelAcaoBancaPais.TabIndex = 17;
            this.labelAcaoBancaPais.Text = "País*: ";
            // 
            // labelAcaoBancaCO
            // 
            this.labelAcaoBancaCO.AutoSize = true;
            this.labelAcaoBancaCO.Location = new System.Drawing.Point(16, 175);
            this.labelAcaoBancaCO.Name = "labelAcaoBancaCO";
            this.labelAcaoBancaCO.Size = new System.Drawing.Size(210, 13);
            this.labelAcaoBancaCO.TabIndex = 20;
            this.labelAcaoBancaCO.Text = "( * ) - Campos de preenchimento obrigatório";
            // 
            // textBoxAcaoBancaID
            // 
            this.textBoxAcaoBancaID.Enabled = false;
            this.textBoxAcaoBancaID.Location = new System.Drawing.Point(64, 13);
            this.textBoxAcaoBancaID.Name = "textBoxAcaoBancaID";
            this.textBoxAcaoBancaID.ReadOnly = true;
            this.textBoxAcaoBancaID.Size = new System.Drawing.Size(90, 20);
            this.textBoxAcaoBancaID.TabIndex = 0;
            // 
            // labelAcaoBancaID
            // 
            this.labelAcaoBancaID.AutoSize = true;
            this.labelAcaoBancaID.Location = new System.Drawing.Point(16, 17);
            this.labelAcaoBancaID.Name = "labelAcaoBancaID";
            this.labelAcaoBancaID.Size = new System.Drawing.Size(46, 13);
            this.labelAcaoBancaID.TabIndex = 22;
            this.labelAcaoBancaID.Text = "Código: ";
            // 
            // FrmMenuAcaoBanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.labelAcaoBancaID);
            this.Controls.Add(this.textBoxAcaoBancaID);
            this.Controls.Add(this.labelAcaoBancaCO);
            this.Controls.Add(this.textBoxAcaoBancaPais);
            this.Controls.Add(this.labelAcaoBancaPais);
            this.Controls.Add(this.textBoxAcaoBancaEstado);
            this.Controls.Add(this.textBoxAcaoBancaCidade);
            this.Controls.Add(this.buttonAcaoBancaCancelar);
            this.Controls.Add(this.buttonAcaoBancaConfirmar);
            this.Controls.Add(this.textBoxAcaoBancaNome);
            this.Controls.Add(this.labelAcaoBancaEstado);
            this.Controls.Add(this.labelAcaoBancaCidade);
            this.Controls.Add(this.labelAcaoBancaNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAcaoBanca";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acao Banca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAcaoBancaNome;
        private System.Windows.Forms.Label labelAcaoBancaCidade;
        private System.Windows.Forms.Label labelAcaoBancaEstado;
        private System.Windows.Forms.TextBox textBoxAcaoBancaNome;
        private System.Windows.Forms.Button buttonAcaoBancaConfirmar;
        private System.Windows.Forms.Button buttonAcaoBancaCancelar;
        private System.Windows.Forms.TextBox textBoxAcaoBancaCidade;
        private System.Windows.Forms.TextBox textBoxAcaoBancaEstado;
        private System.Windows.Forms.TextBox textBoxAcaoBancaPais;
        private System.Windows.Forms.Label labelAcaoBancaPais;
        private System.Windows.Forms.Label labelAcaoBancaCO;
        private System.Windows.Forms.TextBox textBoxAcaoBancaID;
        private System.Windows.Forms.Label labelAcaoBancaID;
    }
}