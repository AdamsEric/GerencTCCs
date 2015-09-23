namespace Apresentacao
{
    partial class FrmMenuAlterarUnidade
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
            this.labelAlterarUnidadeNome = new System.Windows.Forms.Label();
            this.labelAlterarUnidadeCidade = new System.Windows.Forms.Label();
            this.labelAlterarUnidadeEstado = new System.Windows.Forms.Label();
            this.textBoxAlterarUnidadeNome = new System.Windows.Forms.TextBox();
            this.buttonAlterarUnidadeConfirmar = new System.Windows.Forms.Button();
            this.buttonAlterarUnidadeCancelar = new System.Windows.Forms.Button();
            this.textBoxAlterarUnidadeCidade = new System.Windows.Forms.TextBox();
            this.textBoxAlterarUnidadeEstado = new System.Windows.Forms.TextBox();
            this.textBoxAlterarUnidadePais = new System.Windows.Forms.TextBox();
            this.labelAlterarUnidadePais = new System.Windows.Forms.Label();
            this.labelMenuInserirCO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAlterarUnidadeNome
            // 
            this.labelAlterarUnidadeNome.AutoSize = true;
            this.labelAlterarUnidadeNome.Location = new System.Drawing.Point(16, 22);
            this.labelAlterarUnidadeNome.Name = "labelAlterarUnidadeNome";
            this.labelAlterarUnidadeNome.Size = new System.Drawing.Size(45, 13);
            this.labelAlterarUnidadeNome.TabIndex = 0;
            this.labelAlterarUnidadeNome.Text = "Nome*: ";
            // 
            // labelAlterarUnidadeCidade
            // 
            this.labelAlterarUnidadeCidade.AutoSize = true;
            this.labelAlterarUnidadeCidade.Location = new System.Drawing.Point(16, 59);
            this.labelAlterarUnidadeCidade.Name = "labelAlterarUnidadeCidade";
            this.labelAlterarUnidadeCidade.Size = new System.Drawing.Size(50, 13);
            this.labelAlterarUnidadeCidade.TabIndex = 1;
            this.labelAlterarUnidadeCidade.Text = "Cidade*: ";
            // 
            // labelAlterarUnidadeEstado
            // 
            this.labelAlterarUnidadeEstado.AutoSize = true;
            this.labelAlterarUnidadeEstado.Location = new System.Drawing.Point(332, 59);
            this.labelAlterarUnidadeEstado.Name = "labelAlterarUnidadeEstado";
            this.labelAlterarUnidadeEstado.Size = new System.Drawing.Size(73, 13);
            this.labelAlterarUnidadeEstado.TabIndex = 3;
            this.labelAlterarUnidadeEstado.Text = "Estado (UF)*: ";
            // 
            // textBoxAlterarUnidadeNome
            // 
            this.textBoxAlterarUnidadeNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAlterarUnidadeNome.Location = new System.Drawing.Point(57, 18);
            this.textBoxAlterarUnidadeNome.Name = "textBoxAlterarUnidadeNome";
            this.textBoxAlterarUnidadeNome.Size = new System.Drawing.Size(373, 20);
            this.textBoxAlterarUnidadeNome.TabIndex = 6;
            // 
            // buttonAlterarUnidadeConfirmar
            // 
            this.buttonAlterarUnidadeConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonAlterarUnidadeConfirmar.Name = "buttonAlterarUnidadeConfirmar";
            this.buttonAlterarUnidadeConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarUnidadeConfirmar.TabIndex = 11;
            this.buttonAlterarUnidadeConfirmar.Text = "Confirmar";
            this.buttonAlterarUnidadeConfirmar.UseVisualStyleBackColor = true;
            this.buttonAlterarUnidadeConfirmar.Click += new System.EventHandler(this.buttonAlterarUnidadeConfirmar_Click);
            // 
            // buttonAlterarUnidadeCancelar
            // 
            this.buttonAlterarUnidadeCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAlterarUnidadeCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonAlterarUnidadeCancelar.Name = "buttonAlterarUnidadeCancelar";
            this.buttonAlterarUnidadeCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarUnidadeCancelar.TabIndex = 12;
            this.buttonAlterarUnidadeCancelar.Text = "Cancelar";
            this.buttonAlterarUnidadeCancelar.UseVisualStyleBackColor = true;
            this.buttonAlterarUnidadeCancelar.Click += new System.EventHandler(this.buttonAlterarUnidadeCancelar_Click);
            // 
            // textBoxAlterarUnidadeCidade
            // 
            this.textBoxAlterarUnidadeCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAlterarUnidadeCidade.Location = new System.Drawing.Point(64, 55);
            this.textBoxAlterarUnidadeCidade.Name = "textBoxAlterarUnidadeCidade";
            this.textBoxAlterarUnidadeCidade.Size = new System.Drawing.Size(266, 20);
            this.textBoxAlterarUnidadeCidade.TabIndex = 15;
            // 
            // textBoxAlterarUnidadeEstado
            // 
            this.textBoxAlterarUnidadeEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAlterarUnidadeEstado.Location = new System.Drawing.Point(403, 55);
            this.textBoxAlterarUnidadeEstado.MaxLength = 2;
            this.textBoxAlterarUnidadeEstado.Name = "textBoxAlterarUnidadeEstado";
            this.textBoxAlterarUnidadeEstado.Size = new System.Drawing.Size(26, 20);
            this.textBoxAlterarUnidadeEstado.TabIndex = 16;
            // 
            // textBoxAlterarUnidadePais
            // 
            this.textBoxAlterarUnidadePais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAlterarUnidadePais.Location = new System.Drawing.Point(53, 92);
            this.textBoxAlterarUnidadePais.Name = "textBoxAlterarUnidadePais";
            this.textBoxAlterarUnidadePais.Size = new System.Drawing.Size(277, 20);
            this.textBoxAlterarUnidadePais.TabIndex = 18;
            // 
            // labelAlterarUnidadePais
            // 
            this.labelAlterarUnidadePais.AutoSize = true;
            this.labelAlterarUnidadePais.Location = new System.Drawing.Point(16, 96);
            this.labelAlterarUnidadePais.Name = "labelAlterarUnidadePais";
            this.labelAlterarUnidadePais.Size = new System.Drawing.Size(39, 13);
            this.labelAlterarUnidadePais.TabIndex = 17;
            this.labelAlterarUnidadePais.Text = "País*: ";
            // 
            // labelMenuInserirCO
            // 
            this.labelMenuInserirCO.AutoSize = true;
            this.labelMenuInserirCO.Location = new System.Drawing.Point(16, 180);
            this.labelMenuInserirCO.Name = "labelMenuInserirCO";
            this.labelMenuInserirCO.Size = new System.Drawing.Size(210, 13);
            this.labelMenuInserirCO.TabIndex = 20;
            this.labelMenuInserirCO.Text = "( * ) - Campos de preenchimento obrigatório";
            // 
            // FrmMenuAlterarUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.labelMenuInserirCO);
            this.Controls.Add(this.textBoxAlterarUnidadePais);
            this.Controls.Add(this.labelAlterarUnidadePais);
            this.Controls.Add(this.textBoxAlterarUnidadeEstado);
            this.Controls.Add(this.textBoxAlterarUnidadeCidade);
            this.Controls.Add(this.buttonAlterarUnidadeCancelar);
            this.Controls.Add(this.buttonAlterarUnidadeConfirmar);
            this.Controls.Add(this.textBoxAlterarUnidadeNome);
            this.Controls.Add(this.labelAlterarUnidadeEstado);
            this.Controls.Add(this.labelAlterarUnidadeCidade);
            this.Controls.Add(this.labelAlterarUnidadeNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAlterarUnidade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Unidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlterarUnidadeNome;
        private System.Windows.Forms.Label labelAlterarUnidadeCidade;
        private System.Windows.Forms.Label labelAlterarUnidadeEstado;
        private System.Windows.Forms.TextBox textBoxAlterarUnidadeNome;
        private System.Windows.Forms.Button buttonAlterarUnidadeConfirmar;
        private System.Windows.Forms.Button buttonAlterarUnidadeCancelar;
        private System.Windows.Forms.TextBox textBoxAlterarUnidadeCidade;
        private System.Windows.Forms.TextBox textBoxAlterarUnidadeEstado;
        private System.Windows.Forms.TextBox textBoxAlterarUnidadePais;
        private System.Windows.Forms.Label labelAlterarUnidadePais;
        private System.Windows.Forms.Label labelMenuInserirCO;
    }
}