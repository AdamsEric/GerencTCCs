namespace Apresentacao
{
    partial class FrmInserirConfirmacaoSucesso
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
            this.buttonInserirConfirmacaoSucessoOK = new System.Windows.Forms.Button();
            this.labelInserirConfirmacaoSucesso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInserirConfirmacaoSucessoOK
            // 
            this.buttonInserirConfirmacaoSucessoOK.Location = new System.Drawing.Point(88, 45);
            this.buttonInserirConfirmacaoSucessoOK.Name = "buttonInserirConfirmacaoSucessoOK";
            this.buttonInserirConfirmacaoSucessoOK.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirConfirmacaoSucessoOK.TabIndex = 1;
            this.buttonInserirConfirmacaoSucessoOK.Text = "OK";
            this.buttonInserirConfirmacaoSucessoOK.UseVisualStyleBackColor = true;
            this.buttonInserirConfirmacaoSucessoOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelInserirConfirmacaoSucesso
            // 
            this.labelInserirConfirmacaoSucesso.AutoSize = true;
            this.labelInserirConfirmacaoSucesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInserirConfirmacaoSucesso.Location = new System.Drawing.Point(10, 16);
            this.labelInserirConfirmacaoSucesso.Name = "labelInserirConfirmacaoSucesso";
            this.labelInserirConfirmacaoSucesso.Size = new System.Drawing.Size(231, 18);
            this.labelInserirConfirmacaoSucesso.TabIndex = 2;
            this.labelInserirConfirmacaoSucesso.Text = "Cadastro realizado com sucesso!";
            // 
            // FrmInserirConfirmacaoSucesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 80);
            this.ControlBox = false;
            this.Controls.Add(this.labelInserirConfirmacaoSucesso);
            this.Controls.Add(this.buttonInserirConfirmacaoSucessoOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInserirConfirmacaoSucesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInserirConfirmacaoSucessoOK;
        private System.Windows.Forms.Label labelInserirConfirmacaoSucesso;
    }
}