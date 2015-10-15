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
    public partial class FrmMenuAcaoAluno : Form
    {
        Aluno alunoold = new Aluno();

        public FrmMenuAcaoAluno(Aluno aluno, string acao)
        {
            InitializeComponent();

            AlunoNegocios alunoNegocios = new AlunoNegocios();

            if (acao == "Inserir Aluno")
            {
                this.Text = "Inserir Aluno";
            }
            else if (acao == "Alterar Aluno")
            {
                this.Text = "Alterar Aluno";
                textBoxAcaoAlunoID.Text = aluno.AlunoID.ToString();
                textBoxAcaoAlunoNome.Text = aluno.AlunoNome;
                textBoxAcaoAlunoMatricula.Text = aluno.AlunoMatricula;
                maskedTextBoxAcaoAlunoTelefone.Text = aluno.AlunoTelefone;
                comboBoxAcaoAlunoUnidadeNome.Text = aluno.AlunoUnidadeNome;
                comboBoxAcaoAlunoCursoNome.Text = aluno.AlunoCursoNome;
                alunoold = aluno;
            }
            else if (acao == "Consultar Aluno")
            {
                this.Text = "Consultar Aluno";
                textBoxAcaoAlunoID.Text = aluno.AlunoID.ToString();
                textBoxAcaoAlunoNome.Text = aluno.AlunoNome;
                comboBoxAcaoAlunoUnidadeNome.Text = aluno.AlunoUnidadeNome;

                buttonAcaoAlunoConfirmar.Hide();
                buttonAcaoAlunoCancelar.Hide();
                textBoxAcaoAlunoNome.Enabled = false;
                comboBoxAcaoAlunoUnidadeNome.Enabled = false;
                labelAcaoAlunoCO.Hide();
            }
        }

        private void buttonAcaoAlunoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAcaoAlunoConfirmar_Click(object sender, EventArgs e)
        {
            if (this.Text == "Inserir Aluno")
            {
                Aluno aluno = new Aluno();
                AlunoNegocios alunoNegocios = new AlunoNegocios();

                aluno.AlunoNome = textBoxAcaoAlunoNome.Text;
                aluno.AlunoMatricula = textBoxAcaoAlunoMatricula.Text;
                aluno.AlunoTelefone = maskedTextBoxAcaoAlunoTelefone.Text;
                aluno.AlunoUnidadeNome = comboBoxAcaoAlunoUnidadeNome.SelectedValue.ToString();
                aluno.AlunoUnidadeID = alunoNegocios.RetornaIDUnidade(aluno.AlunoUnidadeNome);

                if (aluno.AlunoUnidadeNome == "")
                {
                    MessageBox.Show("Favor selecione primeiro a Unidade!");
                }
                else
                {
                    aluno.AlunoCursoNome = comboBoxAcaoAlunoCursoNome.SelectedValue.ToString();
                    aluno.AlunoCursoID = alunoNegocios.RetornaIDCurso(aluno.AlunoCursoNome, aluno.AlunoUnidadeID);
                }

                if (aluno.AlunoNome == "" && aluno.AlunoMatricula == "")
                {
                    MessageBox.Show("Favor preencher todos os campos!");
                }
                else
                {
                    string retorno = alunoNegocios.Inserir(aluno);

                    try
                    {
                        int alunoID = Convert.ToInt32(retorno);

                        MessageBox.Show("Registro inserido com sucesso! Código cadastrado: " + alunoID.ToString());
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível completar a operação! Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.No;
                    }
                }
            }

            if (this.Text == "Alterar Aluno")
            {
                Aluno aluno = new Aluno();
                AlunoNegocios alunoNegocios = new AlunoNegocios();

                aluno.AlunoID = Convert.ToInt32(textBoxAcaoAlunoID.Text);
                aluno.AlunoNome = textBoxAcaoAlunoNome.Text;
                aluno.AlunoUnidadeNome = Convert.ToString(comboBoxAcaoAlunoUnidadeNome.Text);

                if (aluno.AlunoUnidadeNome != "")
                {
                    aluno.AlunoUnidadeID = alunoNegocios.RetornaIDUnidade(aluno.AlunoUnidadeNome);
                }

                if (aluno.AlunoNome == alunoold.AlunoNome && aluno.AlunoUnidadeNome == alunoold.AlunoUnidadeNome)
                {
                    MessageBox.Show("Os campos não foram alterados");
                }
                else
                {

                    if (aluno.AlunoNome == "" || aluno.AlunoUnidadeNome == "")
                    {
                        MessageBox.Show("Favor preencher todos os campos!");
                    }
                    else
                    {
                        string retorno = alunoNegocios.Alterar(aluno);

                        try
                        {
                            int alunoID = Convert.ToInt32(retorno);

                            MessageBox.Show("Registro inserido com sucesso! Código: " + alunoID.ToString());
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

        private void comboBoxAcaoAlunoUnidadeNome_Click(object sender, EventArgs e)
        {
            this.tblUnidadeTableAdapter.Fill(this.gerencTCCsDataSet16.tblUnidade);
            if (alunoold.AlunoUnidadeNome == "")
            {
                comboBoxAcaoAlunoUnidadeNome.Text = "";
            }
            else
            {
                comboBoxAcaoAlunoUnidadeNome.Text = alunoold.AlunoUnidadeNome;
            }
        }

        private void comboBoxAcaoAlunoCursoNome_Click(object sender, EventArgs e)
        {
            this.tblCursoTableAdapter.Fill(this.gerencTCCsDataSet17.tblCurso);
                if (alunoold.AlunoCursoNome == "")
                {
                    comboBoxAcaoAlunoCursoNome.Text = "";
                }
                else
                {
                    comboBoxAcaoAlunoCursoNome.Text = alunoold.AlunoCursoNome;
                }
        }
    }
}
