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
    public partial class FrmMenuAcaoCurso : Form
    {
        Curso cursoold = new Curso();

        public FrmMenuAcaoCurso(Curso curso, string acao)
        {
            InitializeComponent();
            CursoNegocios cursoNegocios = new CursoNegocios();
            if (acao == "Inserir Curso")
            {
                this.Text = "Inserir Curso";
            }
            else if (acao == "Alterar Curso")
            {
                this.Text = "Alterar Curso";
                textBoxAcaoCursoID.Text = curso.CursoID.ToString();
                textBoxAcaoCursoNome.Text = curso.CursoNome;
                comboBoxAcaoCursoUnidadeNome.Text = curso.CursoUnidadeNome;
                cursoold = curso;
            }
            else if(acao == "Consultar Curso")
            {
                this.Text = "Consultar Curso";
                textBoxAcaoCursoID.Text = curso.CursoID.ToString();
                textBoxAcaoCursoNome.Text = curso.CursoNome;
                comboBoxAcaoCursoUnidadeNome.SelectedValue = curso.CursoUnidadeNome;

                buttonAcaoCursoConfirmar.Hide();
                buttonAcaoCursoCancelar.Hide();
                textBoxAcaoCursoNome.Enabled = false;
                comboBoxAcaoCursoUnidadeNome.Enabled = false;
                labelAcaoCursoCO.Hide();
            }
        }

        private void buttonAcaoCursoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAcaoCursoConfirmar_Click(object sender, EventArgs e)
        {

            if (this.Text == "Inserir Curso")
            {
                Curso curso = new Curso();
                CursoNegocios cursoNegocios = new CursoNegocios();

                curso.CursoNome = textBoxAcaoCursoNome.Text;
                curso.CursoUnidadeNome = "";

                if (comboBoxAcaoCursoUnidadeNome.Text != "")
                {
                    curso.CursoUnidadeNome = comboBoxAcaoCursoUnidadeNome.Text.ToString();
                    curso.CursoUnidadeID = cursoNegocios.RetornaIDCurso(curso.CursoUnidadeNome);
                }

                if (curso.CursoNome == "" || curso.CursoUnidadeNome == "")
                {
                    MessageBox.Show("Favor preencher todos os campos!");
                }
                else
                {
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

            if (this.Text == "Alterar Curso")
            {
                Curso curso = new Curso();
                CursoNegocios cursoNegocios = new CursoNegocios();

                curso.CursoID = Convert.ToInt32(textBoxAcaoCursoID.Text);
                curso.CursoNome = textBoxAcaoCursoNome.Text;
                curso.CursoUnidadeNome = Convert.ToString(comboBoxAcaoCursoUnidadeNome.Text);

                if (curso.CursoUnidadeNome != "")
                {
                    curso.CursoUnidadeID = cursoNegocios.RetornaIDCurso(curso.CursoUnidadeNome);
                }

                if (curso.CursoNome == cursoold.CursoNome && curso.CursoUnidadeNome == cursoold.CursoUnidadeNome)
                {
                    MessageBox.Show("Os campos não foram alterados");
                }
                else
                {

                    if (curso.CursoNome == "" || curso.CursoUnidadeNome == "")
                    {
                        MessageBox.Show("Favor preencher todos os campos!");
                    }
                    else
                    {
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

        private void comboBoxAcaoCursoUnidadeNome_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxAcaoCursoUnidadeNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonAcaoCursoConfirmar.PerformClick();
            }
        }

        private void textBoxAcaoCursoNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonAcaoCursoConfirmar.PerformClick();
            }
        }

        private void FrmMenuAcaoCurso_Load(object sender, EventArgs e)
        {
            this.tblUnidadeTableAdapter1.Fill(this.dataSetUnidade.tblUnidade);
            if (cursoold.CursoUnidadeNome == "")
            {
                comboBoxAcaoCursoUnidadeNome.Text = "";
            }
            else
            {
                comboBoxAcaoCursoUnidadeNome.Text = cursoold.CursoUnidadeNome;
            }
        }
    }
}
