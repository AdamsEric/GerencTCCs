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
    public partial class FrmMenuInserirSala : Form
    {
        public FrmMenuInserirSala()
        {
            InitializeComponent();
        }

        private void buttonInserirSalaCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenuInserirSala_Load(object sender, EventArgs e)
        {

        }

        private void buttonInserirSalaConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxInserirSalaNome.Text == "" || comboBoxInserirSalaTipo.Text == ""
                || comboBoxInserirSalaUnidade.Text == "")
            {
                FrmInserirConfirmacaoProblema frmInserirConfirmacaoProblema = new FrmInserirConfirmacaoProblema();
                frmInserirConfirmacaoProblema.ShowDialog();
            }
            else
            {
                FrmInserirConfirmacaoSucesso frmInserirConfirmacaoSucesso = new FrmInserirConfirmacaoSucesso();
                frmInserirConfirmacaoSucesso.ShowDialog();
                this.Close();
            }
        }
    }
}
