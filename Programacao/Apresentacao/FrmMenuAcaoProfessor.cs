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
    public partial class FrmMenuAcaoProfessor : Form
    {
        Professor professorold = new Professor();

        public FrmMenuAcaoProfessor(Professor professor, string acao)
        {
            InitializeComponent();

            if (acao == "Inserir Professor")
            {
                this.Text = "Inserir Professor";
            }
            else if (acao == "Alterar Professor")
            {
                this.Text = "Alterar Professor";
                textBoxAcaoProfessorID.Text = professor.ProfessorID.ToString();
                textBoxAcaoProfessorNome.Text = professor.ProfessorNome;
                textBoxAcaoProfessorMatricula.Text = professor.ProfessorMatricula;
                maskedTextBoxAcaoProfessorTelefone.Text = professor.ProfessorTelefone;
            }
            else if (acao == "Consultar Professor")
            {
                this.Text = "Consultar Professor";
                textBoxAcaoProfessorID.Text = professor.ProfessorID.ToString();
                textBoxAcaoProfessorNome.Text = professor.ProfessorNome;
                textBoxAcaoProfessorMatricula.Text = professor.ProfessorMatricula;
                maskedTextBoxAcaoProfessorTelefone.Text = professor.ProfessorTelefone;

                buttonAcaoProfessorConfirmar.Hide();
                buttonAcaoProfessorCancelar.Hide();
                textBoxAcaoProfessorID.ReadOnly = true;
                textBoxAcaoProfessorNome.ReadOnly = true;
                textBoxAcaoProfessorMatricula.ReadOnly = true;
                maskedTextBoxAcaoProfessorTelefone.ReadOnly = true;
                labelAcaoProfessorCO.Hide();
            }

            professorold = professor;
        }

        private void buttonAcaoProfessorCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAcaoProfessorConfirmar_Click(object sender, EventArgs e)
        {
            if (this.Text == "Inserir Professor")
            {
                Professor professor = new Professor();
                ProfessorNegocios professorNegocios = new ProfessorNegocios();

                professor.ProfessorNome = textBoxAcaoProfessorNome.Text;
                professor.ProfessorMatricula = textBoxAcaoProfessorMatricula.Text;
                professor.ProfessorTelefone = maskedTextBoxAcaoProfessorTelefone.Text;

                if (professor.ProfessorNome == "" || professor.ProfessorMatricula == "")
                {
                    MessageBox.Show("Favor preencher todos os campos!");
                }
                else
                {
                    int professorid = 0;
                    int verificacao = professorNegocios.VerificarProfessorExistente(textBoxAcaoProfessorMatricula.Text, professorid);

                    if (verificacao != 0)
                    {
                        MessageBox.Show("Já existe professor cadastrado com esta matrícula!");
                    }
                    else
                    {
                        string retorno = professorNegocios.Inserir(professor);

                        try
                        {
                            int professorID = Convert.ToInt32(retorno);

                            MessageBox.Show("Registro inserido com sucesso! Código cadastrado: " + professorID.ToString());
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
            if (this.Text == "Alterar Professor")
            {
                Professor professor = new Professor();

                professor.ProfessorID = Convert.ToInt32(textBoxAcaoProfessorID.Text);
                professor.ProfessorNome = textBoxAcaoProfessorNome.Text;
                professor.ProfessorMatricula = textBoxAcaoProfessorMatricula.Text;
                professor.ProfessorTelefone = maskedTextBoxAcaoProfessorTelefone.Text;

                if (professor.ProfessorNome == professorold.ProfessorNome &&
                    professor.ProfessorMatricula == professorold.ProfessorMatricula &&
                    professor.ProfessorTelefone == professorold.ProfessorTelefone)
                {
                    MessageBox.Show("Os campos não foram alterados");
                }
                else
                {

                    if (professor.ProfessorNome == "" || professor.ProfessorMatricula == "" ||
                        professor.ProfessorTelefone == "")
                    {
                        MessageBox.Show("Favor preencher todos os campos!");
                    }
                    else
                    {
                        ProfessorNegocios professorNegocios = new ProfessorNegocios();

                        int verificacao = professorNegocios.VerificarProfessorExistente(textBoxAcaoProfessorMatricula.Text, Convert.ToInt32(textBoxAcaoProfessorID.Text));

                        if (verificacao != 0)
                        {
                            MessageBox.Show("Já existe professor cadastrado com esta matrícula!");
                        }
                        else
                        {
                            string retorno = professorNegocios.Alterar(professor);

                            try
                            {
                                int professorID = Convert.ToInt32(retorno);

                                MessageBox.Show("Registro inserido com sucesso! Código: " + professorID.ToString());
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
        }

        private void textBoxAcaoProfessorNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonAcaoProfessorConfirmar.PerformClick();
            }
        }

        private void textBoxAcaoProfessorMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonAcaoProfessorConfirmar.PerformClick();
            }
        }

        private void maskedTextBoxAcaoProfessorTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonAcaoProfessorConfirmar.PerformClick();
            }
        }
    }
}
