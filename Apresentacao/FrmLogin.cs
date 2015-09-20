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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void buttonLoginOK_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLoginCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
