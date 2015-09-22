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
    public partial class FrmMenuInserirProfessor : Form
    {
        public FrmMenuInserirProfessor()
        {
            InitializeComponent();
        }

        private void buttonInserirProfessorCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenuInserirProfessor_Load(object sender, EventArgs e)
        {

        }

        private void buttonInserirProfessorConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxInserirProfessorNome.Text == "" || textBoxInserirProfessorMatricula.Text == "")
            {
                FrmInserirConfirmacaoProblema frmInserirConfirmacaoProblema = new FrmInserirConfirmacaoProblema();
                frmInserirConfirmacaoProblema.ShowDialog();
            }
            else
            {
                if (maskedTextBoxInserirProfessorCPF.MaskFull)
                {
                    FrmInserirConfirmacaoSucesso frmInserirConfirmacaoSucesso = new FrmInserirConfirmacaoSucesso();
                    frmInserirConfirmacaoSucesso.ShowDialog();
                    this.Close();
                }
                else 
                {
                    FrmInserirConfirmacaoProblema frmInserirConfirmacaoProblema = new FrmInserirConfirmacaoProblema();
                    frmInserirConfirmacaoProblema.ShowDialog();
                }
            }
        }
    }
}
