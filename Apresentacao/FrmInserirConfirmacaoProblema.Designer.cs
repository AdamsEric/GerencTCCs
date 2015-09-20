namespace Apresentacao
{
    partial class FrmInserirConfirmacaoProblema
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
            this.buttonInserirConfirmacaoProblemaOK = new System.Windows.Forms.Button();
            this.labelInserirConfirmacaoProblema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInserirConfirmacaoProblemaOK
            // 
            this.buttonInserirConfirmacaoProblemaOK.Location = new System.Drawing.Point(88, 45);
            this.buttonInserirConfirmacaoProblemaOK.Name = "buttonInserirConfirmacaoProblemaOK";
            this.buttonInserirConfirmacaoProblemaOK.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirConfirmacaoProblemaOK.TabIndex = 1;
            this.buttonInserirConfirmacaoProblemaOK.Text = "OK";
            this.buttonInserirConfirmacaoProblemaOK.UseVisualStyleBackColor = true;
            this.buttonInserirConfirmacaoProblemaOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelInserirConfirmacaoProblema
            // 
            this.labelInserirConfirmacaoProblema.AutoSize = true;
            this.labelInserirConfirmacaoProblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInserirConfirmacaoProblema.Location = new System.Drawing.Point(5, 16);
            this.labelInserirConfirmacaoProblema.Name = "labelInserirConfirmacaoProblema";
            this.labelInserirConfirmacaoProblema.Size = new System.Drawing.Size(240, 18);
            this.labelInserirConfirmacaoProblema.TabIndex = 2;
            this.labelInserirConfirmacaoProblema.Text = "Favor preencher todos os campos!";
            // 
            // FrmInserirConfirmacaoProblema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 80);
            this.ControlBox = false;
            this.Controls.Add(this.labelInserirConfirmacaoProblema);
            this.Controls.Add(this.buttonInserirConfirmacaoProblemaOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInserirConfirmacaoProblema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInserirConfirmacaoProblemaOK;
        private System.Windows.Forms.Label labelInserirConfirmacaoProblema;
    }
}