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
    public partial class FrmMenuInserirTCC : Form
    {
        public FrmMenuInserirTCC()
        {
            InitializeComponent();
        }

        private void buttonInserirTCCCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenuInserirTCC_Load(object sender, EventArgs e)
        {

        }

        private void buttonInserirTCCConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxInserirTCCDescricao.Text == "" || textBoxInserirTCCTema.Text == ""
                || textBoxInserirTCCMatriculaAluno.Text == "" || comboBoxInserirTCCBancaOrientador.Text == "")
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
