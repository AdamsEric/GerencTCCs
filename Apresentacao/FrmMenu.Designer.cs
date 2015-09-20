namespace Apresentacao
{
    partial class MenuAluno
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
            this.acessoMenuOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoMenuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUsuarioAtual = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // acessoMenuOpcoes
            // 
            this.acessoMenuOpcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoLogin,
            this.acessoSair});
            this.acessoMenuOpcoes.Name = "acessoMenuOpcoes";
            this.acessoMenuOpcoes.Size = new System.Drawing.Size(59, 20);
            this.acessoMenuOpcoes.Text = "&Opções";
            // 
            // acessoLogin
            // 
            this.acessoLogin.Name = "acessoLogin";
            this.acessoLogin.Size = new System.Drawing.Size(104, 22);
            this.acessoLogin.Text = "&Login";
            this.acessoLogin.Click += new System.EventHandler(this.acessoLogin_Click);
            // 
            // acessoSair
            // 
            this.acessoSair.Name = "acessoSair";
            this.acessoSair.Size = new System.Drawing.Size(104, 22);
            this.acessoSair.Text = "&Sair";
            this.acessoSair.Click += new System.EventHandler(this.acessoSair_Click);
            // 
            // acessoMenuAjuda
            // 
            this.acessoMenuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoAjuda,
            this.acessoSobre});
            this.acessoMenuAjuda.Name = "acessoMenuAjuda";
            this.acessoMenuAjuda.Size = new System.Drawing.Size(50, 20);
            this.acessoMenuAjuda.Text = "A&juda";
            this.acessoMenuAjuda.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // acessoAjuda
            // 
            this.acessoAjuda.Name = "acessoAjuda";
            this.acessoAjuda.Size = new System.Drawing.Size(136, 22);
            this.acessoAjuda.Text = "E&xibir Ajuda";
            // 
            // acessoSobre
            // 
            this.acessoSobre.Name = "acessoSobre";
            this.acessoSobre.Size = new System.Drawing.Size(136, 22);
            this.acessoSobre.Text = "So&bre...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoMenuOpcoes,
            this.acessoMenuAjuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUsuarioAtual,
            this.toolStripStatusLabelUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUsuarioAtual
            // 
            this.toolStripStatusLabelUsuarioAtual.Name = "toolStripStatusLabelUsuarioAtual";
            this.toolStripStatusLabelUsuarioAtual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabelUsuarioAtual.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabelUsuarioAtual.Text = "Usuário atual:";
            // 
            // toolStripStatusLabelUsuario
            // 
            this.toolStripStatusLabelUsuario.Name = "toolStripStatusLabelUsuario";
            this.toolStripStatusLabelUsuario.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabelUsuario.Text = "Visitante";
            // 
            // MenuAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gereniador de TCCs - Versão 1.09.3";
            this.Load += new System.EventHandler(this.MenuAluno_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem acessoMenuOpcoes;
        private System.Windows.Forms.ToolStripMenuItem acessoLogin;
        private System.Windows.Forms.ToolStripMenuItem acessoSair;
        private System.Windows.Forms.ToolStripMenuItem acessoMenuAjuda;
        private System.Windows.Forms.ToolStripMenuItem acessoAjuda;
        private System.Windows.Forms.ToolStripMenuItem acessoSobre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUsuarioAtual;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUsuario;

    }
}