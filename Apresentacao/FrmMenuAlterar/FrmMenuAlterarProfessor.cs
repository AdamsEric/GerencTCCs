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
    public partial class FrmMenuAlterarProfessor : Form
    {
        public FrmMenuAlterarProfessor()
        {
            InitializeComponent();
        }

        private void buttonAlterarProfessorCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenuAlterarProfessor_Load(object sender, EventArgs e)
        {

        }
    }
}
