using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                FrmMenuAlterarUnidade frmMenuAlterarUnidade = new FrmMenuAlterarUnidade();
                frmMenuAlterarUnidade.ShowDialog();
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
    }
}
