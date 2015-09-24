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

        private void buttonInserirProfessorConfirmar_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();

            professor.ProfessorNome = textBoxInserirProfessorNome.Text;
            professor.ProfessorCPF = maskedTextBoxInserirProfessorCPF.Text;
            professor.ProfessorMatricula = textBoxInserirProfessorMatricula.Text;
            professor.ProfessorTelefone = maskedTextBoxInserirProfessorTelefone.Text;

            if (professor.ProfessorNome == "" || professor.ProfessorCPF == "" ||
                professor.ProfessorMatricula == "")
            {
                MessageBox.Show("Favor preencher todos os campos!");
            }
            else
            {
                ProfessorNegocios professorNegocios = new ProfessorNegocios();
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
}
