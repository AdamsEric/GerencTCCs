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
    public partial class FrmMenuSelecao : Form
    {
        public int ValorID
        {
            get { return Convert.ToInt32(labelIDSelecionado.Text); }
            set { labelIDSelecionado.Text = Convert.ToString(value); }
        }

        public string ValorRetorno1
        {
            get { return labelCampo1Selecionado.Text; }
            set { labelCampo1Selecionado.Text = value; }
        }

        public string ValorRetorno2
        {
            get { return labelCampo2Selecionado.Text; }
            set { labelCampo2Selecionado.Text = value; }
        }

        public string ValorRetorno3
        {
            get { return labelCampo3Selecionado.Text; }
            set { labelCampo3Selecionado.Text = value; }
        }

        public FrmMenuSelecao(string modulo)
        {
            InitializeComponent();

            labelModuloTitulo.Text = modulo;

            if (labelModuloTitulo.Text == "TCCs")
            {
                labelModuloTitulo.Text = "TCCs";
                labelPesquisaTipo.Text = "Título: ";
                //Pesquisas
                labelPesquisarEscolha.Visible = true;
                labelPesquisarEscolha.Location = new Point(506,278);
                radioButtonPesquisarPorTitulo.Visible = true;
                radioButtonPesquisarPorTitulo.Checked = true;
                radioButtonPesquisarPorTitulo.Location = new Point(588,276);
                radioButtonPesquisarPorAluno.Visible = true;
                radioButtonPesquisarPorAluno.Checked = false;
                radioButtonPesquisarPorAluno.Location = new Point(641,276);
                radioButtonPesquisarPorNome.Visible = false;
                radioButtonPesquisarPorNome.Checked = false;
                radioButtonPesquisarPorNome.Location = new Point();
                radioButtonPesquisarPorMatricula.Visible = false;
                radioButtonPesquisarPorMatricula.Checked = false;
                radioButtonPesquisarPorMatricula.Location = new Point();
                radioButtonPesquisarPorDescricao.Visible = false;
                radioButtonPesquisarPorDescricao.Checked = false;
                radioButtonPesquisarPorDescricao.Location = new Point();
                radioButtonPesquisarPorCodigo.Visible = false;
                radioButtonPesquisarPorCodigo.Checked = false;
                radioButtonPesquisarPorCodigo.Location = new Point();
                radioButtonPesquisarPorLogin.Visible = false;
                radioButtonPesquisarPorLogin.Checked = false;
                radioButtonPesquisarPorLogin.Location = new Point();
                //Filtros
                groupBoxFiltros.Visible = true;
                labelFiltrarPorUnidade.Visible = true;
                comboBoxFiltroUnidade.Visible = true;
                labelFiltrarPorCurso.Visible = true;
                comboBoxFiltroCurso.Visible = true;
                labelFiltrarPorData.Visible = true;
                dateTimePickerFiltroData.Visible = true;
                labelFiltrarPorTipo.Visible = false;
                labelFiltrarPorTipo.Location = new Point();
                comboBoxFiltroTipo.Visible = false;
                comboBoxFiltroTipo.Location = new Point();
                labelFiltrarPorGrupo.Visible = false;
                labelFiltrarPorGrupo.Location = new Point();
                comboBoxFiltroGrupo.Visible = false;
                comboBoxFiltroGrupo.Location = new Point();

                //DataGrid
                dataGridView.DataSource = null;
            }

            if (labelModuloTitulo.Text == "Alunos")
            {
                labelModuloTitulo.Text = "Alunos";
                labelPesquisaTipo.Text = "Nome: ";
                //Pesquisas
                labelPesquisarEscolha.Visible = true;
                labelPesquisarEscolha.Location = new Point(488, 278);
                radioButtonPesquisarPorTitulo.Visible = false;
                radioButtonPesquisarPorTitulo.Checked = false;
                radioButtonPesquisarPorTitulo.Location = new Point();
                radioButtonPesquisarPorAluno.Visible = false;
                radioButtonPesquisarPorAluno.Checked = false;
                radioButtonPesquisarPorAluno.Location = new Point();
                radioButtonPesquisarPorNome.Visible = true;
                radioButtonPesquisarPorNome.Checked = true;
                radioButtonPesquisarPorNome.Location = new Point(566, 276);
                radioButtonPesquisarPorMatricula.Visible = true;
                radioButtonPesquisarPorMatricula.Checked = false;
                radioButtonPesquisarPorMatricula.Location = new Point(623, 276);
                radioButtonPesquisarPorDescricao.Visible = false;
                radioButtonPesquisarPorDescricao.Checked = false;
                radioButtonPesquisarPorDescricao.Location = new Point();
                radioButtonPesquisarPorCodigo.Visible = false;
                radioButtonPesquisarPorCodigo.Checked = false;
                radioButtonPesquisarPorCodigo.Location = new Point();
                radioButtonPesquisarPorLogin.Visible = false;
                radioButtonPesquisarPorLogin.Checked = false;
                radioButtonPesquisarPorLogin.Location = new Point();
                //Filtros
                groupBoxFiltros.Visible = true;
                labelFiltrarPorUnidade.Visible = true;
                comboBoxFiltroUnidade.Visible = true;
                labelFiltrarPorCurso.Visible = true;
                comboBoxFiltroCurso.Visible = true;
                labelFiltrarPorData.Visible = false;
                dateTimePickerFiltroData.Visible = false;
                labelFiltrarPorTipo.Visible = false;
                labelFiltrarPorTipo.Location = new Point();
                comboBoxFiltroTipo.Visible = false;
                comboBoxFiltroTipo.Location = new Point();
                labelFiltrarPorGrupo.Visible = false;
                labelFiltrarPorGrupo.Location = new Point();
                comboBoxFiltroGrupo.Visible = false;
                comboBoxFiltroGrupo.Location = new Point();
                //DataGrid
                dataGridView.DataSource = null;
            }

            if (labelModuloTitulo.Text == "Professores")
            {
                labelModuloTitulo.Text = "Professores";
                labelPesquisaTipo.Text = "Nome: ";
                //Pesquisas
                labelPesquisarEscolha.Visible = true;
                labelPesquisarEscolha.Location = new Point(488, 278);
                radioButtonPesquisarPorTitulo.Visible = false;
                radioButtonPesquisarPorTitulo.Checked = false;
                radioButtonPesquisarPorTitulo.Location = new Point();
                radioButtonPesquisarPorAluno.Visible = false;
                radioButtonPesquisarPorAluno.Checked = false;
                radioButtonPesquisarPorAluno.Location = new Point();
                radioButtonPesquisarPorNome.Visible = true;
                radioButtonPesquisarPorNome.Checked = true;
                radioButtonPesquisarPorNome.Location = new Point(566, 276);
                radioButtonPesquisarPorMatricula.Visible = true;
                radioButtonPesquisarPorMatricula.Checked = false;
                radioButtonPesquisarPorMatricula.Location = new Point(623, 276);
                radioButtonPesquisarPorDescricao.Visible = false;
                radioButtonPesquisarPorDescricao.Checked = false;
                radioButtonPesquisarPorDescricao.Location = new Point();
                radioButtonPesquisarPorCodigo.Visible = false;
                radioButtonPesquisarPorCodigo.Checked = false;
                radioButtonPesquisarPorCodigo.Location = new Point();
                radioButtonPesquisarPorLogin.Visible = false;
                radioButtonPesquisarPorLogin.Checked = false;
                radioButtonPesquisarPorLogin.Location = new Point();
                //Filtros
                groupBoxFiltros.Visible = false;
                labelFiltrarPorUnidade.Visible = false;
                comboBoxFiltroUnidade.Visible = false;
                labelFiltrarPorCurso.Visible = false;
                comboBoxFiltroCurso.Visible = false;
                labelFiltrarPorData.Visible = false;
                dateTimePickerFiltroData.Visible = false;
                labelFiltrarPorTipo.Visible = false;
                labelFiltrarPorTipo.Location = new Point();
                comboBoxFiltroTipo.Visible = false;
                comboBoxFiltroTipo.Location = new Point();
                labelFiltrarPorGrupo.Visible = false;
                labelFiltrarPorGrupo.Location = new Point();
                comboBoxFiltroGrupo.Visible = false;
                comboBoxFiltroGrupo.Location = new Point();
                //DataGrid
                dataGridView.DataSource = null;
            }

            if (labelModuloTitulo.Text == "Cursos")
            {
                labelModuloTitulo.Text = "Cursos";
                labelPesquisaTipo.Text = "Nome: ";
                //Pesquisas
                labelPesquisarEscolha.Visible = false;
                radioButtonPesquisarPorTitulo.Visible = false;
                radioButtonPesquisarPorTitulo.Checked = false;
                radioButtonPesquisarPorTitulo.Location = new Point();
                radioButtonPesquisarPorAluno.Visible = false;
                radioButtonPesquisarPorAluno.Checked = false;
                radioButtonPesquisarPorAluno.Location = new Point();
                radioButtonPesquisarPorNome.Visible = false;
                radioButtonPesquisarPorNome.Checked = true;
                radioButtonPesquisarPorNome.Location = new Point();
                radioButtonPesquisarPorMatricula.Visible = false;
                radioButtonPesquisarPorMatricula.Checked = false;
                radioButtonPesquisarPorMatricula.Location = new Point();
                radioButtonPesquisarPorDescricao.Visible = false;
                radioButtonPesquisarPorDescricao.Checked = false;
                radioButtonPesquisarPorDescricao.Location = new Point();
                radioButtonPesquisarPorCodigo.Visible = false;
                radioButtonPesquisarPorCodigo.Checked = false;
                radioButtonPesquisarPorCodigo.Location = new Point();
                radioButtonPesquisarPorLogin.Visible = false;
                radioButtonPesquisarPorLogin.Checked = false;
                radioButtonPesquisarPorLogin.Location = new Point();
                //Filtros
                groupBoxFiltros.Visible = true;
                labelFiltrarPorUnidade.Visible = true;
                comboBoxFiltroUnidade.Visible = true;
                labelFiltrarPorCurso.Visible = false;
                comboBoxFiltroCurso.Visible = false;
                labelFiltrarPorData.Visible = false;
                dateTimePickerFiltroData.Visible = false;
                labelFiltrarPorTipo.Visible = false;
                labelFiltrarPorTipo.Location = new Point();
                comboBoxFiltroTipo.Visible = false;
                comboBoxFiltroTipo.Location = new Point();
                labelFiltrarPorGrupo.Visible = false;
                labelFiltrarPorGrupo.Location = new Point();
                comboBoxFiltroGrupo.Visible = false;
                comboBoxFiltroGrupo.Location = new Point();
                //DataGrid
                dataGridView.DataSource = null;
            }

            if (labelModuloTitulo.Text == "Unidades")
            {
                labelModuloTitulo.Text = "Unidades";
                labelPesquisaTipo.Text = "Nome: ";
                //Pesquisas
                labelPesquisarEscolha.Visible = false;
                radioButtonPesquisarPorTitulo.Visible = false;
                radioButtonPesquisarPorTitulo.Checked = false;
                radioButtonPesquisarPorTitulo.Location = new Point();
                radioButtonPesquisarPorAluno.Visible = false;
                radioButtonPesquisarPorAluno.Checked = false;
                radioButtonPesquisarPorAluno.Location = new Point();
                radioButtonPesquisarPorNome.Visible = false;
                radioButtonPesquisarPorNome.Checked = true;
                radioButtonPesquisarPorNome.Location = new Point();
                radioButtonPesquisarPorMatricula.Visible = false;
                radioButtonPesquisarPorMatricula.Checked = false;
                radioButtonPesquisarPorMatricula.Location = new Point();
                radioButtonPesquisarPorDescricao.Visible = false;
                radioButtonPesquisarPorDescricao.Checked = false;
                radioButtonPesquisarPorDescricao.Location = new Point();
                radioButtonPesquisarPorCodigo.Visible = false;
                radioButtonPesquisarPorCodigo.Checked = false;
                radioButtonPesquisarPorCodigo.Location = new Point();
                radioButtonPesquisarPorLogin.Visible = false;
                radioButtonPesquisarPorLogin.Checked = false;
                radioButtonPesquisarPorLogin.Location = new Point();
                //Filtros
                groupBoxFiltros.Visible = false;
                labelFiltrarPorUnidade.Visible = false;
                comboBoxFiltroUnidade.Visible = false;
                labelFiltrarPorCurso.Visible = false;
                comboBoxFiltroCurso.Visible = false;
                labelFiltrarPorData.Visible = false;
                dateTimePickerFiltroData.Visible = false;
                labelFiltrarPorTipo.Visible = false;
                labelFiltrarPorTipo.Location = new Point();
                comboBoxFiltroTipo.Visible = false;
                comboBoxFiltroTipo.Location = new Point();
                labelFiltrarPorGrupo.Visible = false;
                labelFiltrarPorGrupo.Location = new Point();
                comboBoxFiltroGrupo.Visible = false;
                comboBoxFiltroGrupo.Location = new Point();
                //DataGrid
                dataGridView.DataSource = null;
            }

            if (labelModuloTitulo.Text == "Salas")
            {
                labelModuloTitulo.Text = "Salas";
                labelPesquisaTipo.Text = "Código: ";
                //Pesquisas
                labelPesquisarEscolha.Visible = true;
                radioButtonPesquisarPorTitulo.Visible = false;
                radioButtonPesquisarPorTitulo.Checked = false;
                radioButtonPesquisarPorTitulo.Location = new Point();
                radioButtonPesquisarPorAluno.Visible = false;
                radioButtonPesquisarPorAluno.Checked = false;
                radioButtonPesquisarPorAluno.Location = new Point();
                radioButtonPesquisarPorNome.Visible = true;
                radioButtonPesquisarPorNome.Checked = true;
                radioButtonPesquisarPorNome.Location = new Point(588, 276);
                radioButtonPesquisarPorMatricula.Visible = false;
                radioButtonPesquisarPorMatricula.Checked = false;
                radioButtonPesquisarPorMatricula.Location = new Point();
                radioButtonPesquisarPorDescricao.Visible = true;
                radioButtonPesquisarPorDescricao.Checked = false;
                radioButtonPesquisarPorDescricao.Location = new Point(641, 276);
                radioButtonPesquisarPorCodigo.Visible = false;
                radioButtonPesquisarPorCodigo.Checked = false;
                radioButtonPesquisarPorCodigo.Location = new Point();
                radioButtonPesquisarPorLogin.Visible = false;
                radioButtonPesquisarPorLogin.Checked = false;
                radioButtonPesquisarPorLogin.Location = new Point();
                //Filtros
                groupBoxFiltros.Visible = true;
                labelFiltrarPorUnidade.Visible = true;
                comboBoxFiltroUnidade.Visible = true;
                labelFiltrarPorCurso.Visible = false;
                comboBoxFiltroCurso.Visible = false;
                labelFiltrarPorData.Visible = false;
                dateTimePickerFiltroData.Visible = false;
                labelFiltrarPorTipo.Visible = true;
                labelFiltrarPorTipo.Location = new Point(28,48);
                comboBoxFiltroTipo.Visible = true;
                comboBoxFiltroTipo.Location = new Point(68,44);
                labelFiltrarPorGrupo.Visible = false;
                labelFiltrarPorGrupo.Location = new Point();
                comboBoxFiltroGrupo.Visible = false;
                comboBoxFiltroGrupo.Location = new Point();
                //DataGrid
                dataGridView.DataSource = null;
            }

            if (labelModuloTitulo.Text == "Usuários")
            {
                labelModuloTitulo.Text = "Usuários";
                labelPesquisaTipo.Text = "Nome: ";
                //Pesquisas
                labelPesquisarEscolha.Visible = true;
                radioButtonPesquisarPorTitulo.Visible = false;
                radioButtonPesquisarPorTitulo.Checked = false;
                radioButtonPesquisarPorTitulo.Location = new Point();
                radioButtonPesquisarPorAluno.Visible = false;
                radioButtonPesquisarPorAluno.Checked = false;
                radioButtonPesquisarPorAluno.Location = new Point();
                radioButtonPesquisarPorNome.Visible = true;
                radioButtonPesquisarPorNome.Checked = true;
                radioButtonPesquisarPorNome.Location = new Point(588, 276);
                radioButtonPesquisarPorMatricula.Visible = false;
                radioButtonPesquisarPorMatricula.Checked = false;
                radioButtonPesquisarPorMatricula.Location = new Point();
                radioButtonPesquisarPorDescricao.Visible = false;
                radioButtonPesquisarPorDescricao.Checked = false;
                radioButtonPesquisarPorDescricao.Location = new Point();
                radioButtonPesquisarPorCodigo.Visible = false;
                radioButtonPesquisarPorCodigo.Checked = false;
                radioButtonPesquisarPorCodigo.Location = new Point();
                radioButtonPesquisarPorLogin.Visible = true;
                radioButtonPesquisarPorLogin.Checked = false;
                radioButtonPesquisarPorLogin.Location = new Point(641, 276);
                //Filtros
                groupBoxFiltros.Visible = true;
                labelFiltrarPorUnidade.Visible = false;
                comboBoxFiltroUnidade.Visible = false;
                labelFiltrarPorCurso.Visible = false;
                comboBoxFiltroCurso.Visible = false;
                labelFiltrarPorData.Visible = false;
                dateTimePickerFiltroData.Visible = false;
                labelFiltrarPorTipo.Visible = false;
                labelFiltrarPorTipo.Location = new Point();
                comboBoxFiltroTipo.Visible = false;
                comboBoxFiltroTipo.Location = new Point();
                labelFiltrarPorGrupo.Visible = true;
                labelFiltrarPorGrupo.Location = new Point(15,19);
                comboBoxFiltroGrupo.Visible = true;
                comboBoxFiltroGrupo.Location = new Point(68,15);
                //DataGrid
                dataGridView.DataSource = null;
            }
        }

        private void radioButtonPesquisarPorTitulo_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisaTipo.Text = "Título: ";
        }

        private void radioButtonPesquisarPorAluno_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisaTipo.Text = "Aluno: ";
        }

        private void radioButtonPesquisarPorNome_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisaTipo.Text = "Nome: ";
        }

        private void radioButtonPesquisarPorMatricula_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisaTipo.Text = "Matricula: ";
        }

        private void radioButtonPesquisarPorLogin_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisaTipo.Text = "Login: ";
        }

        private void radioButtonPesquisarPorCodigo_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisaTipo.Text = "Código: ";
        }

        private void radioButtonPesquisarPorDescricao_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisaTipo.Text = "Descrição: ";
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma registro selecionado!", "Erro");
                return;
            }

            if (labelModuloTitulo.Text == "Unidades")
            {
                Unidade unidadeSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Unidade);
                FrmMenuAcaoUnidade frmMenuAcaoUnidade = new FrmMenuAcaoUnidade(unidadeSelecao, "Consultar Unidade");
                frmMenuAcaoUnidade.ShowDialog();
            }

            if (labelModuloTitulo.Text == "Cursos")
            {
                Curso cursoSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Curso);
                FrmMenuAcaoCurso frmMenuAcaoCurso = new FrmMenuAcaoCurso(cursoSelecao, "Consultar Curso");
                frmMenuAcaoCurso.ShowDialog();
            }

            if (labelModuloTitulo.Text == "Professores")
            {
                Professor professorSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Professor);
                FrmMenuAcaoProfessor frmMenuAcaoProfessor = new FrmMenuAcaoProfessor(professorSelecao, "Consultar Professor");
                frmMenuAcaoProfessor.ShowDialog();
            }

            if (labelModuloTitulo.Text == "Alunos")
            {
                Aluno alunoSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Aluno);
                FrmMenuAcaoAluno frmMenuAcaoAluno = new FrmMenuAcaoAluno(alunoSelecao, "Consultar Aluno");
                frmMenuAcaoAluno.ShowDialog();
            }
        }

        private void RealizarPesquisa()
        {
            if (labelModuloTitulo.Text == "Unidades")
            {
                UnidadeNegocios unidadeNegocios = new UnidadeNegocios();
                UnidadeColecao unidadeColecao = new UnidadeColecao();

                unidadeColecao = unidadeNegocios.ConsultarPorNome(textBoxPesquisa.Text);

                dataGridView.DataSource = null;
                dataGridView.DataSource = unidadeColecao;
                dataGridView.Update();
                dataGridView.Refresh();
            }

            if (labelModuloTitulo.Text == "Cursos")
            {
                CursoNegocios cursoNegocios = new CursoNegocios();
                CursoColecao cursoColecao = new CursoColecao();

                string filtroUnidade = comboBoxFiltroUnidade.Text;
                cursoColecao = cursoNegocios.ConsultarPorNome(textBoxPesquisa.Text, filtroUnidade);

                dataGridView.DataSource = null;
                dataGridView.DataSource = cursoColecao;
                dataGridView.Update();
                dataGridView.Refresh();
            }

            if (labelModuloTitulo.Text == "Professores")
            {
                ProfessorNegocios professorNegocios = new ProfessorNegocios();
                ProfessorColecao professorColecao = new ProfessorColecao();

                if (radioButtonPesquisarPorNome.Checked)
                {
                    professorColecao = professorNegocios.ConsultarPorNome(textBoxPesquisa.Text);
                }
                if (radioButtonPesquisarPorMatricula.Checked)
                {
                    professorColecao = professorNegocios.ConsultarPorMatricula(textBoxPesquisa.Text);
                }

                dataGridView.DataSource = null;
                dataGridView.DataSource = professorColecao;
                dataGridView.Update();
                dataGridView.Refresh();
            }

            if (labelModuloTitulo.Text == "Alunos")
            {
                AlunoNegocios alunoNegocios = new AlunoNegocios();
                AlunoColecao alunoColecao = new AlunoColecao();

                if (radioButtonPesquisarPorNome.Checked)
                {
                    alunoColecao = alunoNegocios.ConsultarPorNome(textBoxPesquisa.Text);
                }
                if (radioButtonPesquisarPorMatricula.Checked)
                {
                    alunoColecao = alunoNegocios.ConsultarPorMatricula(textBoxPesquisa.Text);
                }

                dataGridView.DataSource = null;
                dataGridView.DataSource = alunoColecao;
                dataGridView.Update();
                dataGridView.Refresh();
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            RealizarPesquisa();
        }

        private void textBoxPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                RealizarPesquisa();
            }
        }

        public void buttonSelecionar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum registro selecionado!", "Erro");
                }
            else
            {
                SelecionarEntrada();
            }
        }

        public void SelecionarEntrada()
        {
            if (labelModuloTitulo.Text == "Alunos")
            {
                Aluno alunoSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Aluno);
                labelIDSelecionado.Text = Convert.ToString(alunoSelecao.AlunoID);
                labelCampo1Selecionado.Text = alunoSelecao.AlunoNome;
                this.Close();
            }

            if (labelModuloTitulo.Text == "Cursos")
            {
                Curso cursoSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Curso);
                labelIDSelecionado.Text = Convert.ToString(cursoSelecao.CursoID);
                labelCampo1Selecionado.Text = cursoSelecao.CursoNome;
                labelCampo2Selecionado.Text = Convert.ToString(cursoSelecao.CursoUnidadeNome);
                this.Close();
            }

            if (labelModuloTitulo.Text == "Professores")
            {
                Professor professorSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Professor);

                labelIDSelecionado.Text = Convert.ToString(professorSelecao.ProfessorID);
                labelCampo1Selecionado.Text = professorSelecao.ProfessorNome;
                this.Close();
            }

            if (labelModuloTitulo.Text == "Salas")
            {
                Sala salaSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Sala);

                labelIDSelecionado.Text = Convert.ToString(salaSelecao.SalaID);
                labelCampo1Selecionado.Text = salaSelecao.SalaNome;
                this.Close();
            }
        }

        private void maskedTextBoxPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                RealizarPesquisa();
            }
        }

        private void comboBoxFiltroUnidade_Click(object sender, EventArgs e)
        {
            this.tblUnidadeTableAdapter.Fill(this.dataSetUnidade.tblUnidade);
            comboBoxFiltroUnidade.Text = "";
        }

        private void comboBoxFiltroCurso_Click(object sender, EventArgs e)
        {
            this.tblCursoTableAdapter.Fill(this.dataSetCurso.tblCurso);
            comboBoxFiltroCurso.Text = "";
        }

        private void comboBoxFiltroGrupo_Click(object sender, EventArgs e)
        {
            this.tblGrupoTableAdapter.Fill(this.dataSetGrupo.tblGrupo);
            comboBoxFiltroGrupo.Text = "";
        }

        private void comboBoxFiltroTipo_Click(object sender, EventArgs e)
        {
            this.tblSalaTipoTableAdapter.Fill(this.dataSetSalaTipo.tblSalaTipo);
            comboBoxFiltroTipo.Text = "";
        }

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarEntrada();
        }
    }
}
