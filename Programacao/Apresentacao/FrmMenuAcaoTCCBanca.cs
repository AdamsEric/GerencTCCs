using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using DTO;

namespace Apresentacao
{
    public partial class FrmMenuAcaoBanca : Form
    {
        Banca bancaold = new Banca();

        public FrmMenuAcaoBanca(Banca banca, string acao)
        {
            InitializeComponent();

            if (acao == "Inserir Banca")
            {
                this.Text = "Inserir Banca";
            }
            else if (acao == "Alterar Banca")
            {
                this.Text = "Alterar Banca";
            }
            else if (acao == "Consultar Banca")
            {
                this.Text = "Consultar Banca";
            }
        }

        private void buttonAcaoBancaCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAcaoBancaConfirmar_Click(object sender, EventArgs e)
        {
            if (this.Text == "Inserir Banca")
            {
                
            }


            if (this.Text == "Alterar Banca")
            {
                
            }
        }
    }
}
