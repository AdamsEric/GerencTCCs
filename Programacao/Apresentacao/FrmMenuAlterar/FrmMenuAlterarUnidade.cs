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
    public partial class FrmMenuAlterarUnidade : Form
    {
        Unidade unidadeold = new Unidade();

        public FrmMenuAlterarUnidade(Unidade unidade)
        {
            InitializeComponent();
            textBoxAlterarUnidadeID.Text = unidade.UnidadeID.ToString();
            textBoxAlterarUnidadeNome.Text = unidade.UnidadeNome;
            textBoxAlterarUnidadeCidade.Text = unidade.UnidadeCidade;
            textBoxAlterarUnidadeEstado.Text = unidade.UnidadeEstado;
            textBoxAlterarUnidadePais.Text = unidade.UnidadePais;

            unidadeold = unidade;
        }

        private void buttonAlterarUnidadeCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAlterarUnidadeConfirmar_Click(object sender, EventArgs e)
        {
            Unidade unidade = new Unidade();

            unidade.UnidadeID = Convert.ToInt32(textBoxAlterarUnidadeID.Text);
            unidade.UnidadeNome = textBoxAlterarUnidadeNome.Text;
            unidade.UnidadeCidade = textBoxAlterarUnidadeCidade.Text;
            unidade.UnidadeEstado = textBoxAlterarUnidadeEstado.Text;
            unidade.UnidadePais = textBoxAlterarUnidadePais.Text;

            if (unidade.UnidadeNome == unidadeold.UnidadeNome && unidade.UnidadeCidade == unidadeold.UnidadeCidade &&
                unidade.UnidadeEstado == unidadeold.UnidadeEstado && unidade.UnidadePais == unidadeold.UnidadePais)
            {
                MessageBox.Show("Os campos não foram alterados");
            }
            else
            {

                if (textBoxAlterarUnidadeNome.Text == "" || unidade.UnidadeCidade == "" ||
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
}
