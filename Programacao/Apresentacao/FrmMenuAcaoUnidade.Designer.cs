namespace Apresentacao
{
    partial class FrmMenuAcaoUnidade
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
            this.labelAcaoUnidadeNome = new System.Windows.Forms.Label();
            this.labelAcaoUnidadeCidade = new System.Windows.Forms.Label();
            this.labelAcaoUnidadeEstado = new System.Windows.Forms.Label();
            this.textBoxAcaoUnidadeNome = new System.Windows.Forms.TextBox();
            this.buttonAcaoUnidadeConfirmar = new System.Windows.Forms.Button();
            this.buttonAcaoUnidadeCancelar = new System.Windows.Forms.Button();
            this.textBoxAcaoUnidadeCidade = new System.Windows.Forms.TextBox();
            this.textBoxAcaoUnidadeEstado = new System.Windows.Forms.TextBox();
            this.textBoxAcaoUnidadePais = new System.Windows.Forms.TextBox();
            this.labelAcaoUnidadePais = new System.Windows.Forms.Label();
            this.labelAcaoUnidadeCO = new System.Windows.Forms.Label();
            this.textBoxAcaoUnidadeID = new System.Windows.Forms.TextBox();
            this.labelAcaoUnidadeID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAcaoUnidadeNome
            // 
            this.labelAcaoUnidadeNome.AutoSize = true;
            this.labelAcaoUnidadeNome.Location = new System.Drawing.Point(16, 54);
            this.labelAcaoUnidadeNome.Name = "labelAcaoUnidadeNome";
            this.labelAcaoUnidadeNome.Size = new System.Drawing.Size(45, 13);
            this.labelAcaoUnidadeNome.TabIndex = 0;
            this.labelAcaoUnidadeNome.Text = "Nome*: ";
            // 
            // labelAcaoUnidadeCidade
            // 
            this.labelAcaoUnidadeCidade.AutoSize = true;
            this.labelAcaoUnidadeCidade.Location = new System.Drawing.Point(16, 91);
            this.labelAcaoUnidadeCidade.Name = "labelAcaoUnidadeCidade";
            this.labelAcaoUnidadeCidade.Size = new System.Drawing.Size(50, 13);
            this.labelAcaoUnidadeCidade.TabIndex = 1;
            this.labelAcaoUnidadeCidade.Text = "Cidade*: ";
            // 
            // labelAcaoUnidadeEstado
            // 
            this.labelAcaoUnidadeEstado.AutoSize = true;
            this.labelAcaoUnidadeEstado.Location = new System.Drawing.Point(336, 91);
            this.labelAcaoUnidadeEstado.Name = "labelAcaoUnidadeEstado";
            this.labelAcaoUnidadeEstado.Size = new System.Drawing.Size(73, 13);
            this.labelAcaoUnidadeEstado.TabIndex = 3;
            this.labelAcaoUnidadeEstado.Text = "Estado (UF)*: ";
            // 
            // textBoxAcaoUnidadeNome
            // 
            this.textBoxAcaoUnidadeNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoUnidadeNome.Location = new System.Drawing.Point(64, 50);
            this.textBoxAcaoUnidadeNome.Name = "textBoxAcaoUnidadeNome";
            this.textBoxAcaoUnidadeNome.Size = new System.Drawing.Size(373, 20);
            this.textBoxAcaoUnidadeNome.TabIndex = 1;
            this.textBoxAcaoUnidadeNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAcaoUnidadeNome_KeyPress);
            // 
            // buttonAcaoUnidadeConfirmar
            // 
            this.buttonAcaoUnidadeConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonAcaoUnidadeConfirmar.Name = "buttonAcaoUnidadeConfirmar";
            this.buttonAcaoUnidadeConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoUnidadeConfirmar.TabIndex = 5;
            this.buttonAcaoUnidadeConfirmar.Text = "Confirmar";
            this.buttonAcaoUnidadeConfirmar.UseVisualStyleBackColor = true;
            this.buttonAcaoUnidadeConfirmar.Click += new System.EventHandler(this.buttonAcaoUnidadeConfirmar_Click);
            // 
            // buttonAcaoUnidadeCancelar
            // 
            this.buttonAcaoUnidadeCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAcaoUnidadeCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonAcaoUnidadeCancelar.Name = "buttonAcaoUnidadeCancelar";
            this.buttonAcaoUnidadeCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonAcaoUnidadeCancelar.TabIndex = 6;
            this.buttonAcaoUnidadeCancelar.Text = "Cancelar";
            this.buttonAcaoUnidadeCancelar.UseVisualStyleBackColor = true;
            this.buttonAcaoUnidadeCancelar.Click += new System.EventHandler(this.buttonAcaoUnidadeCancelar_Click);
            // 
            // textBoxAcaoUnidadeCidade
            // 
            this.textBoxAcaoUnidadeCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoUnidadeCidade.Location = new System.Drawing.Point(64, 87);
            this.textBoxAcaoUnidadeCidade.Name = "textBoxAcaoUnidadeCidade";
            this.textBoxAcaoUnidadeCidade.Size = new System.Drawing.Size(266, 20);
            this.textBoxAcaoUnidadeCidade.TabIndex = 2;
            this.textBoxAcaoUnidadeCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAcaoUnidadeCidade_KeyPress);
            // 
            // textBoxAcaoUnidadeEstado
            // 
            this.textBoxAcaoUnidadeEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoUnidadeEstado.Location = new System.Drawing.Point(416, 87);
            this.textBoxAcaoUnidadeEstado.MaxLength = 2;
            this.textBoxAcaoUnidadeEstado.Name = "textBoxAcaoUnidadeEstado";
            this.textBoxAcaoUnidadeEstado.Size = new System.Drawing.Size(26, 20);
            this.textBoxAcaoUnidadeEstado.TabIndex = 3;
            this.textBoxAcaoUnidadeEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAcaoUnidadeEstado_KeyPress);
            // 
            // textBoxAcaoUnidadePais
            // 
            this.textBoxAcaoUnidadePais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAcaoUnidadePais.Location = new System.Drawing.Point(64, 124);
            this.textBoxAcaoUnidadePais.Name = "textBoxAcaoUnidadePais";
            this.textBoxAcaoUnidadePais.Size = new System.Drawing.Size(277, 20);
            this.textBoxAcaoUnidadePais.TabIndex = 4;
            this.textBoxAcaoUnidadePais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAcaoUnidadePais_KeyPress);
            // 
            // labelAcaoUnidadePais
            // 
            this.labelAcaoUnidadePais.AutoSize = true;
            this.labelAcaoUnidadePais.Location = new System.Drawing.Point(16, 128);
            this.labelAcaoUnidadePais.Name = "labelAcaoUnidadePais";
            this.labelAcaoUnidadePais.Size = new System.Drawing.Size(39, 13);
            this.labelAcaoUnidadePais.TabIndex = 17;
            this.labelAcaoUnidadePais.Text = "País*: ";
            // 
            // labelAcaoUnidadeCO
            // 
            this.labelAcaoUnidadeCO.AutoSize = true;
            this.labelAcaoUnidadeCO.Location = new System.Drawing.Point(16, 175);
            this.labelAcaoUnidadeCO.Name = "labelAcaoUnidadeCO";
            this.labelAcaoUnidadeCO.Size = new System.Drawing.Size(210, 13);
            this.labelAcaoUnidadeCO.TabIndex = 20;
            this.labelAcaoUnidadeCO.Text = "( * ) - Campos de preenchimento obrigatório";
            // 
            // textBoxAcaoUnidadeID
            // 
            this.textBoxAcaoUnidadeID.Enabled = false;
            this.textBoxAcaoUnidadeID.Location = new System.Drawing.Point(64, 13);
            this.textBoxAcaoUnidadeID.Name = "textBoxAcaoUnidadeID";
            this.textBoxAcaoUnidadeID.ReadOnly = true;
            this.textBoxAcaoUnidadeID.Size = new System.Drawing.Size(90, 20);
            this.textBoxAcaoUnidadeID.TabIndex = 0;
            // 
            // labelAcaoUnidadeID
            // 
            this.labelAcaoUnidadeID.AutoSize = true;
            this.labelAcaoUnidadeID.Location = new System.Drawing.Point(16, 17);
            this.labelAcaoUnidadeID.Name = "labelAcaoUnidadeID";
            this.labelAcaoUnidadeID.Size = new System.Drawing.Size(46, 13);
            this.labelAcaoUnidadeID.TabIndex = 22;
            this.labelAcaoUnidadeID.Text = "Código: ";
            // 
            // FrmMenuAcaoUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.labelAcaoUnidadeID);
            this.Controls.Add(this.textBoxAcaoUnidadeID);
            this.Controls.Add(this.labelAcaoUnidadeCO);
            this.Controls.Add(this.textBoxAcaoUnidadePais);
            this.Controls.Add(this.labelAcaoUnidadePais);
            this.Controls.Add(this.textBoxAcaoUnidadeEstado);
            this.Controls.Add(this.textBoxAcaoUnidadeCidade);
            this.Controls.Add(this.buttonAcaoUnidadeCancelar);
            this.Controls.Add(this.buttonAcaoUnidadeConfirmar);
            this.Controls.Add(this.textBoxAcaoUnidadeNome);
            this.Controls.Add(this.labelAcaoUnidadeEstado);
            this.Controls.Add(this.labelAcaoUnidadeCidade);
            this.Controls.Add(this.labelAcaoUnidadeNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAcaoUnidade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acao Unidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAcaoUnidadeNome;
        private System.Windows.Forms.Label labelAcaoUnidadeCidade;
        private System.Windows.Forms.Label labelAcaoUnidadeEstado;
        private System.Windows.Forms.TextBox textBoxAcaoUnidadeNome;
        private System.Windows.Forms.Button buttonAcaoUnidadeConfirmar;
        private System.Windows.Forms.Button buttonAcaoUnidadeCancelar;
        private System.Windows.Forms.TextBox textBoxAcaoUnidadeCidade;
        private System.Windows.Forms.TextBox textBoxAcaoUnidadeEstado;
        private System.Windows.Forms.TextBox textBoxAcaoUnidadePais;
        private System.Windows.Forms.Label labelAcaoUnidadePais;
        private System.Windows.Forms.Label labelAcaoUnidadeCO;
        private System.Windows.Forms.TextBox textBoxAcaoUnidadeID;
        private System.Windows.Forms.Label labelAcaoUnidadeID;
    }
}