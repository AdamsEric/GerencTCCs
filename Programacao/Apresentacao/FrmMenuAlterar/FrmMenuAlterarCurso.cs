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
    public partial class FrmMenuAlterarCurso : Form
    {
        Curso cursoold = new Curso();
        public FrmMenuAlterarCurso(Curso curso)
        {
            InitializeComponent();

            textBoxAlterarCursoNome.Text = curso.CursoNome;
            textBoxAlterarCursoUnidadeID.Text = curso.CursoUnidadeID.ToString();
            textBoxAlterarCursoCoordenadorID.Text = curso.CursoCoordenador.ToString();

            cursoold = curso;
        }

        private void buttonAlterarCursoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAlterarCursoConfirmar_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();

            curso.CursoID = Convert.ToInt32(textBoxAlterarCursoID.Text);
            curso.CursoNome = textBoxAlterarCursoNome.Text;
            curso.CursoUnidadeID = Convert.ToInt32(textBoxAlterarCursoUnidadeID.Text);
            curso.CursoCoordenador = Convert.ToInt32(textBoxAlterarCursoCoordenadorID.Text);

            if (curso.CursoNome == cursoold.CursoNome && curso.CursoUnidadeID == cursoold.CursoUnidadeID &&
                curso.CursoCoordenador == cursoold.CursoCoordenador)
            {
                MessageBox.Show("Os campos não foram alterados");
            }
            else
            {

                if (curso.CursoNome == "" || curso.CursoUnidadeID.ToString() == "" ||
                    curso.CursoCoordenador.ToString() == "")
                {
                    MessageBox.Show("Favor preencher todos os campos!");
                }
                else
                {
                    CursoNegocios cursoNegocios = new CursoNegocios();
                    string retorno = cursoNegocios.Alterar(curso);

                    try
                    {
                        int cursoID = Convert.ToInt32(retorno);

                        MessageBox.Show("Registro inserido com sucesso! Código: " + cursoID.ToString());
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
