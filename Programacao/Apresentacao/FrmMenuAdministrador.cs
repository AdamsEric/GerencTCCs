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
        public FrmMenuAdministrador()
        {
            InitializeComponent();
        }

        private void buttonAlunoMenu_Click(object sender, EventArgs e)
        {
            labelModuloTitulo.Text = "Alunos";
            labelPesquisaTipo.Text = "Nome: ";
            textBoxPesquisa.Location = new Point(283, 82);
            textBoxPesquisa.Size = new Size(587, 20);
            //Pesquisas
            labelPesquisarEscolha.Visible = true;
            labelPesquisarEscolha.Location = new Point(681, 315);
            radioButtonPesquisarPorNome.Visible = true;
            radioButtonPesquisarPorNome.Checked = true;
            radioButtonPesquisarPorNome.Location = new Point(764, 313);
            radioButtonPesquisarPorCPF.Visible = true;
            radioButtonPesquisarPorCPF.Location = new Point(826, 313);
            radioButtonPesquisarPorMatricula.Visible = true;
            radioButtonPesquisarPorMatricula.Location = new Point(880, 313);
            radioButtonPesquisarPorDescricao.Visible = false;
            radioButtonPesquisarPorDescricao.Checked = false;
            radioButtonPesquisarPorTema.Visible = false;
            radioButtonPesquisarPorTema.Checked = false;
            radioButtonPesquisarPorCodigo.Visible = false;
            radioButtonPesquisarPorCodigo.Checked = false;
            radioButtonPesquisarPorLogin.Visible = false;
            radioButtonPesquisarPorLogin.Checked = false;
            //Filtros
            labelFiltrar.Visible = true;
            labelFiltrarPorUnidade.Visible = true;
            comboBoxFiltroUnidade.Visible = true;
            labelFiltrarPorCurso.Visible = true;
            comboBoxFiltroCurso.Visible = true;
            labelFiltrarPorProfessor.Visible = false;
            comboBoxFiltroProfessor.Visible = false;
            labelFiltrarPorTipo.Visible = false;
            comboBoxFiltroTipo.Visible = false;
            labelFiltrarPorData.Visible = false;
            dateTimePickerFiltroData.Visible = false;
            labelFiltrarPorGrupo.Visible = false;
            comboBoxFiltroGrupo.Visible = false;
            //DataGrid
            dataGridView.DataSource = null;
        }

        private void buttonTCCMenu_Click(object sender, EventArgs e)
        {
            labelModuloTitulo.Text = "TCCs";
            labelPesquisaTipo.Text = "Descrição: ";
            textBoxPesquisa.Location = new Point(303, 82);
            textBoxPesquisa.Size = new Size(567, 20);
            //Pesquisas
            labelPesquisarEscolha.Visible = true;
            labelPesquisarEscolha.Location = new Point(740, 315);
            radioButtonPesquisarPorNome.Visible = false;
            radioButtonPesquisarPorCPF.Visible = false;
            radioButtonPesquisarPorCPF.Checked = false;
            radioButtonPesquisarPorMatricula.Visible = false;
            radioButtonPesquisarPorMatricula.Checked = false;
            radioButtonPesquisarPorDescricao.Visible = true;
            radioButtonPesquisarPorDescricao.Location = new Point(820, 313);
            radioButtonPesquisarPorDescricao.Checked = true;
            radioButtonPesquisarPorTema.Location = new Point(899,313);
            radioButtonPesquisarPorTema.Visible = true;
            radioButtonPesquisarPorTema.Checked = false;
            radioButtonPesquisarPorCodigo.Visible = false;
            radioButtonPesquisarPorCodigo.Checked = false;
            radioButtonPesquisarPorLogin.Visible = false;
            radioButtonPesquisarPorLogin.Checked = false;
            //Filtros
            labelFiltrar.Visible = true;
            labelFiltrarPorUnidade.Visible = true;
            comboBoxFiltroUnidade.Visible = true;
            labelFiltrarPorCurso.Visible = true;
            comboBoxFiltroCurso.Visible = true;
            labelFiltrarPorProfessor.Visible = true;
            comboBoxFiltroProfessor.Visible = true;
            labelFiltrarPorTipo.Visible = false;
            comboBoxFiltroTipo.Visible = false;
            labelFiltrarPorData.Visible = true;
            labelFiltrarPorData.Location = new Point(498, 318);
            dateTimePickerFiltroData.Visible = true;
            dateTimePickerFiltroData.Location = new Point(531, 314);
            labelFiltrarPorGrupo.Visible = false;
            comboBoxFiltroGrupo.Visible = false;
            //DataGrid
            dataGridView.DataSource = null;
        }

        private void buttonProfessorMenu_Click(object sender, EventArgs e)
        {
            labelModuloTitulo.Text = "Professores";
            labelPesquisaTipo.Text = "Nome: ";
            textBoxPesquisa.Location = new Point(283, 82);
            textBoxPesquisa.Size = new Size(587, 20);
            //Pesquisas
            labelPesquisarEscolha.Visible = true;
            labelPesquisarEscolha.Location = new Point(681, 315);
            radioButtonPesquisarPorNome.Visible = true;
            radioButtonPesquisarPorNome.Checked = true;
            radioButtonPesquisarPorNome.Location = new Point(764, 313);
            radioButtonPesquisarPorCPF.Visible = true;
            radioButtonPesquisarPorCPF.Location = new Point(826, 313);
            radioButtonPesquisarPorMatricula.Visible = true;
            radioButtonPesquisarPorMatricula.Location = new Point(880, 313);
            radioButtonPesquisarPorDescricao.Visible = false;
            radioButtonPesquisarPorDescricao.Checked = false;
            radioButtonPesquisarPorTema.Visible = false;
            radioButtonPesquisarPorTema.Checked = false;
            radioButtonPesquisarPorCodigo.Visible = false;
            radioButtonPesquisarPorCodigo.Checked = false;
            radioButtonPesquisarPorLogin.Visible = false;
            radioButtonPesquisarPorLogin.Checked = false;
            //Filtros
            labelFiltrar.Visible = true;
            labelFiltrarPorUnidade.Visible = true;
            comboBoxFiltroUnidade.Visible = true;
            labelFiltrarPorCurso.Visible = false;
            comboBoxFiltroCurso.Visible = false;
            labelFiltrarPorProfessor.Visible = false;
            comboBoxFiltroProfessor.Visible = false;
            labelFiltrarPorTipo.Visible = false;
            comboBoxFiltroTipo.Visible = false;
            labelFiltrarPorData.Visible = false;
            dateTimePickerFiltroData.Visible = false;
            labelFiltrarPorGrupo.Visible = false;
            comboBoxFiltroGrupo.Visible = false;
            //DataGrid
            dataGridView.DataSource = null;
        }

        private void buttonCursoMenu_Click(object sender, EventArgs e)
        {
            labelModuloTitulo.Text = "Cursos";
            labelPesquisaTipo.Text = "Nome: ";
            textBoxPesquisa.Location = new Point(283, 82);
            textBoxPesquisa.Size = new Size(587, 20);
            //Pesquisas
            labelPesquisarEscolha.Visible = false;
            labelPesquisarEscolha.Location = new Point(681, 315);
            radioButtonPesquisarPorNome.Visible = false;
            radioButtonPesquisarPorNome.Checked = true;
            radioButtonPesquisarPorCPF.Visible = false;
            radioButtonPesquisarPorCPF.Checked = false;
            radioButtonPesquisarPorMatricula.Visible = false;
            radioButtonPesquisarPorDescricao.Visible = false;
            radioButtonPesquisarPorDescricao.Checked = false;
            radioButtonPesquisarPorTema.Visible = false;
            radioButtonPesquisarPorTema.Checked = false;
            radioButtonPesquisarPorCodigo.Visible = false;
            radioButtonPesquisarPorCodigo.Checked = false;
            radioButtonPesquisarPorLogin.Visible = false;
            radioButtonPesquisarPorLogin.Checked = false;
            //Filtros
            labelFiltrar.Visible = true;
            labelFiltrarPorUnidade.Visible = true;
            comboBoxFiltroUnidade.Visible = true;
            labelFiltrarPorCurso.Visible = false;
            comboBoxFiltroCurso.Visible = false;
            labelFiltrarPorProfessor.Visible = false;
            comboBoxFiltroProfessor.Visible = false;
            labelFiltrarPorTipo.Visible = false;
            comboBoxFiltroTipo.Visible = false;
            labelFiltrarPorData.Visible = false;
            dateTimePickerFiltroData.Visible = false;
            labelFiltrarPorGrupo.Visible = false;
            comboBoxFiltroGrupo.Visible = false;
            //DataGrid
            dataGridView.DataSource = null;
        }

        private void buttonUnidadeMenu_Click(object sender, EventArgs e)
        {
            labelModuloTitulo.Text = "Unidades";
            labelPesquisaTipo.Text = "Nome: ";
            textBoxPesquisa.Location = new Point(283, 82);
            textBoxPesquisa.Size = new Size(587, 20);
            //Pesquisas
            labelPesquisarEscolha.Visible = false;
            labelPesquisarEscolha.Location = new Point(681, 315);
            radioButtonPesquisarPorNome.Visible = false;
            radioButtonPesquisarPorNome.Checked = true;
            radioButtonPesquisarPorCPF.Visible = false;
            radioButtonPesquisarPorCPF.Checked = false;
            radioButtonPesquisarPorMatricula.Visible = false;
            radioButtonPesquisarPorDescricao.Visible = false;
            radioButtonPesquisarPorDescricao.Checked = false;
            radioButtonPesquisarPorTema.Visible = false;
            radioButtonPesquisarPorTema.Checked = false;
            radioButtonPesquisarPorCodigo.Visible = false;
            radioButtonPesquisarPorCodigo.Checked = false;
            radioButtonPesquisarPorLogin.Visible = false;
            radioButtonPesquisarPorLogin.Checked = false;
            //Filtros
            labelFiltrar.Visible = false;
            labelFiltrarPorUnidade.Visible = false;
            comboBoxFiltroUnidade.Visible = false;
            labelFiltrarPorCurso.Visible = false;
            comboBoxFiltroCurso.Visible = false;
            labelFiltrarPorProfessor.Visible = false;
            comboBoxFiltroProfessor.Visible = false;
            labelFiltrarPorTipo.Visible = false;
            comboBoxFiltroTipo.Visible = false;
            labelFiltrarPorData.Visible = false;
            dateTimePickerFiltroData.Visible = false;
            labelFiltrarPorGrupo.Visible = false;
            comboBoxFiltroGrupo.Visible = false;
            //DataGrid
            dataGridView.DataSource = null;
        }

        private void buttonSalaMenu_Click(object sender, EventArgs e)
        {
            labelModuloTitulo.Text = "Salas";
            labelPesquisaTipo.Text = "Código: ";
            textBoxPesquisa.Location = new Point(283, 82);
            textBoxPesquisa.Size = new Size(587, 20);
            //Pesquisas
            labelPesquisarEscolha.Visible = true;
            labelPesquisarEscolha.Location = new Point(736, 315);
            radioButtonPesquisarPorNome.Visible = false;
            radioButtonPesquisarPorNome.Checked = false;
            radioButtonPesquisarPorCPF.Visible = false;
            radioButtonPesquisarPorCPF.Checked = false;
            radioButtonPesquisarPorMatricula.Visible = false;
            radioButtonPesquisarPorDescricao.Visible = true;
            radioButtonPesquisarPorDescricao.Checked = false;
            radioButtonPesquisarPorDescricao.Location = new Point(878, 313);
            radioButtonPesquisarPorTema.Visible = false;
            radioButtonPesquisarPorTema.Checked = false;
            radioButtonPesquisarPorCodigo.Visible = true;
            radioButtonPesquisarPorCodigo.Checked = true;
            radioButtonPesquisarPorCodigo.Location = new Point(816, 313);
            radioButtonPesquisarPorLogin.Visible = false;
            radioButtonPesquisarPorLogin.Checked = false;

            //Filtros
            labelFiltrar.Visible = true;
            labelFiltrarPorUnidade.Visible = true;
            comboBoxFiltroUnidade.Visible = true;
            labelFiltrarPorCurso.Visible = false;
            comboBoxFiltroCurso.Visible = false;
            labelFiltrarPorProfessor.Visible = false;
            comboBoxFiltroProfessor.Visible = false;
            labelFiltrarPorTipo.Visible = true;
            comboBoxFiltroTipo.Visible = true;
            labelFiltrarPorData.Visible = false;
            dateTimePickerFiltroData.Visible = false;
            labelFiltrarPorGrupo.Visible = false;
            comboBoxFiltroGrupo.Visible = false;
            //DataGrid
            dataGridView.DataSource = null;
        }

        private void buttonUsuarioMenu_Click(object sender, EventArgs e)
        {
            labelModuloTitulo.Text = "Usuários";
            labelPesquisaTipo.Text = "Nome: ";
            textBoxPesquisa.Location = new Point(283, 82);
            textBoxPesquisa.Size = new Size(587, 20);
            //Pesquisas
            labelPesquisarEscolha.Visible = true;
            labelPesquisarEscolha.Location = new Point(760, 315);
            radioButtonPesquisarPorNome.Visible = true;
            radioButtonPesquisarPorNome.Checked = true;
            radioButtonPesquisarPorNome.Location = new Point(840, 313);
            radioButtonPesquisarPorCPF.Visible = false;
            radioButtonPesquisarPorCPF.Checked = false;
            radioButtonPesquisarPorMatricula.Visible = false;
            radioButtonPesquisarPorDescricao.Visible = false;
            radioButtonPesquisarPorDescricao.Checked = false;
            radioButtonPesquisarPorTema.Visible = false;
            radioButtonPesquisarPorTema.Checked = false;
            radioButtonPesquisarPorCodigo.Visible = false;
            radioButtonPesquisarPorCodigo.Checked = false;
            radioButtonPesquisarPorLogin.Visible = true;
            radioButtonPesquisarPorLogin.Checked = false;
            radioButtonPesquisarPorLogin.Location = new Point(899, 313);
            //Filtros
            labelFiltrar.Visible = true;
            labelFiltrarPorUnidade.Visible = false;
            comboBoxFiltroUnidade.Visible = false;
            labelFiltrarPorCurso.Visible = false;
            comboBoxFiltroCurso.Visible = false;
            labelFiltrarPorProfessor.Visible = false;
            comboBoxFiltroProfessor.Visible = false;
            labelFiltrarPorTipo.Visible = false;
            comboBoxFiltroTipo.Visible = false;
            labelFiltrarPorData.Visible = false;
            dateTimePickerFiltroData.Visible = false;
            labelFiltrarPorGrupo.Visible = true;
            labelFiltrarPorGrupo.Location = new Point(309,318);
            comboBoxFiltroGrupo.Visible = true;
            comboBoxFiltroGrupo.Location = new Point(351, 314);
            //DataGrid
            dataGridView.DataSource = null;
        }

        private void radioButtonPesquisarPorNome_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisaTipo.Text = "Nome: ";
            textBoxPesquisa.Location = new Point(283, 82);
            textBoxPesquisa.Size = new Size(587, 20);
        }

        private void radioButtonPesquisarPorCPF_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisaTipo.Text = "CPF: ";
            textBoxPesquisa.Location = new Point(275, 82);
            textBoxPesquisa.Size = new Size(595, 20);
        }

        private void radioButtonPesquisarPorMatricula_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisaTipo.Text = "Matricula: ";
            textBoxPesquisa.Location = new Point(299, 82);
            textBoxPesquisa.Size = new Size(571, 20);
        }

        private void radioButtonPesquisarPorDescricao_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisaTipo.Text = "Descrição: ";
            textBoxPesquisa.Location = new Point(303, 82);
            textBoxPesquisa.Size = new Size(567, 20);
        }

        private void radioButtonPesquisarPorTema_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisaTipo.Text = "Tema: ";
            textBoxPesquisa.Location = new Point(283, 82);
            textBoxPesquisa.Size = new Size(587, 20);
        }

        private void radioButtonPesquisarPorLogin_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisaTipo.Text = "Login: ";
            textBoxPesquisa.Location = new Point(283, 82);
            textBoxPesquisa.Size = new Size(587, 20);
        }

        private void radioButtonPesquisarPorCodigo_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisaTipo.Text = "Código: ";
            textBoxPesquisa.Location = new Point(283, 82);
            textBoxPesquisa.Size = new Size(587, 20);
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (labelModuloTitulo.Text == "Alunos"){
                FrmMenuInserirAluno frmMenuInserirAluno = new FrmMenuInserirAluno();
                frmMenuInserirAluno.ShowDialog();
            }
            if (labelModuloTitulo.Text == "TCCs")
            {
                FrmMenuInserirTCC frmMenuInserirTCC = new FrmMenuInserirTCC();
                frmMenuInserirTCC.ShowDialog();
            }
            if (labelModuloTitulo.Text == "Professores")
            {
                FrmMenuInserirProfessor frmMenuInserirProfessor = new FrmMenuInserirProfessor();
                frmMenuInserirProfessor.ShowDialog();
            }
            if (labelModuloTitulo.Text == "Cursos")
            {
                FrmMenuInserirCurso frmMenuInserirCurso = new FrmMenuInserirCurso();
                frmMenuInserirCurso.ShowDialog();
            }
            if (labelModuloTitulo.Text == "Unidades")
            {
                FrmMenuInserirUnidade frmMenuInserirUnidade = new FrmMenuInserirUnidade();
                frmMenuInserirUnidade.ShowDialog();
                AtualizarGrid();
            }
            if (labelModuloTitulo.Text == "Salas")
            {
                FrmMenuInserirSala frmMenuInserirSala = new FrmMenuInserirSala();
                frmMenuInserirSala.ShowDialog();
            }
            if (labelModuloTitulo.Text == "Usuários")
            {
                FrmMenuInserirUsuario frmMenuInserirUsuario = new FrmMenuInserirUsuario();
                frmMenuInserirUsuario.ShowDialog();
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
                FrmMenuAlterarAluno frmMenuAlterarAluno = new FrmMenuAlterarAluno();
                frmMenuAlterarAluno.ShowDialog();
            }

            if (labelModuloTitulo.Text == "TCCs")
            {
                FrmMenuAlterarTCC frmMenuAlterarTCC = new FrmMenuAlterarTCC();
                frmMenuAlterarTCC.ShowDialog();
            }
            if (labelModuloTitulo.Text == "Professores")
            {
                FrmMenuAlterarProfessor frmMenuAlterarProfessor = new FrmMenuAlterarProfessor();
                frmMenuAlterarProfessor.ShowDialog();
            }
            if (labelModuloTitulo.Text == "Cursos")
            {
                FrmMenuAlterarCurso frmMenuAlterarCurso = new FrmMenuAlterarCurso();
                frmMenuAlterarCurso.ShowDialog();
            }
            if (labelModuloTitulo.Text == "Unidades")
            {
                Unidade unidadeSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Unidade);

                FrmMenuAlterarUnidade frmMenuAlterarUnidade = new FrmMenuAlterarUnidade(unidadeSelecao);
                frmMenuAlterarUnidade.ShowDialog();
                AtualizarGrid();
            }
            if (labelModuloTitulo.Text == "Salas")
            {
                FrmMenuAlterarSala frmMenuAlterarSala = new FrmMenuAlterarSala();
                frmMenuAlterarSala.ShowDialog();
            }
            if (labelModuloTitulo.Text == "Usuários")
            {
                FrmMenuAlterarUsuario frmMenuAlterarUsuario = new FrmMenuAlterarUsuario();
                frmMenuAlterarUsuario.ShowDialog();
            }
        }

        private void AtualizarGrid()
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
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void textBoxPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AtualizarGrid();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (labelModuloTitulo.Text == "Unidades") 
            {
                if (dataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma registro selecionado!", "Erro");
                    return;
                }
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esse registro do sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    return;
                }

                Unidade unidadeSelecao = (dataGridView.SelectedRows[0].DataBoundItem as Unidade);
                UnidadeNegocios unidadeNegocios = new UnidadeNegocios();
                string retorno = unidadeNegocios.Excluir(unidadeSelecao);

                try
                {
                    int UnidadeID = Convert.ToInt32(retorno);

                    MessageBox.Show("Registro excluído com sucesso", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    AtualizarGrid();
                }
                catch
                {
                    MessageBox.Show("Não foi possível excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
