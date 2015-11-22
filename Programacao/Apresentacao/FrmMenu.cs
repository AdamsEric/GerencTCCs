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
        }

        private void acessoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuAluno_Load(object sender, EventArgs e)
        {
            string modulo = "TCCs";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }

        private void acessoLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void acessoMenuModulosAlunos_Click(object sender, EventArgs e)
        {
            string modulo = "Alunos";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }

        private void acessoMenuModulosTCCs_Click(object sender, EventArgs e)
        {
            string modulo = "TCCs";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }

        private void acessoMenuModulosProfessores_Click(object sender, EventArgs e)
        {
            string modulo = "Professores";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }

        private void acessoMenuModulosCursos_Click(object sender, EventArgs e)
        {
            string modulo = "Cursos";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }

        private void acessoMenuModulosUnidades_Click(object sender, EventArgs e)
        {
            string modulo = "Unidades";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }

        private void acessoMenuModulosSalas_Click(object sender, EventArgs e)
        {
            string modulo = "Salas";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }

        private void acessoMenuAdministracaoUsuarios_Click(object sender, EventArgs e)
        {
            string modulo = "Usuários";
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador(modulo);
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now;
            toolStripStatusLabelDataeHora.Text = (dataHora.ToLongDateString() + " - " + dataHora.ToLongTimeString());
            toolStripStatusLabelDataeHora.Alignment = ToolStripItemAlignment.Right;
        }
    }
}
