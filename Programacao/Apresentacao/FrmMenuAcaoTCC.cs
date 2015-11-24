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
        int bancaID = 0;

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
                this.Text = "Alterar TCC";
                textBoxAcaoTCCID.Text = tcc.TCCID.ToString();
                textBoxAcaoTCCAlunoID.Text = tcc.TCCAlunoID.ToString();
                textBoxAcaoTCCAlunoNome.Text = tcc.TCCAlunoNome;
                textBoxAcaoTCCTitulo.Text = tcc.TCCTitulo;
                textBoxAcaoTCCOrientadorID.Text = tcc.TCCOrientadorID.ToString();
                textBoxAcaoTCCOrientadorNome.Text = tcc.TCCOrientadorNome;
                textBoxAcaoTCCGrandeArea.Text = tcc.TCCGrandeArea;
                textBoxAcaoTCCArea.Text = tcc.TCCArea;
                textBoxAcaoTCCSubarea.Text = tcc.TCCSubarea;
                textBoxAcaoTCCEspecialidade.Text = tcc.TCCEspecialidade;
                textBoxAcaoTCCResumo.Text = tcc.TCCResumo;
                maskedTextBoxAcaoTCCPaginas.Text = tcc.TCCPaginas.ToString();
                textBoxAcaoTCCSalaID.Text = tcc.TCCSalaID.ToString();
                textBoxAcaoTCCSalaNome.Text = tcc.TCCSalaNome;
                textBoxAcaoTCCUnidade.Text = tcc.TCCUnidade;
                dateTimePickerAcaoTCCData.Value = tcc.TCCData;
                tccold = tcc;
            }
            else if (acao == "Consultar TCC")
            {
                this.Text = "Consultar TCC";
                textBoxAcaoTCCID.Text = tcc.TCCID.ToString();
                textBoxAcaoTCCAlunoID.Text = tcc.TCCAlunoID.ToString();
                textBoxAcaoTCCAlunoNome.Text = tcc.TCCAlunoNome;
                textBoxAcaoTCCTitulo.Text = tcc.TCCTitulo;
                textBoxAcaoTCCOrientadorID.Text = tcc.TCCOrientadorID.ToString();
                textBoxAcaoTCCOrientadorNome.Text = tcc.TCCOrientadorNome;
                textBoxAcaoTCCGrandeArea.Text = tcc.TCCGrandeArea;
                textBoxAcaoTCCArea.Text = tcc.TCCArea;
                textBoxAcaoTCCSubarea.Text = tcc.TCCSubarea;
                textBoxAcaoTCCEspecialidade.Text = tcc.TCCEspecialidade;
                textBoxAcaoTCCResumo.Text = tcc.TCCResumo;
                maskedTextBoxAcaoTCCPaginas.Text = tcc.TCCPaginas.ToString();
                textBoxAcaoTCCSalaID.Text = tcc.TCCSalaID.ToString();
                textBoxAcaoTCCUnidade.Text = tcc.TCCUnidade;
                textBoxAcaoTCCSalaNome.Text = tcc.TCCSalaNome;
                textBoxAcaoTCCData.Text = tcc.TCCData.ToString();

                buttonAcaoTCCConfirmar.Hide();
                buttonAcaoTCCCancelar.Hide();

                textBoxAcaoTCCID.ReadOnly = true;
                textBoxAcaoTCCAlunoID.ReadOnly = true;
                textBoxAcaoTCCAlunoNome.ReadOnly = true;
                textBoxAcaoTCCTitulo.ReadOnly = true;
                textBoxAcaoTCCOrientadorID.ReadOnly = true;
                textBoxAcaoTCCOrientadorNome.ReadOnly = true;
                textBoxAcaoTCCGrandeArea.ReadOnly = true;
                textBoxAcaoTCCArea.ReadOnly = true;
                textBoxAcaoTCCSubarea.ReadOnly = true;
                textBoxAcaoTCCEspecialidade.ReadOnly = true;
                textBoxAcaoTCCResumo.ReadOnly = true;
                maskedTextBoxAcaoTCCPaginas.ReadOnly = true;
                textBoxAcaoTCCSalaID.ReadOnly = true;
                textBoxAcaoTCCUnidade.ReadOnly = true;
                textBoxAcaoTCCSalaNome.ReadOnly = true;
                dateTimePickerAcaoTCCData.Visible = false;

                textBoxAcaoTCCAlunoNome.Width = 264;
                buttonAcaoTCCAlunoSelecionar.Hide();
                textBoxAcaoTCCOrientadorNome.Width = 264;
                buttonAcaoTCCOrientadorSelecionar.Hide();
                textBoxAcaoTCCSalaNome.Width = 247;
                buttonAcaoTCCSalaSelecionar.Hide();
                textBoxAcaoTCCData.Visible = true;
                textBoxAcaoTCCData.Location = new Point(577, 201);

                labelAcaoTCCCO.Hide();
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
                TCC tcc = new TCC();
                TCCNegocios tccNegocios = new TCCNegocios();

                if (textBoxAcaoTCCAlunoID.Text != "")
                {
                    tcc.TCCAlunoID = Convert.ToInt32(textBoxAcaoTCCAlunoID.Text);
                    tcc.TCCAlunoNome = textBoxAcaoTCCAlunoNome.Text;
                }

                tcc.TCCTitulo = textBoxAcaoTCCTitulo.Text;

                if (textBoxAcaoTCCOrientadorID.Text != "")
                {
                    tcc.TCCOrientadorID = Convert.ToInt32(textBoxAcaoTCCOrientadorID.Text);
                    tcc.TCCOrientadorNome = textBoxAcaoTCCOrientadorNome.Text;
                }

                tcc.TCCGrandeArea = textBoxAcaoTCCGrandeArea.Text;
                tcc.TCCArea = textBoxAcaoTCCArea.Text;
                tcc.TCCSubarea = textBoxAcaoTCCSubarea.Text;
                tcc.TCCEspecialidade = textBoxAcaoTCCEspecialidade.Text;
                tcc.TCCResumo = textBoxAcaoTCCResumo.Text;
                if (maskedTextBoxAcaoTCCPaginas.Text != "")
                {
                    tcc.TCCPaginas = Convert.ToInt32(maskedTextBoxAcaoTCCPaginas.Text);
                }
                if (textBoxAcaoTCCSalaID.Text != "")
                {
                    tcc.TCCSalaID = Convert.ToInt32(textBoxAcaoTCCSalaID.Text);
                    tcc.TCCSalaNome = textBoxAcaoTCCSalaNome.Text;
                    tcc.TCCUnidade = textBoxAcaoTCCUnidade.Text;
                }

                tcc.TCCData = dateTimePickerAcaoTCCData.Value;

                if (tcc.TCCAlunoNome == "" || tcc.TCCOrientadorNome == "" ||
                        tcc.TCCTitulo == "" || tcc.TCCGrandeArea == "" || tcc.TCCArea == "" ||
                        tcc.TCCSubarea == "" || tcc.TCCEspecialidade == "" ||
                        textBoxAcaoTCCSalaID.Text == "")
                {
                    MessageBox.Show("Favor preencher todos os campos!");
                }
                else
                {
                    string retorno = tccNegocios.Inserir(tcc);

                    try
                    {
                        int tccID = Convert.ToInt32(retorno);

                        MessageBox.Show("Registro inserido com sucesso! Código cadastrado: " + tccID.ToString());
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível completar a operação! Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.No;
                    }
                }
            }

            if (this.Text == "Alterar TCC")
            {
                TCC tcc = new TCC();
                TCCNegocios tccNegocios = new TCCNegocios();

                tcc.TCCID = Convert.ToInt32(textBoxAcaoTCCID.Text);
                tcc.TCCAlunoID = Convert.ToInt32(textBoxAcaoTCCAlunoID.Text);
                tcc.TCCAlunoNome = textBoxAcaoTCCAlunoNome.Text;
                tcc.TCCTitulo = textBoxAcaoTCCTitulo.Text;
                tcc.TCCOrientadorID = Convert.ToInt32(textBoxAcaoTCCOrientadorID.Text);
                tcc.TCCOrientadorNome = textBoxAcaoTCCOrientadorNome.Text;
                tcc.TCCGrandeArea = textBoxAcaoTCCGrandeArea.Text;
                tcc.TCCArea = textBoxAcaoTCCArea.Text;
                tcc.TCCSubarea = textBoxAcaoTCCSubarea.Text;
                tcc.TCCEspecialidade = textBoxAcaoTCCEspecialidade.Text;
                tcc.TCCResumo = textBoxAcaoTCCResumo.Text;
                tcc.TCCPaginas = Convert.ToInt32(maskedTextBoxAcaoTCCPaginas.Text);
                tcc.TCCSalaID = Convert.ToInt32(textBoxAcaoTCCSalaID.Text);
                tcc.TCCSalaNome = textBoxAcaoTCCSalaNome.Text;
                tcc.TCCUnidade = textBoxAcaoTCCUnidade.Text;
                tcc.TCCData = dateTimePickerAcaoTCCData.Value;


                if (tcc.TCCAlunoNome == tccold.TCCAlunoNome &&
                tcc.TCCTitulo == tccold.TCCTitulo &&
                tcc.TCCOrientadorNome == tccold.TCCOrientadorNome &&
                tcc.TCCGrandeArea == tccold.TCCGrandeArea &&
                tcc.TCCArea == tccold.TCCArea &&
                tcc.TCCSubarea == tccold.TCCSubarea &&
                tcc.TCCEspecialidade == tccold.TCCEspecialidade &&
                tcc.TCCResumo == tccold.TCCResumo &&
                tcc.TCCPaginas == tccold.TCCPaginas &&
                tcc.TCCSalaNome == tccold.TCCSalaNome &&
                tcc.TCCUnidade == tccold.TCCUnidade &&
                tcc.TCCData == tccold.TCCData)
                {
                    MessageBox.Show("Os campos não foram alterados");
                }
                else
                {
                    if (tcc.TCCAlunoNome == "" || tcc.TCCOrientadorNome == "" ||
                        tcc.TCCTitulo == "" || tcc.TCCGrandeArea == "" || tcc.TCCArea == "" ||
                        tcc.TCCSubarea == "" || tcc.TCCEspecialidade == "")
                    {
                        MessageBox.Show("Favor preencher todos os campos!");
                    }
                    else
                    {
                        string retorno = tccNegocios.Alterar(tcc);
                        try
                        {
                            int tccID = Convert.ToInt32(retorno);

                            MessageBox.Show("Registro alterado com sucesso! Código cadastrado: " + tccID.ToString());
                            this.DialogResult = DialogResult.Yes;
                        }
                        catch
                        {
                            MessageBox.Show("Não foi possível completar a operação! Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.DialogResult = DialogResult.No;
                        }
                    }
                }
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
                textBoxAcaoTCCArea.Text = frmMenuSelecao.ValorRetorno2;
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
                textBoxAcaoTCCUnidade.Text = frmMenuSelecao.ValorRetorno2;
            }
        }

        private void buttonAcaoTCCTCCBanca_Click(object sender, EventArgs e)
        {
            BancaNegocios bancaNegocios = new BancaNegocios();

            if (textBoxAcaoTCCID.Text != "")
            {
                bancaID = bancaNegocios.RetornaBancaID(Convert.ToInt32(textBoxAcaoTCCID.Text));
                if (bancaID == 0)
                {
                    bancaID = Convert.ToInt32(bancaNegocios.InserirBanca(Convert.ToInt32(textBoxAcaoTCCID.Text)));
                }

                FrmMenuAcaoBanca frmMenuAcaoBanca = new FrmMenuAcaoBanca(this.Text, null, Convert.ToInt32(textBoxAcaoTCCID.Text), bancaID, textBoxAcaoTCCOrientadorNome.Text);
                frmMenuAcaoBanca.ShowDialog();
            }
            else
            {
                MessageBox.Show("É necessário primeiro concluir o cadastro do TCC!", "Aviso");
            }
        }

        private void FrmMenuAcaoTCC_Load(object sender, EventArgs e)
        {
            dateTimePickerAcaoTCCData.Value = DateTime.Now.Date;
        }
    }
}
