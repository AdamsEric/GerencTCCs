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
    public partial class FrmMenuAlterarTCC : Form
    {
        public FrmMenuAlterarTCC()
        {
            InitializeComponent();
        }

        private void buttonAlterarTCCCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenuAlterarTCC_Load(object sender, EventArgs e)
        {

        }
    }
}
