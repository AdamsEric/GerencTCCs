using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            logoffToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            if (toolStripStatusLabelUsuarioGrupo.Text == "VISITANTE")
            {
                acessoMenuModulos.Visible = false;
                acessoMenuAdministracao.Visible = false;
                logoffToolStripMenuItem.Visible = false;
                toolStripStatusLabelTipodeAcesso.Visible = false;
                toolStripStatusLabelUsuarioGrupo.Visible = false;
            }
        }

        private void acessoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuAluno_Load(object sender, EventArgs e)
        {
            string modulo = "TCCs";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo, toolStripStatusLabelUsuarioGrupo.Text);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }

        private void acessoLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

            if (frmLogin.ValorGrupo != "Grupo")
            {
                toolStripStatusLabelUsuarioNome.Text = frmLogin.ValorLogin;
                toolStripStatusLabelUsuarioGrupo.Text = frmLogin.ValorGrupo;

                if (toolStripStatusLabelUsuarioGrupo.Text == "ADMINISTRADOR")
                {
                    acessoMenuAdministracao.Visible = true;
                    acessoMenuModulos.Visible = true;
                    acessoMenuModulosAlunos.Visible = true;
                    acessoMenuModulosCursos.Visible = true;
                    acessoMenuModulosProfessores.Visible = true;
                    acessoMenuModulosSalas.Visible = true;
                    acessoMenuModulosUnidades.Visible = true;
                    acessoMenuModulosTCCs.Visible = true;
                    logoffToolStripMenuItem.Visible = true;
                    toolStripStatusLabelTipodeAcesso.Visible = true;
                    toolStripStatusLabelUsuarioGrupo.Visible = true;
                }
                if (toolStripStatusLabelUsuarioGrupo.Text == "GERENTE")
                {
                    acessoMenuAdministracao.Visible = false;
                    acessoMenuModulos.Visible = true;
                    acessoMenuModulosAlunos.Visible = true;
                    acessoMenuModulosCursos.Visible = true;
                    acessoMenuModulosProfessores.Visible = true;
                    acessoMenuModulosSalas.Visible = true;
                    acessoMenuModulosUnidades.Visible = true;
                    acessoMenuModulosTCCs.Visible = true;
                    logoffToolStripMenuItem.Visible = true;
                    toolStripStatusLabelTipodeAcesso.Visible = true;
                    toolStripStatusLabelUsuarioGrupo.Visible = true;
                }
                if (toolStripStatusLabelUsuarioGrupo.Text == "REGISTRADOR")
                {
                    acessoMenuAdministracao.Visible = false;
                    acessoMenuModulos.Visible = true;
                    acessoMenuModulosAlunos.Visible = true;
                    acessoMenuModulosCursos.Visible = false;
                    acessoMenuModulosProfessores.Visible = false;
                    acessoMenuModulosSalas.Visible = false;
                    acessoMenuModulosUnidades.Visible = false;
                    acessoMenuModulosTCCs.Visible = true;
                    logoffToolStripMenuItem.Visible = true;
                    toolStripStatusLabelTipodeAcesso.Visible = true;
                    toolStripStatusLabelUsuarioGrupo.Visible = true;
                }
                
                string modulo = "TCCs";
                FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo, toolStripStatusLabelUsuarioGrupo.Text);
                frmMenuAdministrador.MdiParent = this;
                frmMenuAdministrador.Show();
            }
        }

        private void acessoMenuModulosAlunos_Click(object sender, EventArgs e)
        {
            string modulo = "Alunos";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo, toolStripStatusLabelUsuarioGrupo.Text);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }

        private void acessoMenuModulosTCCs_Click(object sender, EventArgs e)
        {
            string modulo = "TCCs";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo, toolStripStatusLabelUsuarioGrupo.Text);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }

        private void acessoMenuModulosProfessores_Click(object sender, EventArgs e)
        {
            string modulo = "Professores";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo, toolStripStatusLabelUsuarioGrupo.Text);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }

        private void acessoMenuModulosCursos_Click(object sender, EventArgs e)
        {
            string modulo = "Cursos";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo, toolStripStatusLabelUsuarioGrupo.Text);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }

        private void acessoMenuModulosUnidades_Click(object sender, EventArgs e)
        {
            string modulo = "Unidades";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo, toolStripStatusLabelUsuarioGrupo.Text);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }

        private void acessoMenuModulosSalas_Click(object sender, EventArgs e)
        {
            string modulo = "Salas";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo, toolStripStatusLabelUsuarioGrupo.Text);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }

        private void acessoMenuAdministracaoUsuarios_Click(object sender, EventArgs e)
        {
            string modulo = "Usuários";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo, toolStripStatusLabelUsuarioGrupo.Text);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now;
            toolStripStatusLabelDataeHora.Text = (dataHora.ToLongDateString() + " - " + dataHora.ToLongTimeString());
            toolStripStatusLabelDataeHora.Alignment = ToolStripItemAlignment.Right;
        }

        private void acessoMenuOpcoesSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não há nada aqui.\nDeixe de ser curioso, cara!", "Sobre");
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelUsuarioNome.Text = "VISITANTE";
            toolStripStatusLabelUsuarioGrupo.Text = "VISITANTE";
            acessoMenuModulos.Visible = false;
            acessoMenuAdministracao.Visible = false;
            logoffToolStripMenuItem.Visible = false;
            toolStripStatusLabelTipodeAcesso.Visible = false;
            toolStripStatusLabelUsuarioGrupo.Visible = false;
            string modulo = "TCCs";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo, toolStripStatusLabelUsuarioGrupo.Text);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }
    }
}
