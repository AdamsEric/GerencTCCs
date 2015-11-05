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
    public partial class FrmMenuAcaoTCC : Form
    {
        TCC tccold = new TCC();

        public FrmMenuAcaoTCC(TCC tcc, string acao)
        {
            InitializeComponent();

            TCCNegocios tccNegocios = new TCCNegocios();

            if (acao == "Inserir TCC")
            {
                this.Text = "Inserir TCC";
            }
            else if (acao == "Alterar TCC")
            {
                
            }
            else if (acao == "Consultar TCC")
            {
                
            }
        }

        private void buttonAcaoTCCCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAcaoTCCConfirmar_Click(object sender, EventArgs e)
        {
            if (this.Text == "Inserir TCC")
            {
                
            }

            if (this.Text == "Alterar TCC")
            {
                
            }
        }

        private void buttonAcaoTCCAlunoSelecionar_Click(object sender, EventArgs e)
        {
            string modulo = "Alunos";

            FrmMenuSelecao frmMenuSelecao = new FrmMenuSelecao(modulo);
            frmMenuSelecao.ShowDialog();

            if (frmMenuSelecao.ValorID != 0)
            {
                textBoxAcaoTCCAlunoID.Text = Convert.ToString(frmMenuSelecao.ValorID);
                textBoxAcaoTCCAlunoNome.Text = frmMenuSelecao.ValorRetorno1;
            }
        }

        private void buttonAcaoTCCOrientadorSelecionar_Click(object sender, EventArgs e)
        {
            string modulo = "Professores";

            FrmMenuSelecao frmMenuSelecao = new FrmMenuSelecao(modulo);
            frmMenuSelecao.ShowDialog();

            if (frmMenuSelecao.ValorID != 0)
            {
                textBoxAcaoTCCOrientadorID.Text = Convert.ToString(frmMenuSelecao.ValorID);
                textBoxAcaoTCCOrientadorNome.Text = frmMenuSelecao.ValorRetorno1;
            }
        }

        private void buttonAcaoTCCSalaSelecionar_Click(object sender, EventArgs e)
        {
            string modulo = "Salas";

            FrmMenuSelecao frmMenuSelecao = new FrmMenuSelecao(modulo);
            frmMenuSelecao.ShowDialog();

            if (frmMenuSelecao.ValorID != 0)
            {
                textBoxAcaoTCCSalaID.Text = Convert.ToString(frmMenuSelecao.ValorID);
                textBoxAcaoTCCSalaNome.Text = frmMenuSelecao.ValorRetorno1;
            }
        }

        private void buttonAcaoTCCProfessorBanca1Selecionar_Click(object sender, EventArgs e)
        {
            string modulo = "Salas";

            FrmMenuSelecao frmMenuSelecao = new FrmMenuSelecao(modulo);
            frmMenuSelecao.ShowDialog();

            if (frmMenuSelecao.ValorID != 0)
            {
                textBoxAcaoTCCProfessorBanca1ID.Text = Convert.ToString(frmMenuSelecao.ValorID);
                textBoxAcaoTCCProfessorBanca1Nome.Text = frmMenuSelecao.ValorRetorno1;
            }
        }

        private void buttonAcaoTCCProfessorBanca2Selecionar_Click(object sender, EventArgs e)
        {
            string modulo = "Salas";

            FrmMenuSelecao frmMenuSelecao = new FrmMenuSelecao(modulo);
            frmMenuSelecao.ShowDialog();

            if (frmMenuSelecao.ValorID != 0)
            {
                textBoxAcaoTCCProfessorBanca2ID.Text = Convert.ToString(frmMenuSelecao.ValorID);
                textBoxAcaoTCCProfessorBanca2Nome.Text = frmMenuSelecao.ValorRetorno1;
            }
        }

        private void buttonAcaoTCCProfessorBanca3Selecionar_Click(object sender, EventArgs e)
        {
            string modulo = "Salas";

            FrmMenuSelecao frmMenuSelecao = new FrmMenuSelecao(modulo);
            frmMenuSelecao.ShowDialog();

            if (frmMenuSelecao.ValorID != 0)
            {
                textBoxAcaoTCCProfessorBanca3ID.Text = Convert.ToString(frmMenuSelecao.ValorID);
                textBoxAcaoTCCProfessorBanca3Nome.Text = frmMenuSelecao.ValorRetorno1;
            }
        }
    }
}
