namespace Apresentacao
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.acessoMenuOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoMenuOpcoesLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoMenuOpcoesSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoMenuOpcoesSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.acessoMenuModulos = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoMenuModulosTCCs = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoMenuModulosAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoMenuModulosProfessores = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoMenuModulosCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoMenuModulosUnidades = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoMenuModulosSalas = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoMenuAdministracao = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoMenuAdministracaoUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUsuarioAtual = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDataeHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // acessoMenuOpcoes
            // 
            this.acessoMenuOpcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoMenuOpcoesLogin,
            this.acessoMenuOpcoesSobre,
            this.acessoMenuOpcoesSair});
            this.acessoMenuOpcoes.Name = "acessoMenuOpcoes";
            this.acessoMenuOpcoes.Size = new System.Drawing.Size(59, 20);
            this.acessoMenuOpcoes.Text = "&Opções";
            // 
            // acessoMenuOpcoesLogin
            // 
            this.acessoMenuOpcoesLogin.Name = "acessoMenuOpcoesLogin";
            this.acessoMenuOpcoesLogin.Size = new System.Drawing.Size(113, 22);
            this.acessoMenuOpcoesLogin.Text = "Login";
            this.acessoMenuOpcoesLogin.Click += new System.EventHandler(this.acessoLogin_Click);
            // 
            // acessoMenuOpcoesSobre
            // 
            this.acessoMenuOpcoesSobre.Name = "acessoMenuOpcoesSobre";
            this.acessoMenuOpcoesSobre.Size = new System.Drawing.Size(113, 22);
            this.acessoMenuOpcoesSobre.Text = "Sobre...";
            // 
            // acessoMenuOpcoesSair
            // 
            this.acessoMenuOpcoesSair.Name = "acessoMenuOpcoesSair";
            this.acessoMenuOpcoesSair.Size = new System.Drawing.Size(113, 22);
            this.acessoMenuOpcoesSair.Text = "Sair";
            this.acessoMenuOpcoesSair.Click += new System.EventHandler(this.acessoSair_Click);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.Menu;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoMenuOpcoes,
            this.acessoMenuModulos,
            this.acessoMenuAdministracao});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(804, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // acessoMenuModulos
            // 
            this.acessoMenuModulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoMenuModulosTCCs,
            this.acessoMenuModulosAlunos,
            this.acessoMenuModulosProfessores,
            this.acessoMenuModulosCursos,
            this.acessoMenuModulosUnidades,
            this.acessoMenuModulosSalas});
            this.acessoMenuModulos.Name = "acessoMenuModulos";
            this.acessoMenuModulos.Size = new System.Drawing.Size(66, 20);
            this.acessoMenuModulos.Text = "&Módulos";
            // 
            // acessoMenuModulosTCCs
            // 
            this.acessoMenuModulosTCCs.Name = "acessoMenuModulosTCCs";
            this.acessoMenuModulosTCCs.Size = new System.Drawing.Size(152, 22);
            this.acessoMenuModulosTCCs.Text = "TCCs";
            this.acessoMenuModulosTCCs.Click += new System.EventHandler(this.acessoMenuModulosTCCs_Click);
            // 
            // acessoMenuModulosAlunos
            // 
            this.acessoMenuModulosAlunos.Name = "acessoMenuModulosAlunos";
            this.acessoMenuModulosAlunos.Size = new System.Drawing.Size(152, 22);
            this.acessoMenuModulosAlunos.Text = "Alunos";
            this.acessoMenuModulosAlunos.Click += new System.EventHandler(this.acessoMenuModulosAlunos_Click);
            // 
            // acessoMenuModulosProfessores
            // 
            this.acessoMenuModulosProfessores.Name = "acessoMenuModulosProfessores";
            this.acessoMenuModulosProfessores.Size = new System.Drawing.Size(152, 22);
            this.acessoMenuModulosProfessores.Text = "Professores";
            this.acessoMenuModulosProfessores.Click += new System.EventHandler(this.acessoMenuModulosProfessores_Click);
            // 
            // acessoMenuModulosCursos
            // 
            this.acessoMenuModulosCursos.Name = "acessoMenuModulosCursos";
            this.acessoMenuModulosCursos.Size = new System.Drawing.Size(152, 22);
            this.acessoMenuModulosCursos.Text = "Cursos";
            this.acessoMenuModulosCursos.Click += new System.EventHandler(this.acessoMenuModulosCursos_Click);
            // 
            // acessoMenuModulosUnidades
            // 
            this.acessoMenuModulosUnidades.Name = "acessoMenuModulosUnidades";
            this.acessoMenuModulosUnidades.Size = new System.Drawing.Size(152, 22);
            this.acessoMenuModulosUnidades.Text = "Unidades";
            this.acessoMenuModulosUnidades.Click += new System.EventHandler(this.acessoMenuModulosUnidades_Click);
            // 
            // acessoMenuModulosSalas
            // 
            this.acessoMenuModulosSalas.Name = "acessoMenuModulosSalas";
            this.acessoMenuModulosSalas.Size = new System.Drawing.Size(152, 22);
            this.acessoMenuModulosSalas.Text = "Salas";
            this.acessoMenuModulosSalas.Click += new System.EventHandler(this.acessoMenuModulosSalas_Click);
            // 
            // acessoMenuAdministracao
            // 
            this.acessoMenuAdministracao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoMenuAdministracaoUsuarios});
            this.acessoMenuAdministracao.Name = "acessoMenuAdministracao";
            this.acessoMenuAdministracao.Size = new System.Drawing.Size(96, 20);
            this.acessoMenuAdministracao.Text = "Adm&inistração";
            // 
            // acessoMenuAdministracaoUsuarios
            // 
            this.acessoMenuAdministracaoUsuarios.Name = "acessoMenuAdministracaoUsuarios";
            this.acessoMenuAdministracaoUsuarios.Size = new System.Drawing.Size(119, 22);
            this.acessoMenuAdministracaoUsuarios.Text = "Usuários";
            this.acessoMenuAdministracaoUsuarios.Click += new System.EventHandler(this.acessoMenuAdministracaoUsuarios_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUsuarioAtual,
            this.toolStripStatusLabelUsuario,
            this.toolStripStatusLabelDataHora,
            this.toolStripStatusLabelDataeHora});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 22);
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
            // toolStripStatusLabelDataHora
            // 
            this.toolStripStatusLabelDataHora.Name = "toolStripStatusLabelDataHora";
            this.toolStripStatusLabelDataHora.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabelDataeHora
            // 
            this.toolStripStatusLabelDataeHora.Name = "toolStripStatusLabelDataeHora";
            this.toolStripStatusLabelDataeHora.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelDataeHora.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de TCCs - Versão 2.10.1";
            this.Load += new System.EventHandler(this.MenuAluno_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem acessoMenuOpcoes;
        private System.Windows.Forms.ToolStripMenuItem acessoMenuOpcoesLogin;
        private System.Windows.Forms.ToolStripMenuItem acessoMenuOpcoesSair;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUsuarioAtual;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUsuario;
        private System.Windows.Forms.ToolStripMenuItem acessoMenuModulos;
        private System.Windows.Forms.ToolStripMenuItem acessoMenuModulosTCCs;
        private System.Windows.Forms.ToolStripMenuItem acessoMenuModulosAlunos;
        private System.Windows.Forms.ToolStripMenuItem acessoMenuModulosProfessores;
        private System.Windows.Forms.ToolStripMenuItem acessoMenuModulosCursos;
        private System.Windows.Forms.ToolStripMenuItem acessoMenuModulosUnidades;
        private System.Windows.Forms.ToolStripMenuItem acessoMenuOpcoesSobre;
        private System.Windows.Forms.ToolStripMenuItem acessoMenuModulosSalas;
        private System.Windows.Forms.ToolStripMenuItem acessoMenuAdministracao;
        private System.Windows.Forms.ToolStripMenuItem acessoMenuAdministracaoUsuarios;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDataHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDataeHora;
        private System.Windows.Forms.Timer timer1;

    }
}