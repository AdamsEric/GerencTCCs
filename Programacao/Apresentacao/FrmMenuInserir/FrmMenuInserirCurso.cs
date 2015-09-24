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
    public partial class FrmMenuInserirCurso : Form
    {
        public FrmMenuInserirCurso()
        {
            InitializeComponent();
        }

        private void buttonInserirCursoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInserirCursoConfirmar_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.CursoNome = textBoxInserirCursoNome.Text;
            curso.CursoUnidadeID = Convert.ToInt32(textBoxInserirCursoUnidadeID.Text);
            curso.CursoCoordenador = Convert.ToInt32(textBoxInserirCursoCoordenadorID.Text);

            if (curso.CursoNome == "" || curso.CursoUnidadeID.ToString() == "" ||
                curso.CursoCoordenador.ToString() == "")
            {
                MessageBox.Show("Favor preencher todos os campos!");
            }
            else
            {
                CursoNegocios cursoNegocios = new CursoNegocios();
                string retorno = cursoNegocios.Inserir(curso);

                try
                {
                    int cursoID = Convert.ToInt32(retorno);

                    MessageBox.Show("Registro inserido com sucesso! Código cadastrado: " + cursoID.ToString());
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
