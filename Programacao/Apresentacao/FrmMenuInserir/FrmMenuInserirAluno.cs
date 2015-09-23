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
    public partial class FrmMenuInserirAluno : Form
    {
        public FrmMenuInserirAluno()
        {
            InitializeComponent();
        }

        private void buttonInserirAlunoCancelar_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void buttonInserirAlunoConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxInserirAlunoNome.Text == "" || textBoxInserirAlunoMatricula.Text == ""
                || comboBoxInserirAlunoCurso.Text == "")
            {
                FrmInserirConfirmacaoProblema frmInserirConfirmacaoProblema = new FrmInserirConfirmacaoProblema();
                frmInserirConfirmacaoProblema.ShowDialog();
            }
            else
            {
                if (maskedTextBoxInserirAlunoCPF.MaskFull)
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
