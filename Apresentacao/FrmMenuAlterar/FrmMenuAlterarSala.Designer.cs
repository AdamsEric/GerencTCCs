namespace Apresentacao
{
    partial class FrmMenuAlterarSala
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
            this.labelAlterarSalaNome = new System.Windows.Forms.Label();
            this.textBoxAlterarSalaNome = new System.Windows.Forms.TextBox();
            this.buttonAlterarSalaConfirmar = new System.Windows.Forms.Button();
            this.buttonAlterarSalaCancelar = new System.Windows.Forms.Button();
            this.labelAlterarSalaTipo = new System.Windows.Forms.Label();
            this.labelAlterarSalaUnidade = new System.Windows.Forms.Label();
            this.comboBoxAlterarSalaTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxAlterarSalaUnidade = new System.Windows.Forms.ComboBox();
            this.labelAlterarSalaDescricao = new System.Windows.Forms.Label();
            this.textBoxAlterarSalaDescricao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAlterarSalaNome
            // 
            this.labelAlterarSalaNome.AutoSize = true;
            this.labelAlterarSalaNome.Location = new System.Drawing.Point(16, 22);
            this.labelAlterarSalaNome.Name = "labelAlterarSalaNome";
            this.labelAlterarSalaNome.Size = new System.Drawing.Size(46, 13);
            this.labelAlterarSalaNome.TabIndex = 0;
            this.labelAlterarSalaNome.Text = "Código: ";
            // 
            // textBoxAlterarSalaNome
            // 
            this.textBoxAlterarSalaNome.Location = new System.Drawing.Point(59, 18);
            this.textBoxAlterarSalaNome.Name = "textBoxAlterarSalaNome";
            this.textBoxAlterarSalaNome.Size = new System.Drawing.Size(38, 20);
            this.textBoxAlterarSalaNome.TabIndex = 6;
            // 
            // buttonAlterarSalaConfirmar
            // 
            this.buttonAlterarSalaConfirmar.Location = new System.Drawing.Point(259, 170);
            this.buttonAlterarSalaConfirmar.Name = "buttonAlterarSalaConfirmar";
            this.buttonAlterarSalaConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarSalaConfirmar.TabIndex = 11;
            this.buttonAlterarSalaConfirmar.Text = "Confirmar";
            this.buttonAlterarSalaConfirmar.UseVisualStyleBackColor = true;
            this.buttonAlterarSalaConfirmar.Click += new System.EventHandler(this.buttonAlterarSalaConfirmar_Click);
            // 
            // buttonAlterarSalaCancelar
            // 
            this.buttonAlterarSalaCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAlterarSalaCancelar.Location = new System.Drawing.Point(355, 170);
            this.buttonAlterarSalaCancelar.Name = "buttonAlterarSalaCancelar";
            this.buttonAlterarSalaCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarSalaCancelar.TabIndex = 12;
            this.buttonAlterarSalaCancelar.Text = "Cancelar";
            this.buttonAlterarSalaCancelar.UseVisualStyleBackColor = true;
            this.buttonAlterarSalaCancelar.Click += new System.EventHandler(this.buttonAlterarSalaCancelar_Click);
            // 
            // labelAlterarSalaTipo
            // 
            this.labelAlterarSalaTipo.AutoSize = true;
            this.labelAlterarSalaTipo.Location = new System.Drawing.Point(315, 22);
            this.labelAlterarSalaTipo.Name = "labelAlterarSalaTipo";
            this.labelAlterarSalaTipo.Size = new System.Drawing.Size(34, 13);
            this.labelAlterarSalaTipo.TabIndex = 17;
            this.labelAlterarSalaTipo.Text = "Tipo: ";
            // 
            // labelAlterarSalaUnidade
            // 
            this.labelAlterarSalaUnidade.AutoSize = true;
            this.labelAlterarSalaUnidade.Location = new System.Drawing.Point(16, 59);
            this.labelAlterarSalaUnidade.Name = "labelAlterarSalaUnidade";
            this.labelAlterarSalaUnidade.Size = new System.Drawing.Size(50, 13);
            this.labelAlterarSalaUnidade.TabIndex = 19;
            this.labelAlterarSalaUnidade.Text = "Unidade:";
            // 
            // comboBoxAlterarSalaTipo
            // 
            this.comboBoxAlterarSalaTipo.FormattingEnabled = true;
            this.comboBoxAlterarSalaTipo.Location = new System.Drawing.Point(348, 18);
            this.comboBoxAlterarSalaTipo.Name = "comboBoxAlterarSalaTipo";
            this.comboBoxAlterarSalaTipo.Size = new System.Drawing.Size(82, 21);
            this.comboBoxAlterarSalaTipo.TabIndex = 20;
            this.comboBoxAlterarSalaTipo.Text = "Laboratório";
            // 
            // comboBoxAlterarSalaUnidade
            // 
            this.comboBoxAlterarSalaUnidade.FormattingEnabled = true;
            this.comboBoxAlterarSalaUnidade.Location = new System.Drawing.Point(72, 55);
            this.comboBoxAlterarSalaUnidade.Name = "comboBoxAlterarSalaUnidade";
            this.comboBoxAlterarSalaUnidade.Size = new System.Drawing.Size(358, 21);
            this.comboBoxAlterarSalaUnidade.TabIndex = 21;
            // 
            // labelAlterarSalaDescricao
            // 
            this.labelAlterarSalaDescricao.AutoSize = true;
            this.labelAlterarSalaDescricao.Location = new System.Drawing.Point(103, 22);
            this.labelAlterarSalaDescricao.Name = "labelAlterarSalaDescricao";
            this.labelAlterarSalaDescricao.Size = new System.Drawing.Size(61, 13);
            this.labelAlterarSalaDescricao.TabIndex = 22;
            this.labelAlterarSalaDescricao.Text = "Descrição: ";
            // 
            // textBoxAlterarSalaDescricao
            // 
            this.textBoxAlterarSalaDescricao.Location = new System.Drawing.Point(163, 18);
            this.textBoxAlterarSalaDescricao.Name = "textBoxAlterarSalaDescricao";
            this.textBoxAlterarSalaDescricao.Size = new System.Drawing.Size(150, 20);
            this.textBoxAlterarSalaDescricao.TabIndex = 23;
            // 
            // FrmMenuAlterarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.textBoxAlterarSalaDescricao);
            this.Controls.Add(this.labelAlterarSalaDescricao);
            this.Controls.Add(this.comboBoxAlterarSalaUnidade);
            this.Controls.Add(this.comboBoxAlterarSalaTipo);
            this.Controls.Add(this.labelAlterarSalaUnidade);
            this.Controls.Add(this.labelAlterarSalaTipo);
            this.Controls.Add(this.buttonAlterarSalaCancelar);
            this.Controls.Add(this.buttonAlterarSalaConfirmar);
            this.Controls.Add(this.textBoxAlterarSalaNome);
            this.Controls.Add(this.labelAlterarSalaNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAlterarSala";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Sala";
            this.Load += new System.EventHandler(this.FrmMenuAlterarSala_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlterarSalaNome;
        private System.Windows.Forms.TextBox textBoxAlterarSalaNome;
        private System.Windows.Forms.Button buttonAlterarSalaConfirmar;
        private System.Windows.Forms.Button buttonAlterarSalaCancelar;
        private System.Windows.Forms.Label labelAlterarSalaTipo;
        private System.Windows.Forms.Label labelAlterarSalaUnidade;
        private System.Windows.Forms.ComboBox comboBoxAlterarSalaTipo;
        private System.Windows.Forms.ComboBox comboBoxAlterarSalaUnidade;
        private System.Windows.Forms.Label labelAlterarSalaDescricao;
        private System.Windows.Forms.TextBox textBoxAlterarSalaDescricao;
    }
}