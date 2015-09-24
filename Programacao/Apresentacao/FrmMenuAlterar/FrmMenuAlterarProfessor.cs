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
    public partial class FrmMenuAlterarProfessor : Form
    {
        Professor professorold = new Professor();

        public FrmMenuAlterarProfessor(Professor professor)
        {
            InitializeComponent();

            textBoxAlterarProfessorID.Text = professor.ProfessorID.ToString();
            textBoxAlterarProfessorNome.Text = professor.ProfessorNome;
            maskedTextBoxAlterarProfessorCPF.Text = professor.ProfessorCPF;
            textBoxAlterarProfessorMatricula.Text = professor.ProfessorMatricula;
            maskedTextBoxAlterarProfessorTelefone.Text = professor.ProfessorTelefone;

            professorold = professor;
        }

        private void buttonAlterarProfessorCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAlterarProfessorConfirmar_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();

            professor.ProfessorID = Convert.ToInt32(textBoxAlterarProfessorID.Text);
            professor.ProfessorNome = textBoxAlterarProfessorNome.Text;
            professor.ProfessorCPF = maskedTextBoxAlterarProfessorCPF.Text;
            professor.ProfessorMatricula = textBoxAlterarProfessorMatricula.Text;
            professor.ProfessorTelefone = maskedTextBoxAlterarProfessorTelefone.Text;

            if (professor.ProfessorNome == professorold.ProfessorNome &&
                professor.ProfessorCPF == professorold.ProfessorCPF &&
                professor.ProfessorMatricula == professorold.ProfessorMatricula &&
                professor.ProfessorTelefone ==  professorold.ProfessorTelefone)
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
                    if (maskedTextBoxAlterarProfessorCPF.MaskFull)
                    {
                        ProfessorNegocios professorNegocios = new ProfessorNegocios();
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
                    else
                    {
                        MessageBox.Show("CPF Inválido!");
                    }
                }
            }
        }
    }
}
