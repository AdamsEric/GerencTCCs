namespace Apresentacao
{
    partial class FrmMenuInserirUnidade
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
            this.labelInserirUnidadeNome = new System.Windows.Forms.Label();
            this.labelInserirUnidadeCidade = new System.Windows.Forms.Label();
            this.labelInserirUnidadeEstado = new System.Windows.Forms.Label();
            this.textBoxInserirUnidadeNome = new System.Windows.Forms.TextBox();
            this.buttonInserirUnidadeConfirmar = new System.Windows.Forms.Button();
            this.buttonInserirUnidadeCancelar = new System.Windows.Forms.Button();
            this.textBoxInserirUnidadeCidade = new System.Windows.Forms.TextBox();
            this.textBoxInserirUnidadeEstado = new System.Windows.Forms.TextBox();
            this.textBoxInserirUnidadePais = new System.Windows.Forms.TextBox();
            this.labelInserirUnidadePais = new System.Windows.Forms.Label();
            this.labelMenuInserirCO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInserirUnidadeNome
            // 
            this.labelInserirUnidadeNome.AutoSize = true;
            this.labelInserirUnidadeNome.Location = new System.Drawing.Point(16, 22);
            this.labelInserirUnidadeNome.Name = "labelInserirUnidadeNome";
            this.labelInserirUnidadeNome.Size = new System.Drawing.Size(45, 13);
            this.labelInserirUnidadeNome.TabIndex = 0;
            this.labelInserirUnidadeNome.Text = "Nome*: ";
            // 
            // labelInserirUnidadeCidade
            // 
            this.labelInserirUnidadeCidade.AutoSize = true;
            this.labelInserirUnidadeCidade.Location = new System.Drawing.Point(16, 59);
            this.labelInserirUnidadeCidade.Name = "labelInserirUnidadeCidade";
            this.labelInserirUnidadeCidade.Size = new System.Drawing.Size(50, 13);
            this.labelInserirUnidadeCidade.TabIndex = 1;
            this.labelInserirUnidadeCidade.Text = "Cidade*: ";
            // 
            // labelInserirUnidadeEstado
            // 
            this.labelInserirUnidadeEstado.AutoSize = true;
            this.labelInserirUnidadeEstado.Location = new System.Drawing.Point(332, 59);
            this.labelInserirUnidadeEstado.Name = "labelInserirUnidadeEstado";
            this.labelInserirUnidadeEstado.Size = new System.Drawing.Size(73, 13);
            this.labelInserirUnidadeEstado.TabIndex = 3;
            this.labelInserirUnidadeEstado.Text = "Estado (UF)*: ";
            // 
            // textBoxInserirUnidadeNome
            // 
            this.textBoxInserirUnidadeNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInserirUnidadeNome.Location = new System.Drawing.Point(57, 18);
            this.textBoxInserirUnidadeNome.Name = "textBoxInserirUnidadeNome";
            this.textBoxInserirUnidadeNome.Size = new System.Drawing.Size(373, 20);
            this.textBoxInserirUnidadeNome.TabIndex = 0;
            // 
            // buttonInserirUnidadeConfirmar
            // 
            this.buttonInserirUnidadeConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonInserirUnidadeConfirmar.Name = "buttonInserirUnidadeConfirmar";
            this.buttonInserirUnidadeConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirUnidadeConfirmar.TabIndex = 4;
            this.buttonInserirUnidadeConfirmar.Text = "Confirmar";
            this.buttonInserirUnidadeConfirmar.UseVisualStyleBackColor = true;
            this.buttonInserirUnidadeConfirmar.Click += new System.EventHandler(this.buttonInserirUnidadeConfirmar_Click);
            // 
            // buttonInserirUnidadeCancelar
            // 
            this.buttonInserirUnidadeCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonInserirUnidadeCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonInserirUnidadeCancelar.Name = "buttonInserirUnidadeCancelar";
            this.buttonInserirUnidadeCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirUnidadeCancelar.TabIndex = 5;
            this.buttonInserirUnidadeCancelar.Text = "Cancelar";
            this.buttonInserirUnidadeCancelar.UseVisualStyleBackColor = true;
            this.buttonInserirUnidadeCancelar.Click += new System.EventHandler(this.buttonInserirUnidadeCancelar_Click);
            // 
            // textBoxInserirUnidadeCidade
            // 
            this.textBoxInserirUnidadeCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInserirUnidadeCidade.Location = new System.Drawing.Point(64, 55);
            this.textBoxInserirUnidadeCidade.Name = "textBoxInserirUnidadeCidade";
            this.textBoxInserirUnidadeCidade.Size = new System.Drawing.Size(266, 20);
            this.textBoxInserirUnidadeCidade.TabIndex = 1;
            // 
            // textBoxInserirUnidadeEstado
            // 
            this.textBoxInserirUnidadeEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInserirUnidadeEstado.Location = new System.Drawing.Point(403, 55);
            this.textBoxInserirUnidadeEstado.MaxLength = 2;
            this.textBoxInserirUnidadeEstado.Name = "textBoxInserirUnidadeEstado";
            this.textBoxInserirUnidadeEstado.Size = new System.Drawing.Size(26, 20);
            this.textBoxInserirUnidadeEstado.TabIndex = 2;
            // 
            // textBoxInserirUnidadePais
            // 
            this.textBoxInserirUnidadePais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInserirUnidadePais.Location = new System.Drawing.Point(53, 92);
            this.textBoxInserirUnidadePais.Name = "textBoxInserirUnidadePais";
            this.textBoxInserirUnidadePais.Size = new System.Drawing.Size(277, 20);
            this.textBoxInserirUnidadePais.TabIndex = 3;
            // 
            // labelInserirUnidadePais
            // 
            this.labelInserirUnidadePais.AutoSize = true;
            this.labelInserirUnidadePais.Location = new System.Drawing.Point(16, 96);
            this.labelInserirUnidadePais.Name = "labelInserirUnidadePais";
            this.labelInserirUnidadePais.Size = new System.Drawing.Size(39, 13);
            this.labelInserirUnidadePais.TabIndex = 17;
            this.labelInserirUnidadePais.Text = "País*: ";
            // 
            // labelMenuInserirCO
            // 
            this.labelMenuInserirCO.AutoSize = true;
            this.labelMenuInserirCO.Location = new System.Drawing.Point(16, 180);
            this.labelMenuInserirCO.Name = "labelMenuInserirCO";
            this.labelMenuInserirCO.Size = new System.Drawing.Size(210, 13);
            this.labelMenuInserirCO.TabIndex = 19;
            this.labelMenuInserirCO.Text = "( * ) - Campos de preenchimento obrigatório";
            // 
            // FrmMenuInserirUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.labelMenuInserirCO);
            this.Controls.Add(this.textBoxInserirUnidadePais);
            this.Controls.Add(this.labelInserirUnidadePais);
            this.Controls.Add(this.textBoxInserirUnidadeEstado);
            this.Controls.Add(this.textBoxInserirUnidadeCidade);
            this.Controls.Add(this.buttonInserirUnidadeCancelar);
            this.Controls.Add(this.buttonInserirUnidadeConfirmar);
            this.Controls.Add(this.textBoxInserirUnidadeNome);
            this.Controls.Add(this.labelInserirUnidadeEstado);
            this.Controls.Add(this.labelInserirUnidadeCidade);
            this.Controls.Add(this.labelInserirUnidadeNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuInserirUnidade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Unidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInserirUnidadeNome;
        private System.Windows.Forms.Label labelInserirUnidadeCidade;
        private System.Windows.Forms.Label labelInserirUnidadeEstado;
        private System.Windows.Forms.TextBox textBoxInserirUnidadeNome;
        private System.Windows.Forms.Button buttonInserirUnidadeConfirmar;
        private System.Windows.Forms.Button buttonInserirUnidadeCancelar;
        private System.Windows.Forms.TextBox textBoxInserirUnidadeCidade;
        private System.Windows.Forms.TextBox textBoxInserirUnidadeEstado;
        private System.Windows.Forms.TextBox textBoxInserirUnidadePais;
        private System.Windows.Forms.Label labelInserirUnidadePais;
        private System.Windows.Forms.Label labelMenuInserirCO;
    }
}