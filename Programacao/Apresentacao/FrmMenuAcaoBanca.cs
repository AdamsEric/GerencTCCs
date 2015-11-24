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

        public FrmMenuAcaoBanca(string Acao, Banca banca, int tccID, int bancaID, string orientadornome)
        {
            InitializeComponent();
            this.Text = "Banca Examinadora";

            if (Acao == "Consultar TCC")
            {
                dataGridViewAcaoBancaProfessor.Size = new Size(456, 138);
                dataGridViewAcaoBancaProfessor.Location = new Point(14, 41);
                labelAcaoBancaProfessor.Visible = false;
                labelAcaoBancaTCCOrientador.Visible = false;
                textBoxAcaoBancaProfessorID.Visible = false;
                textBoxAcaoBancaProfessorNome.Visible = false;
                buttonAcaoBancaExcluirProfessor.Visible = false;
                buttonAcaoBancaInserirProfessor.Visible = false;
                buttonAcaoBancaConcluir.Visible = false;
            }

            labelAcaoBancaTCCOrientador.Text = orientadornome;
            textBoxAcaoBancaTCCID.Text = tccID.ToString();
            textBoxAcaoBancaID.Text = bancaID.ToString();
            textBoxAcaoBancaProfessorID.Text = "";
            textBoxAcaoBancaProfessorNome.Text = "";
            if (textBoxAcaoBancaProfessorID.Text == "")
            {
                this.buttonAcaoBancaInserirProfessor.Enabled = false;
            }
        }

        private void buttonAcaoBancaInserirProfessor_Click(object sender, EventArgs e)
        {
            Banca banca = new Banca();
            BancaNegocios bancaNegocios = new BancaNegocios();

            banca.BancaID = Convert.ToInt32(textBoxAcaoBancaID.Text);
            banca.BancaProfessorID = Convert.ToInt32(textBoxAcaoBancaProfessorID.Text);

            int verificacao = bancaNegocios.VerificarProfessorExistente(banca);
            if (labelAcaoBancaTCCOrientador.Text == textBoxAcaoBancaProfessorNome.Text)
            {
                verificacao = -1;
            }

            if (verificacao > 0)
            {
                MessageBox.Show("O professor " + textBoxAcaoBancaProfessorNome.Text + " já está nesta banca.", "Erro");
            }
            else
            {
                if (verificacao < 0)
                {
                    MessageBox.Show("O professor " + textBoxAcaoBancaProfessorNome.Text + " já foi cadastrado como orientador deste TCC!");
                }
                else
                {
                    string retorno = bancaNegocios.InserirProfessor(banca);
                }
            }
            textBoxAcaoBancaProfessorID.Text = "";
            textBoxAcaoBancaProfessorNome.Text = "";
            this.buttonAcaoBancaInserirProfessor.Enabled = false;
            ListarProfessores();
        }

        private void buttonAcaoBancaConcluir_Click(object sender, EventArgs e)
        {
            BancaNegocios bancaNegocios = new BancaNegocios();
            int verificacao = bancaNegocios.VerificarBancaVazia(Convert.ToInt32(textBoxAcaoBancaID.Text));
            if (verificacao == 0)
            {
                MessageBox.Show("Não existe professor cadastrado nesta banca. Esta banca será excluída.");
                bancaNegocios.ExcluirBanca(Convert.ToInt32(textBoxAcaoBancaTCCID.Text));
            }
            this.Close();
        }

        private void buttonAcaoBancaExcluirProfessor_Click(object sender, EventArgs e)
        {
            if (dataGridViewAcaoBancaProfessor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
            else
            {
                if (dataGridViewAcaoBancaProfessor.SelectedRows.Count != 0)
                {
                    DialogResult resultado = MessageBox.Show("Deseja mesmo excluir este professor da banca?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.No)
                    {

                    }
                    else
                    {
                        Banca bancaSelecao = (dataGridViewAcaoBancaProfessor.SelectedRows[0].DataBoundItem as Banca);
                        BancaNegocios bancaNegocios = new BancaNegocios();

                        string retorno = bancaNegocios.ExcluirProfessor(bancaSelecao);

                        try
                        {
                            MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Não foi possível excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        ListarProfessores();
                    }
                }
            }
        }

        private void ListarProfessores()
        {
            BancaNegocios bancaNegocios = new BancaNegocios();
            BancaColecao bancaColecao = new BancaColecao();

            bancaColecao = bancaNegocios.ListarProfessores(Convert.ToInt32(textBoxAcaoBancaID.Text));

            dataGridViewAcaoBancaProfessor.DataSource = null;
            dataGridViewAcaoBancaProfessor.DataSource = bancaColecao;
            dataGridViewAcaoBancaProfessor.Columns["BancaID"].Visible = false;
            dataGridViewAcaoBancaProfessor.Columns["BancaBancaProfessorID"].Visible = false;
            dataGridViewAcaoBancaProfessor.Columns["BancaProfessorID"].HeaderText = "ID";
            dataGridViewAcaoBancaProfessor.Columns["BancaProfessorID"].Width = 30;
            dataGridViewAcaoBancaProfessor.Columns["BancaProfessorNome"].HeaderText = "Professor";
            dataGridViewAcaoBancaProfessor.Columns["BancaProfessorNome"].Width = 393;
            dataGridViewAcaoBancaProfessor.Columns["BancaTCCID"].Visible = false;
            dataGridViewAcaoBancaProfessor.Update();
            dataGridViewAcaoBancaProfessor.Refresh();
        }

        private void FrmMenuAcaoBanca_Load(object sender, EventArgs e)
        {
            ListarProfessores();
        }

        private void buttonAcaoBancaProfessorSelecionar_Click(object sender, EventArgs e)
        {
            string modulo = "Professores";

            FrmMenuSelecao frmMenuSelecao = new FrmMenuSelecao(modulo);
            frmMenuSelecao.ShowDialog();

            if (frmMenuSelecao.ValorID != 0)
            {
                textBoxAcaoBancaProfessorID.Text = Convert.ToString(frmMenuSelecao.ValorID);
                textBoxAcaoBancaProfessorNome.Text = frmMenuSelecao.ValorRetorno1;
                this.buttonAcaoBancaInserirProfessor.Enabled = true;
            }
        }
    }
}
