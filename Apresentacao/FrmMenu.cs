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
    public partial class MenuAluno : Form
    {
        public MenuAluno()
        {
            InitializeComponent();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acessoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuAluno_Load(object sender, EventArgs e)
        {
            FrmMenuAdministrador frmMenuAdministrador = new FrmMenuAdministrador();
            frmMenuAdministrador.MdiParent = this;
            frmMenuAdministrador.Show();
        }
    }
}
