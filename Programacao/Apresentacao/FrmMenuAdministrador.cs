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
    public partial class FrmMenuAdministrador : Form
    {
        public FrmMenuAdministrador(string modulo, string grupo)
        {
            InitializeComponent();

            labelModuloTitulo.Text = modulo;

            if (grupo == "ADMINISTRADOR")
            {
                buttonInserir.Visible = true;
                buttonAlterar.Visible = true;
                buttonExcluir.Visible = true;
                buttonConsultar.Visible = true;
            }
            if (grupo == "GERENTE")
            {
                buttonInserir.Visible = true;
                buttonAlterar.Visible = true;
                buttonExcluir.Visible = true;
                buttonConsultar.Visible = true;
            }
            if (grupo == "REGISTRADOR")
            {
                buttonInserir.Visible = true;
                buttonAlterar.Visible = true;
                buttonExcluir.Visible = false;
                buttonConsultar.Visible = true;
            }
            if (grupo == "VISITANTE")
            {
                buttonInserir.Visible = false;
                buttonAlterar.Visible = false;
                buttonExcluir.Visible = false;
                buttonConsultar.Visible = true;
            }
            

            if (labelModuloTitulo.Text == "TCCs")
            {
                labelModuloTitulo.Text = "TCCs";
                labelPesquisaTipo.Text = "Título: ";
                //Pesquisas
                labelPesquisarEscolha.Visible = true;
                labelPesquisarEscolha.Location = new Point(562, 304);
                radioButtonPesquisarPorTitulo.Visible = true;
                radioButtonPesquisarPorTitulo.Checked = true;
                radioButtonPesquisarPorTitulo.Location = new Point(653,302);
                radioButtonPesquisarPorAluno.Visible = true;
                radioButtonPesquisarPorAluno.Checked = false;
                radioButtonPesquisarPorAluno.Location = new Point(723,302);
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
                labelPesquisarEscolha.Location = new Point(562, 304);
                radioButtonPesquisarPorTitulo.Visible = false;
                radioButtonPesquisarPorTitulo.Checked = false;
                radioButtonPesquisarPorTitulo.Location = new Point();
                radioButtonPesquisarPorAluno.Visible = false;
                radioButtonPesquisarPorAluno.Checked = false;
                radioButtonPesquisarPorAluno.Location = new Point();
                radioButtonPesquisarPorNome.Visible = true;
                radioButtonPesquisarPorNome.Checked = true;
                radioButtonPesquisarPorNome.Location = new Point(644,302);
                radioButtonPesquisarPorMatricula.Visible = true;
                radioButtonPesquisarPorMatricula.Checked = false;
                radioButtonPesquisarPorMatricula.Location = new Point(705,302);
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
                labelPesquisarEscolha.Location = new Point(562,304);
                radioButtonPesquisarPorTitulo.Visible = false;
                radioButtonPesquisarPorTitulo.Checked = false;
                radioButtonPesquisarPorTitulo.Location = new Point();
                radioButtonPesquisarPorAluno.Visible = false;
                radioButtonPesquisarPorAluno.Checked = false;
                radioButtonPesquisarPorAluno.Location = new Point();
                radioButtonPesquisarPorNome.Visible = true;
                radioButtonPesquisarPorNome.Checked = true;
                radioButtonPesquisarPorNome.Location = new Point(644, 302);
                radioButtonPesquisarPorMatricula.Visible = true;
                radioButtonPesquisarPorMatricula.Checked = false;
                radioButtonPesquisarPorMatricula.Location = new Point(705, 302);
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
                radioButtonPesquisarPorNome.Location = new Point(642,302);
                radioButtonPesquisarPorMatricula.Visible = false;
                radioButtonPesquisarPorMatricula.Checked = false;
                radioButtonPesquisarPorMatricula.Location = new Point();
                radioButtonPesquisarPorDescricao.Visible = true;
                radioButtonPesquisarPorDescricao.Checked = false;
                radioButtonPesquisarPorDescricao.Location = new Point(701, 302);
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
                radioButtonPesquisarPorNome.Location = new Point(642, 302);
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
                radioButtonPesquisarPorLogin.Location = new Point(701, 302);
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

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (labelModuloTitulo.Text == "Alunos"){
                FrmMenuAcaoAluno frmMenuAcaoAluno = new FrmMenuAcaoAluno(null, "Inserir Aluno");
                DialogResult dialogResult = frmMenuAcaoAluno.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    RealizarPesquisa();
                }
            }
            if (labelModuloTitulo.Text == "TCCs")
            {
                FrmMenuAcaoTCC frmMenuAcaoTCC = new FrmMenuAcaoTCC(null, "Inserir TCC");
                DialogResult dialogResult = frmMenuAcaoTCC.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    RealizarPesquisa();
                }
            }
            if (labelModuloTitulo.Text == "Professores")
            {
                FrmMenuAcaoProfessor frmMenuAcaoProfessor = new FrmMenuAcaoProfessor(null, "Inserir Professor");
                DialogResult dialogResult = frmMenuAcaoProfessor.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    RealizarPesquisa();
                }
            }
            if (labelModuloTitulo.Text == "Cursos")
            {
                FrmMenuAcaoCurso frmMenuAcaoCurso = new FrmMenuAcaoCurso(null, "Inserir Curso");
                DialogResult dialogResult = frmMenuAcaoCurso.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    RealizarPesquisa();
                }
            }
            if (labelModuloTitulo.Text == "Unidades")
            {
                FrmMenuAcaoUnidade frmMenuAcaoUnidade = new FrmMenuAcaoUnidade(null, "Inserir Unidade");
                DialogResult dialogResult = frmMenuAcaoUnidade.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    RealizarPesquisa();
                }
            }
            if (labelModuloTitulo.Text == "Salas")
            {
                FrmMenuAcaoSala frmMenuAcaoSala = new FrmMenuAcaoSala(null, "Inserir Sala");
                DialogResult dialogResult = frmMenuAcaoSala.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    RealizarPesquisa();
                }
            }
            if (labelModuloTitulo.Text == "Usuários")
            {
                FrmMenuAcaoUsuario frmMenuAcaoUsuario = new FrmMenuAcaoUsuario(null, "Inserir Usuario");
                DialogResult dialogResult = frmMenuAcaoUsuario.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    RealizarPesquisa();
                }
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado!", "Erro");
                return;
            }

            if (labelModuloTitulo.Text == "Alunos")
            {
                Aluno alunoSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Aluno);

                FrmMenuAcaoAluno frmMenuAcaoAluno = new FrmMenuAcaoAluno(alunoSelecao, "Alterar Aluno");
                DialogResult dialogResult = frmMenuAcaoAluno.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    RealizarPesquisa();
                }
            }

            if (labelModuloTitulo.Text == "TCCs")
            {
                TCC tccSelecao = (dataGridView.SelectedRows[0].DataBoundItem as TCC);

                FrmMenuAcaoTCC frmMenuAcaoTCC = new FrmMenuAcaoTCC(tccSelecao, "Alterar TCC");
                DialogResult dialogResult = frmMenuAcaoTCC.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    RealizarPesquisa();
                }
            }
            if (labelModuloTitulo.Text == "Professores")
            {
                Professor professorSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Professor);

                FrmMenuAcaoProfessor frmMenuAlterarProfessor = new FrmMenuAcaoProfessor(professorSelecao, "Alterar Professor");
                DialogResult dialogResult = frmMenuAlterarProfessor.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    RealizarPesquisa();
                }
            }
            if (labelModuloTitulo.Text == "Cursos")
            {
                Curso cursoSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Curso);

                FrmMenuAcaoCurso frmMenuAcaoCurso = new FrmMenuAcaoCurso(cursoSelecao, "Alterar Curso");
                DialogResult dialogResult = frmMenuAcaoCurso.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    RealizarPesquisa();
                }
            }
            if (labelModuloTitulo.Text == "Unidades")
            {
                Unidade unidadeSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Unidade);

                FrmMenuAcaoUnidade frmMenuAcaoUnidade = new FrmMenuAcaoUnidade(unidadeSelecao, "Alterar Unidade");
                DialogResult dialogResult = frmMenuAcaoUnidade.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    RealizarPesquisa();
                }
            }
            if (labelModuloTitulo.Text == "Salas")
            {
                Sala salaSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Sala);

                FrmMenuAcaoSala frmMenuAcaoSala = new FrmMenuAcaoSala(salaSelecao, "Alterar Sala");
                DialogResult dialogResult = frmMenuAcaoSala.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    RealizarPesquisa();
                }
            }
            if (labelModuloTitulo.Text == "Usuários")
            {
                Usuario usuarioSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Usuario);

                FrmMenuAcaoUsuario frmMenuAcaoUsuario = new FrmMenuAcaoUsuario(usuarioSelecao, "Alterar Usuario");
                DialogResult dialogResult = frmMenuAcaoUsuario.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    RealizarPesquisa();
                }
            }
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

            if (labelModuloTitulo.Text == "TCCs")
            {
                TCC tccSelecao = (dataGridView.SelectedRows[0].DataBoundItem as TCC);
                FrmMenuAcaoTCC frmMenuAcaoTCC = new FrmMenuAcaoTCC(tccSelecao, "Consultar TCC");
                frmMenuAcaoTCC.ShowDialog();
            }

            if (labelModuloTitulo.Text == "Salas")
            {
                Sala salaSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Sala);
                FrmMenuAcaoSala frmMenuAcaoSala = new FrmMenuAcaoSala(salaSelecao, "Consultar Sala");
                frmMenuAcaoSala.ShowDialog();
            }

            if (labelModuloTitulo.Text == "Usuários")
            {
                Usuario usuarioSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Usuario);
                FrmMenuAcaoUsuario frmMenuAcaoUsuario = new FrmMenuAcaoUsuario(usuarioSelecao, "Consultar Usuario");
                frmMenuAcaoUsuario.ShowDialog();
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
                dataGridView.Columns["UnidadeID"].HeaderText = "ID";
                dataGridView.Columns["UnidadeID"].Width = 40;
                dataGridView.Columns["UnidadeNome"].HeaderText = "Unidade";
                dataGridView.Columns["UnidadeNome"].MinimumWidth = 250;
                dataGridView.Columns["UnidadeCidade"].HeaderText = "Cidade";
                dataGridView.Columns["UnidadeCidade"].MinimumWidth = 220;
                dataGridView.Columns["UnidadeEstado"].HeaderText = "Estado";
                dataGridView.Columns["UnidadeEstado"].Width = 50;
                dataGridView.Columns["UnidadePais"].HeaderText = "País";
                dataGridView.Columns["UnidadePais"].MinimumWidth = 157;
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
                dataGridView.Columns["CursoID"].HeaderText = "ID";
                dataGridView.Columns["CursoID"].Width = 40;
                dataGridView.Columns["CursoNome"].HeaderText = "Curso";
                dataGridView.Columns["CursoNome"].MinimumWidth = 420;
                dataGridView.Columns["CursoUnidadeNome"].HeaderText = "Unidade";
                dataGridView.Columns["CursoUnidadeNome"].MinimumWidth= 256;
                dataGridView.Columns["CursoUnidadeID"].Visible = false;
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
                dataGridView.Columns["ProfessorID"].HeaderText = "ID";
                dataGridView.Columns["ProfessorID"].Width = 40;
                dataGridView.Columns["ProfessorNome"].HeaderText = "Nome do Professor";
                dataGridView.Columns["ProfessorNome"].MinimumWidth = 300;
                dataGridView.Columns["ProfessorMatricula"].HeaderText = "Matrícula";
                dataGridView.Columns["ProfessorMatricula"].MinimumWidth = 100;
                dataGridView.Columns["ProfessorTelefone"].HeaderText = "Telefone";
                dataGridView.Columns["ProfessorTelefone"].MinimumWidth = 100;
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
                dataGridView.Columns["AlunoID"].HeaderText = "ID";
                dataGridView.Columns["AlunoID"].Width = 40;
                dataGridView.Columns["AlunoNome"].HeaderText = "Nome do Aluno";
                dataGridView.Columns["AlunoNome"].MinimumWidth = 220;
                dataGridView.Columns["AlunoMatricula"].HeaderText = "Matrícula";
                dataGridView.Columns["AlunoMatricula"].MinimumWidth = 100;
                dataGridView.Columns["AlunoTelefone"].HeaderText = "Telefone";
                dataGridView.Columns["AlunoTelefone"].MinimumWidth = 100;
                dataGridView.Columns["AlunoCursoNome"].HeaderText = "Curso";
                dataGridView.Columns["AlunoCursoNome"].MinimumWidth = 200;
                dataGridView.Columns["AlunoUnidadeNome"].HeaderText = "Unidade";
                dataGridView.Columns["AlunoUnidadeNome"].MinimumWidth = 200;
                dataGridView.Columns["AlunoCursoID"].Visible = false;
                dataGridView.Update();
                dataGridView.Refresh();
            }

            if (labelModuloTitulo.Text == "TCCs")
            {
                TCCNegocios tccNegocios = new TCCNegocios();
                TCCColecao tccColecao = new TCCColecao();

                if (radioButtonPesquisarPorTitulo.Checked)
                {
                    tccColecao = tccNegocios.ConsultarPorTitulo(textBoxPesquisa.Text);
                }
                if (radioButtonPesquisarPorAluno.Checked)
                {
                    tccColecao = tccNegocios.ConsultarPorAluno(textBoxPesquisa.Text);
                }

                dataGridView.DataSource = null;
                dataGridView.DataSource = tccColecao;
                dataGridView.Columns["TCCID"].HeaderText = "ID";
                dataGridView.Columns["TCCID"].Width = 40;
                dataGridView.Columns["TCCTitulo"].HeaderText = "Titulo do Trabalho";
                dataGridView.Columns["TCCTitulo"].MinimumWidth = 500;
                dataGridView.Columns["TCCAlunoNome"].HeaderText = "Aluno Responsável";
                dataGridView.Columns["TCCAlunoNome"].MinimumWidth = 200;
                dataGridView.Columns["TCCOrientadorNome"].HeaderText = "Professor Orientador";
                dataGridView.Columns["TCCOrientadorNome"].MinimumWidth = 200;
                dataGridView.Columns["TCCGrandeArea"].HeaderText = "Grande Área";
                dataGridView.Columns["TCCGrandeArea"].MinimumWidth = 150;
                dataGridView.Columns["TCCArea"].HeaderText = "Área";
                dataGridView.Columns["TCCArea"].MinimumWidth = 200;
                dataGridView.Columns["TCCSubarea"].HeaderText = "Subarea";
                dataGridView.Columns["TCCSubarea"].MinimumWidth = 150;
                dataGridView.Columns["TCCEspecialidade"].HeaderText = "Especialidade";
                dataGridView.Columns["TCCEspecialidade"].MinimumWidth = 200;
                dataGridView.Columns["TCCData"].HeaderText = "Data";
                dataGridView.Columns["TCCData"].MinimumWidth = 80;
                dataGridView.Columns["TCCSalaNome"].HeaderText = "Local";
                dataGridView.Columns["TCCSalaNome"].MinimumWidth = 60;
                dataGridView.Columns["TCCUnidade"].HeaderText = "Unidade";
                dataGridView.Columns["TCCUnidade"].MinimumWidth = 200;

                dataGridView.Columns["TCCAlunoID"].Visible = false;
                dataGridView.Columns["TCCOrientadorID"].Visible = false;
                dataGridView.Columns["TCCResumo"].Visible = false;
                dataGridView.Columns["TCCPaginas"].Visible = false;
                dataGridView.Columns["TCCSalaID"].Visible = false;
                dataGridView.Update();
                dataGridView.Refresh();
            }

            if (labelModuloTitulo.Text == "Salas")
            {
                SalaNegocios salaNegocios = new SalaNegocios();
                SalaColecao salaColecao = new SalaColecao();

                string filtroUnidade = comboBoxFiltroUnidade.Text;

                if (radioButtonPesquisarPorNome.Checked)
                {
                    salaColecao = salaNegocios.ConsultarPorNome(textBoxPesquisa.Text, filtroUnidade);
                }
                if (radioButtonPesquisarPorDescricao.Checked)
                {
                    salaColecao = salaNegocios.ConsultarPorDescricao(textBoxPesquisa.Text, filtroUnidade);
                }

                dataGridView.DataSource = null;
                dataGridView.DataSource = salaColecao;
                dataGridView.Columns["SalaID"].HeaderText = "ID";
                dataGridView.Columns["SalaID"].Width = 40;
                dataGridView.Columns["SalaNome"].HeaderText = "Sala";
                dataGridView.Columns["SalaNome"].Width = 50;
                dataGridView.Columns["SalaDescricao"].HeaderText = "Descrição";
                dataGridView.Columns["SalaDescricao"].MinimumWidth = 280;
                dataGridView.Columns["SalaSalaTipoNome"].HeaderText = "Tipo";
                dataGridView.Columns["SalaSalaTipoNome"].MinimumWidth = 100;
                dataGridView.Columns["SalaUnidadeNome"].HeaderText = "Unidade";
                dataGridView.Columns["SalaUnidadeNome"].MinimumWidth = 247;
                dataGridView.Columns["SalaSalaTipoID"].Visible = false;
                dataGridView.Columns["SalaUnidadeID"].Visible = false;
                dataGridView.Update();
                dataGridView.Refresh();
            }

            if (labelModuloTitulo.Text == "Usuários")
            {
                UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
                UsuarioColecao usuarioColecao = new UsuarioColecao();

                if (radioButtonPesquisarPorNome.Checked)
                {
                    usuarioColecao = usuarioNegocios.ConsultarPorNome(textBoxPesquisa.Text);
                }
                if (radioButtonPesquisarPorLogin.Checked)
                {
                    usuarioColecao = usuarioNegocios.ConsultarPorLogin(textBoxPesquisa.Text);
                }

                dataGridView.DataSource = null;
                dataGridView.DataSource = usuarioColecao;
                dataGridView.Columns["UsuarioID"].HeaderText = "ID";
                dataGridView.Columns["UsuarioID"].Width = 40;
                dataGridView.Columns["UsuarioLogin"].HeaderText = "Login";
                dataGridView.Columns["UsuarioLogin"].Width = 150;
                dataGridView.Columns["UsuarioNome"].HeaderText = "Nome do Usuário";
                dataGridView.Columns["UsuarioNome"].MinimumWidth = 150;
                dataGridView.Columns["UsuarioMatricula"].HeaderText = "Matrícula";
                dataGridView.Columns["UsuarioMatricula"].MinimumWidth = 100;
                dataGridView.Columns["UsuarioGrupoNome"].HeaderText = "Grupo";
                dataGridView.Columns["UsuarioGrupoNome"].MinimumWidth = 120;
                dataGridView.Columns["UsuarioSituacao"].HeaderText = "Situação";
                dataGridView.Columns["UsuarioSituacao"].MinimumWidth = 40;
                dataGridView.Columns["UsuarioSenha"].Visible = false;
                dataGridView.Columns["UsuarioGrupoID"].Visible = false;
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

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado!", "Erro");
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esse registro do sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            if (labelModuloTitulo.Text == "Professores")
            {
                Professor professorSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Professor);
                ProfessorNegocios professorNegocios = new ProfessorNegocios();
                
                int verificacao = professorNegocios.VerificarUso(professorSelecao.ProfessorID);

                if (verificacao != 0)
                {
                    MessageBox.Show("Impossível excluir o professor selecionado.\nJá existe cadastro deste professor como\norientador de TCC ou participante de uma Banca.", "Operação não permitida");
                }
                else
                {
                    string retorno = professorNegocios.Excluir(professorSelecao);

                    try
                    {
                        int ProfessorID = Convert.ToInt32(retorno);

                        MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RealizarPesquisa();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (labelModuloTitulo.Text == "Unidades") 
            {
                Unidade unidadeSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Unidade);
                UnidadeNegocios unidadeNegocios = new UnidadeNegocios();

                int verificacao = unidadeNegocios.VerificarUso(unidadeSelecao.UnidadeID);

                if (verificacao != 0)
                {
                    MessageBox.Show("Impossível excluir a unidade selecionada.\nExiste cadastro de curso(s) ou sala(s) vinculados a esta unidade.", "Operação não permitida");
                }
                else
                {
                    string retorno = unidadeNegocios.Excluir(unidadeSelecao);

                    try
                    {
                        int UnidadeID = Convert.ToInt32(retorno);

                        MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RealizarPesquisa();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (labelModuloTitulo.Text == "Cursos")
            {
                Curso cursoSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Curso);
                CursoNegocios cursoNegocios = new CursoNegocios();

                int verificacao = cursoNegocios.VerificarUso(cursoSelecao.CursoID);

                if (verificacao != 0)
                {
                    MessageBox.Show("Impossível excluir o curso selecionado.\nJá existe cadastro de aluno(s) vinculados a este curso.", "Operação não permitida");
                }
                else
                {
                    string retorno = cursoNegocios.Excluir(cursoSelecao);

                    try
                    {
                        int cursoID = Convert.ToInt32(retorno);

                        MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RealizarPesquisa();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (labelModuloTitulo.Text == "Alunos")
            {
                Aluno alunoSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Aluno);
                AlunoNegocios alunoNegocios = new AlunoNegocios();

                int verificacao = alunoNegocios.VerificarUso(alunoSelecao.AlunoID);

                if (verificacao != 0)
                {
                    MessageBox.Show("Impossível excluir o aluno selecionado.\nJá existe cadastro de TCC(s) vinculados a este aluno.", "Operação não permitida");
                }
                else
                {
                    string retorno = alunoNegocios.Excluir(alunoSelecao);

                    try
                    {
                        int alunoID = Convert.ToInt32(retorno);

                        MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RealizarPesquisa();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (labelModuloTitulo.Text == "Salas")
            {
                Sala salaSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Sala);
                SalaNegocios salaNegocios = new SalaNegocios();
                
                int verificacao = salaNegocios.VerificarUso(salaSelecao.SalaID);

                if (verificacao != 0)
                {
                    MessageBox.Show("Impossível excluir a sala selecionada.\nJá existe cadastro de TCC(s) vinculados a esta sala.", "Operação não permitida");
                }
                else
                {
                    string retorno = salaNegocios.Excluir(salaSelecao);
                    try
                    {
                        int salaID = Convert.ToInt32(retorno);

                        MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RealizarPesquisa();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (labelModuloTitulo.Text == "TCCs")
            {
                TCC tccSelecao = (dataGridView.SelectedRows[0].DataBoundItem as TCC);
                TCCNegocios tccNegocios = new TCCNegocios();
                string retorno = tccNegocios.Excluir(tccSelecao);

                try
                {
                    int tccID = Convert.ToInt32(retorno);

                    MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RealizarPesquisa();
                }
                catch
                {
                    MessageBox.Show("Não foi possível excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (labelModuloTitulo.Text == "Usuários")
            {
                Usuario usuarioSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Usuario);
                UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
                string retorno = usuarioNegocios.Excluir(usuarioSelecao);

                try
                {
                    int usuarioID = Convert.ToInt32(retorno);

                    MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RealizarPesquisa();
                }
                catch
                {
                    MessageBox.Show("Não foi possível excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void maskedTextBoxPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                RealizarPesquisa();
            }
        }

        private void FrmMenuAdministrador_Load(object sender, EventArgs e)
        {
            Unidade unidade = new Unidade();
            Curso curso = new Curso();
            Sala sala = new Sala();
            Usuario usuario = new Usuario();

            dateTimePickerFiltroData.Value = DateTime.Now.Date;
            unidade.UnidadeNome = "";
            curso.CursoNome = "";
            sala.SalaSalaTipoNome = "";
            usuario.UsuarioGrupoNome = "";

            this.tblUnidadeTableAdapter.Fill(this.dataSetUnidade.tblUnidade);
            if (unidade.UnidadeNome == "")
            {
                comboBoxFiltroUnidade.SelectedValue = "";
            }
            else
            {
                comboBoxFiltroUnidade.Text = unidade.UnidadeNome;
            }

            this.tblCursoTableAdapter.Fill(this.dataSetCurso.tblCurso);
            if (curso.CursoNome == "")
            {
                comboBoxFiltroCurso.SelectedValue = "";
            }
            else
            {
                comboBoxFiltroCurso.Text = curso.CursoNome;
            }

            this.tblGrupoTableAdapter.Fill(this.dataSetGrupo.tblGrupo);
            if (usuario.UsuarioGrupoNome == "")
            {
                comboBoxFiltroGrupo.SelectedValue = "";
            }
            else
            {
                comboBoxFiltroGrupo.Text = usuario.UsuarioGrupoNome;
            }

            this.tblSalaTipoTableAdapter.Fill(this.dataSetSalaTipo.tblSalaTipo);
            if (sala.SalaSalaTipoNome == "")
            {
                comboBoxFiltroTipo.SelectedValue = "";
            }
            else
            {
                comboBoxFiltroTipo.Text = sala.SalaSalaTipoNome;
            }
        }

        private void comboBoxFiltroUnidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                comboBoxFiltroUnidade.SelectedValue = "";
            }
        }

        private void comboBoxFiltroCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                comboBoxFiltroCurso.SelectedValue = "";
            }
        }

        private void comboBoxFiltroTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                comboBoxFiltroTipo.SelectedValue = "";
            }
        }

        private void comboBoxFiltroGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 127)
            {
                comboBoxFiltroGrupo.SelectedValue = "";
            }
        }
    }
}
