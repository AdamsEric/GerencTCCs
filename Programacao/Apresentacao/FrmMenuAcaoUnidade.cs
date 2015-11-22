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
    public partial class FrmMenuAcaoUnidade : Form
    {
        Unidade unidadeold = new Unidade();

        public FrmMenuAcaoUnidade(Unidade unidade, string acao)
        {
            InitializeComponent();

            if (acao == "Inserir Unidade")
            {
                this.Text = "Inserir Unidade";
            }
            else if (acao == "Alterar Unidade")
            {
                this.Text = "Alterar Unidade";
                textBoxAcaoUnidadeID.Text = unidade.UnidadeID.ToString();
                textBoxAcaoUnidadeNome.Text = unidade.UnidadeNome;
                textBoxAcaoUnidadeCidade.Text = unidade.UnidadeCidade;
                textBoxAcaoUnidadeEstado.Text = unidade.UnidadeEstado;
                textBoxAcaoUnidadePais.Text = unidade.UnidadePais;

                unidadeold = unidade;
            }
            else if (acao == "Consultar Unidade")
            {
                this.Text = "Consultar Unidade";
                textBoxAcaoUnidadeID.Text = unidade.UnidadeID.ToString();
                textBoxAcaoUnidadeNome.Text = unidade.UnidadeNome;
                textBoxAcaoUnidadeCidade.Text = unidade.UnidadeCidade;
                textBoxAcaoUnidadeEstado.Text = unidade.UnidadeEstado;
                textBoxAcaoUnidadePais.Text = unidade.UnidadePais;

                buttonAcaoUnidadeConfirmar.Hide();
                buttonAcaoUnidadeCancelar.Hide();
                textBoxAcaoUnidadeNome.Enabled = false;
                textBoxAcaoUnidadeCidade.Enabled = false;
                textBoxAcaoUnidadeEstado.Enabled = false;
                textBoxAcaoUnidadePais.Enabled = false;
                labelAcaoUnidadeCO.Hide();
            }
        }

        private void buttonAcaoUnidadeCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAcaoUnidadeConfirmar_Click(object sender, EventArgs e)
        {
            if (this.Text == "Inserir Unidade")
            {
                Unidade unidade = new Unidade();
                unidade.UnidadeNome = textBoxAcaoUnidadeNome.Text;
                unidade.UnidadeCidade = textBoxAcaoUnidadeCidade.Text;
                unidade.UnidadeEstado = textBoxAcaoUnidadeEstado.Text;
                unidade.UnidadePais = textBoxAcaoUnidadePais.Text;

                if (unidade.UnidadeNome == "" || unidade.UnidadeCidade == "" ||
                    unidade.UnidadeEstado == "" || unidade.UnidadePais == "")
                {
                    MessageBox.Show("Favor preencher todos os campos!");
                }
                else
                {
                    UnidadeNegocios unidadeNegocios = new UnidadeNegocios();
                    string retorno = unidadeNegocios.Inserir(unidade);

                    try
                    {
                        int unidadeID = Convert.ToInt32(retorno);

                        MessageBox.Show("Registro inserido com sucesso! Código cadastrado: " + unidadeID.ToString());
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível completar a operação! Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.No;
                    }
                }
            }

            if (this.Text == "Alterar Unidade")
            {
                Unidade unidade = new Unidade();

                unidade.UnidadeID = Convert.ToInt32(textBoxAcaoUnidadeID.Text);
                unidade.UnidadeNome = textBoxAcaoUnidadeNome.Text;
                unidade.UnidadeCidade = textBoxAcaoUnidadeCidade.Text;
                unidade.UnidadeEstado = textBoxAcaoUnidadeEstado.Text;
                unidade.UnidadePais = textBoxAcaoUnidadePais.Text;

                if (unidade.UnidadeNome == unidadeold.UnidadeNome && unidade.UnidadeCidade == unidadeold.UnidadeCidade &&
                    unidade.UnidadeEstado == unidadeold.UnidadeEstado && unidade.UnidadePais == unidadeold.UnidadePais)
                {
                    MessageBox.Show("Os campos não foram alterados");
                }
                else
                {

                    if (unidade.UnidadeNome == "" || unidade.UnidadeCidade == "" ||
                        unidade.UnidadeEstado == "" || unidade.UnidadePais == "")
                    {
                        MessageBox.Show("Favor preencher todos os campos!");
                    }
                    else
                    {
                        UnidadeNegocios unidadeNegocios = new UnidadeNegocios();
                        string retorno = unidadeNegocios.Alterar(unidade);

                        try
                        {
                        int unidadeID = Convert.ToInt32(retorno);

                        MessageBox.Show("Registro inserido com sucesso! Código: " + unidadeID.ToString());
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

        private void textBoxAcaoUnidadeNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonAcaoUnidadeConfirmar.PerformClick();
            }
        }

        private void textBoxAcaoUnidadeCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonAcaoUnidadeConfirmar.PerformClick();
            }
        }

        private void textBoxAcaoUnidadeEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonAcaoUnidadeConfirmar.PerformClick();
            }
        }

        private void textBoxAcaoUnidadePais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonAcaoUnidadeConfirmar.PerformClick();
            }
        }


    }
}
