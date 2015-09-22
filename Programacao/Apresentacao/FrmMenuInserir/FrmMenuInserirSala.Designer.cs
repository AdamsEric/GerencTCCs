namespace Apresentacao
{
    partial class FrmMenuInserirSala
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
            this.labelInserirSalaNome = new System.Windows.Forms.Label();
            this.textBoxInserirSalaNome = new System.Windows.Forms.TextBox();
            this.buttonInserirSalaConfirmar = new System.Windows.Forms.Button();
            this.buttonInserirSalaCancelar = new System.Windows.Forms.Button();
            this.labelInserirSalaTipo = new System.Windows.Forms.Label();
            this.labelInserirSalaUnidade = new System.Windows.Forms.Label();
            this.comboBoxInserirSalaTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxInserirSalaUnidade = new System.Windows.Forms.ComboBox();
            this.labelInserirSalaDescricao = new System.Windows.Forms.Label();
            this.textBoxInserirSalaDescricao = new System.Windows.Forms.TextBox();
            this.labelMenuInserirCO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInserirSalaNome
            // 
            this.labelInserirSalaNome.AutoSize = true;
            this.labelInserirSalaNome.Location = new System.Drawing.Point(16, 22);
            this.labelInserirSalaNome.Name = "labelInserirSalaNome";
            this.labelInserirSalaNome.Size = new System.Drawing.Size(50, 13);
            this.labelInserirSalaNome.TabIndex = 0;
            this.labelInserirSalaNome.Text = "Código*: ";
            // 
            // textBoxInserirSalaNome
            // 
            this.textBoxInserirSalaNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInserirSalaNome.Location = new System.Drawing.Point(69, 18);
            this.textBoxInserirSalaNome.Name = "textBoxInserirSalaNome";
            this.textBoxInserirSalaNome.Size = new System.Drawing.Size(69, 20);
            this.textBoxInserirSalaNome.TabIndex = 6;
            // 
            // buttonInserirSalaConfirmar
            // 
            this.buttonInserirSalaConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonInserirSalaConfirmar.Name = "buttonInserirSalaConfirmar";
            this.buttonInserirSalaConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirSalaConfirmar.TabIndex = 11;
            this.buttonInserirSalaConfirmar.Text = "Confirmar";
            this.buttonInserirSalaConfirmar.UseVisualStyleBackColor = true;
            this.buttonInserirSalaConfirmar.Click += new System.EventHandler(this.buttonInserirSalaConfirmar_Click);
            // 
            // buttonInserirSalaCancelar
            // 
            this.buttonInserirSalaCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonInserirSalaCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonInserirSalaCancelar.Name = "buttonInserirSalaCancelar";
            this.buttonInserirSalaCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirSalaCancelar.TabIndex = 12;
            this.buttonInserirSalaCancelar.Text = "Cancelar";
            this.buttonInserirSalaCancelar.UseVisualStyleBackColor = true;
            this.buttonInserirSalaCancelar.Click += new System.EventHandler(this.buttonInserirSalaCancelar_Click);
            // 
            // labelInserirSalaTipo
            // 
            this.labelInserirSalaTipo.AutoSize = true;
            this.labelInserirSalaTipo.Location = new System.Drawing.Point(147, 22);
            this.labelInserirSalaTipo.Name = "labelInserirSalaTipo";
            this.labelInserirSalaTipo.Size = new System.Drawing.Size(38, 13);
            this.labelInserirSalaTipo.TabIndex = 17;
            this.labelInserirSalaTipo.Text = "Tipo*: ";
            // 
            // labelInserirSalaUnidade
            // 
            this.labelInserirSalaUnidade.AutoSize = true;
            this.labelInserirSalaUnidade.Location = new System.Drawing.Point(16, 96);
            this.labelInserirSalaUnidade.Name = "labelInserirSalaUnidade";
            this.labelInserirSalaUnidade.Size = new System.Drawing.Size(54, 13);
            this.labelInserirSalaUnidade.TabIndex = 19;
            this.labelInserirSalaUnidade.Text = "Unidade*:";
            // 
            // comboBoxInserirSalaTipo
            // 
            this.comboBoxInserirSalaTipo.FormattingEnabled = true;
            this.comboBoxInserirSalaTipo.Location = new System.Drawing.Point(191, 18);
            this.comboBoxInserirSalaTipo.Name = "comboBoxInserirSalaTipo";
            this.comboBoxInserirSalaTipo.Size = new System.Drawing.Size(118, 21);
            this.comboBoxInserirSalaTipo.TabIndex = 20;
            // 
            // comboBoxInserirSalaUnidade
            // 
            this.comboBoxInserirSalaUnidade.FormattingEnabled = true;
            this.comboBoxInserirSalaUnidade.Location = new System.Drawing.Point(72, 92);
            this.comboBoxInserirSalaUnidade.Name = "comboBoxInserirSalaUnidade";
            this.comboBoxInserirSalaUnidade.Size = new System.Drawing.Size(358, 21);
            this.comboBoxInserirSalaUnidade.TabIndex = 21;
            // 
            // labelInserirSalaDescricao
            // 
            this.labelInserirSalaDescricao.AutoSize = true;
            this.labelInserirSalaDescricao.Location = new System.Drawing.Point(16, 59);
            this.labelInserirSalaDescricao.Name = "labelInserirSalaDescricao";
            this.labelInserirSalaDescricao.Size = new System.Drawing.Size(61, 13);
            this.labelInserirSalaDescricao.TabIndex = 22;
            this.labelInserirSalaDescricao.Text = "Descrição: ";
            // 
            // textBoxInserirSalaDescricao
            // 
            this.textBoxInserirSalaDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInserirSalaDescricao.Location = new System.Drawing.Point(83, 55);
            this.textBoxInserirSalaDescricao.Name = "textBoxInserirSalaDescricao";
            this.textBoxInserirSalaDescricao.Size = new System.Drawing.Size(347, 20);
            this.textBoxInserirSalaDescricao.TabIndex = 23;
            // 
            // labelMenuInserirCO
            // 
            this.labelMenuInserirCO.AutoSize = true;
            this.labelMenuInserirCO.Location = new System.Drawing.Point(16, 180);
            this.labelMenuInserirCO.Name = "labelMenuInserirCO";
            this.labelMenuInserirCO.Size = new System.Drawing.Size(210, 13);
            this.labelMenuInserirCO.TabIndex = 24;
            this.labelMenuInserirCO.Text = "( * ) - Campos de preenchimento obrigatório";
            // 
            // FrmMenuInserirSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.labelMenuInserirCO);
            this.Controls.Add(this.textBoxInserirSalaDescricao);
            this.Controls.Add(this.labelInserirSalaDescricao);
            this.Controls.Add(this.comboBoxInserirSalaUnidade);
            this.Controls.Add(this.comboBoxInserirSalaTipo);
            this.Controls.Add(this.labelInserirSalaUnidade);
            this.Controls.Add(this.labelInserirSalaTipo);
            this.Controls.Add(this.buttonInserirSalaCancelar);
            this.Controls.Add(this.buttonInserirSalaConfirmar);
            this.Controls.Add(this.textBoxInserirSalaNome);
            this.Controls.Add(this.labelInserirSalaNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuInserirSala";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Sala";
            this.Load += new System.EventHandler(this.FrmMenuInserirSala_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInserirSalaNome;
        private System.Windows.Forms.TextBox textBoxInserirSalaNome;
        private System.Windows.Forms.Button buttonInserirSalaConfirmar;
        private System.Windows.Forms.Button buttonInserirSalaCancelar;
        private System.Windows.Forms.Label labelInserirSalaTipo;
        private System.Windows.Forms.Label labelInserirSalaUnidade;
        private System.Windows.Forms.ComboBox comboBoxInserirSalaTipo;
        private System.Windows.Forms.ComboBox comboBoxInserirSalaUnidade;
        private System.Windows.Forms.Label labelInserirSalaDescricao;
        private System.Windows.Forms.TextBox textBoxInserirSalaDescricao;
        private System.Windows.Forms.Label labelMenuInserirCO;
    }
}