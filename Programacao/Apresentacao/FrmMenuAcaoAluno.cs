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
                comboBoxAcaoAlunoCursoNome.Text = aluno.AlunoCursoNome;
                alunoold = aluno;
            }
            else if (acao == "Consultar Aluno")
            {
                this.Text = "Consultar Aluno";
                textBoxAcaoAlunoID.Text = aluno.AlunoID.ToString();
                textBoxAcaoAlunoNome.Text = aluno.AlunoNome;
                textBoxAcaoAlunoMatricula.Text = aluno.AlunoMatricula;
                maskedTextBoxAcaoAlunoTelefone.Text = aluno.AlunoTelefone;
                comboBoxAcaoAlunoCursoNome.Text = aluno.AlunoCursoNome;

                buttonAcaoAlunoConfirmar.Hide();
                buttonAcaoAlunoCancelar.Hide();
                textBoxAcaoAlunoNome.Enabled = false;
                textBoxAcaoAlunoMatricula.Enabled = false;
                maskedTextBoxAcaoAlunoTelefone.Enabled = false;
                comboBoxAcaoAlunoCursoNome.Enabled = false;
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
                aluno.AlunoCursoNome = comboBoxAcaoAlunoCursoNome.SelectedValue.ToString();
                aluno.AlunoCursoID = alunoNegocios.RetornaCursoID(aluno.AlunoCursoNome);

                if (aluno.AlunoNome == "" && aluno.AlunoMatricula == "" && aluno.AlunoCursoNome == "")
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
                aluno.AlunoMatricula = textBoxAcaoAlunoMatricula.Text;
                aluno.AlunoTelefone = maskedTextBoxAcaoAlunoTelefone.Text;
                aluno.AlunoCursoNome = Convert.ToString(comboBoxAcaoAlunoCursoNome.SelectedValue);
                aluno.AlunoCursoID = alunoNegocios.RetornaCursoID(aluno.AlunoCursoNome);

                if (aluno.AlunoNome == alunoold.AlunoNome
                    && aluno.AlunoMatricula == alunoold.AlunoMatricula
                    && aluno.AlunoTelefone == alunoold.AlunoTelefone
                    && aluno.AlunoCursoNome == alunoold.AlunoCursoNome)
                {
                    MessageBox.Show("Os campos não foram alterados");
                }
                else
                {

                    if (aluno.AlunoNome == "" && aluno.AlunoMatricula == "" && aluno.AlunoCursoNome == "")
                    {
                        MessageBox.Show("Favor preencher todos os campos!");
                    }
                    else
                    {
                        string retorno = alunoNegocios.Alterar(aluno);
                        try
                        {
                            int alunoID = Convert.ToInt32(retorno);
                            
                            MessageBox.Show("Registro alterado com sucesso! Código: " + alunoID.ToString());
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
