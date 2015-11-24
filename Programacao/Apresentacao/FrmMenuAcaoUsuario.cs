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
    public partial class FrmMenuAcaoUsuario : Form
    {
        Usuario usuarioold = new Usuario();

        public FrmMenuAcaoUsuario(Usuario usuario, string acao)
        {
            InitializeComponent();

            if (acao == "Inserir Usuario")
            {
                this.Text = "Inserir Usuario";
            }
            else if (acao == "Alterar Usuario")
            {
                this.Text = "Alterar Usuario";
                textBoxAcaoUsuarioID.Text = usuario.UsuarioID.ToString();
                textBoxAcaoUsuarioLogin.Text = usuario.UsuarioLogin;
                textBoxAcaoUsuarioSenha.Text = usuario.UsuarioSenha;
                comboBoxAcaoUsuarioGrupo.Text = usuario.UsuarioGrupoNome;
                textBoxAcaoUsuarioNome.Text = usuario.UsuarioNome;
                textBoxAcaoUsuarioMatricula.Text = usuario.UsuarioMatricula;
                if (usuario.UsuarioSituacao == "A")
                {
                    comboBoxAcaoUsuarioSituacao.Text = "ATIVO";
                }
                else
                {
                    comboBoxAcaoUsuarioSituacao.Text = "INATIVO";
                }

                usuarioold = usuario;
            }
            else if (acao == "Consultar Usuario")
            {
                this.Text = "Consultar Usuario";
                textBoxAcaoUsuarioID.Text = usuario.UsuarioID.ToString();
                textBoxAcaoUsuarioLogin.Text = usuario.UsuarioLogin;
                textBoxAcaoUsuarioSenha.Text = usuario.UsuarioSenha;
                comboBoxAcaoUsuarioGrupo.Visible = false;
                textBoxAcaoUsuarioGrupo.Visible = true;
                textBoxAcaoUsuarioGrupo.Location = new Point(312, 45);
                textBoxAcaoUsuarioGrupo.Text = usuario.UsuarioGrupoNome;
                textBoxAcaoUsuarioNome.Text = usuario.UsuarioNome;
                textBoxAcaoUsuarioMatricula.Text = usuario.UsuarioMatricula;
                comboBoxAcaoUsuarioSituacao.Visible = false;
                textBoxAcaoUsuarioSituacao.Visible = true;
                textBoxAcaoUsuarioSituacao.Location = new Point(355, 74);
                if (usuario.UsuarioSituacao == "A")
                {
                    textBoxAcaoUsuarioSituacao.Text = "ATIVO";
                }
                else
                {
                    textBoxAcaoUsuarioSituacao.Text = "INATIVO";
                }

                buttonAcaoUsuarioConfirmar.Hide();
                buttonAcaoUsuarioCancelar.Hide();
                textBoxAcaoUsuarioSenha.ReadOnly = true;
                textBoxAcaoUsuarioLogin.ReadOnly = true;
                textBoxAcaoUsuarioMatricula.ReadOnly = true;
                textBoxAcaoUsuarioNome.ReadOnly = true;
                textBoxAcaoUsuarioSituacao.ReadOnly = true;
                textBoxAcaoUsuarioSituacao.ReadOnly = true;
                labelAcaoUsuarioCO.Hide();
            }
        }

        private void buttonAcaoUsuarioCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAcaoUsuarioConfirmar_Click(object sender, EventArgs e)
        {
            if (this.Text == "Inserir Usuario")
            {
                Usuario usuario = new Usuario();
                UsuarioNegocios usuarioNegocios = new UsuarioNegocios();

                usuario.UsuarioLogin = textBoxAcaoUsuarioLogin.Text;
                usuario.UsuarioSenha = textBoxAcaoUsuarioSenha.Text;
                usuario.UsuarioGrupoNome = comboBoxAcaoUsuarioGrupo.Text;

                if (comboBoxAcaoUsuarioGrupo.Text != "")
                {
                    usuario.UsuarioGrupoNome = comboBoxAcaoUsuarioGrupo.Text.ToString();
                    usuario.UsuarioGrupoID = usuarioNegocios.RetornaIDGrupo(usuario.UsuarioGrupoNome);
                }

                usuario.UsuarioNome = textBoxAcaoUsuarioNome.Text;
                usuario.UsuarioMatricula = textBoxAcaoUsuarioMatricula.Text;
                if (comboBoxAcaoUsuarioSituacao.Text == "ATIVO")
                {
                    usuario.UsuarioSituacao = "A";
                }
                else
                {
                    usuario.UsuarioSituacao = "I";
                }

                if (usuario.UsuarioLogin == "" || usuario.UsuarioSenha == "" ||
                    usuario.UsuarioGrupoNome == "" || usuario.UsuarioSituacao == "")
                {
                    MessageBox.Show("Favor preencher todos os campos!");
                }
                else
                {
                    string retorno = usuarioNegocios.Inserir(usuario);

                    try
                    {
                        int usuarioID = Convert.ToInt32(retorno);

                        MessageBox.Show("Registro inserido com sucesso! Código cadastrado: " + usuarioID.ToString());
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível completar a operação! Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.No;
                    }
                }
            }

            if (this.Text == "Alterar Usuario")
            {
                Usuario usuario = new Usuario();
                UsuarioNegocios usuarioNegocios = new UsuarioNegocios();

                usuario.UsuarioID = Convert.ToInt32(textBoxAcaoUsuarioID.Text);
                usuario.UsuarioLogin = textBoxAcaoUsuarioLogin.Text;
                usuario.UsuarioSenha = textBoxAcaoUsuarioSenha.Text;
                usuario.UsuarioGrupoNome = Convert.ToString(comboBoxAcaoUsuarioGrupo.Text);

                if (comboBoxAcaoUsuarioGrupo.Text != "")
                {
                    usuario.UsuarioGrupoNome = comboBoxAcaoUsuarioGrupo.SelectedValue.ToString();
                    usuario.UsuarioGrupoID = usuarioNegocios.RetornaIDGrupo(usuario.UsuarioGrupoNome);
                }

                usuario.UsuarioNome = textBoxAcaoUsuarioNome.Text;
                usuario.UsuarioMatricula = textBoxAcaoUsuarioMatricula.Text;
                if (comboBoxAcaoUsuarioSituacao.Text == "ATIVO")
                {
                    usuario.UsuarioSituacao = "A";
                }
                else
                {
                    usuario.UsuarioSituacao = "I";
                }

                if (usuario.UsuarioLogin == "" || usuario.UsuarioSenha == "" ||
                    usuario.UsuarioGrupoNome == "" || usuario.UsuarioSituacao == "" ||
                    usuario.UsuarioNome == "" || usuario.UsuarioMatricula == "")
                {
                    MessageBox.Show("Os campos não foram alterados");
                }
                else
                {

                    if (usuario.UsuarioLogin == "" || usuario.UsuarioSenha == "" ||
                        usuario.UsuarioGrupoNome == "" || usuario.UsuarioSituacao == "")
                    {
                        MessageBox.Show("Favor preencher todos os campos!");
                    }
                    else
                    {
                        string retorno = usuarioNegocios.Alterar(usuario);

                        try
                        {
                        int usuarioID = Convert.ToInt32(retorno);

                        MessageBox.Show("Registro inserido com sucesso! Código: " + usuarioID.ToString());
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

        private void textBoxAcaoUsuarioNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonAcaoUsuarioConfirmar.PerformClick();
            }
        }

        private void textBoxAcaoUsuarioCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonAcaoUsuarioConfirmar.PerformClick();
            }
        }

        private void textBoxAcaoUsuarioEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonAcaoUsuarioConfirmar.PerformClick();
            }
        }

        private void textBoxAcaoUsuarioPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonAcaoUsuarioConfirmar.PerformClick();
            }
        }

        private void FrmMenuAcaoUsuario_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            
            this.tblGrupoTableAdapter.Fill(this.dataSetGrupo.tblGrupo);
            if (usuario.UsuarioGrupoNome == "")
            {
                comboBoxAcaoUsuarioGrupo.SelectedValue = "";
            }
            else
            {
                comboBoxAcaoUsuarioGrupo.Text = usuarioold.UsuarioGrupoNome;
            }

        }
    }
}
