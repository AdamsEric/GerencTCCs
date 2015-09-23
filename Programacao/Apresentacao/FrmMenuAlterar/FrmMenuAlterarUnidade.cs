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
        public FrmMenuAlterarUnidade(Unidade unidadeSelecao)
        {
            InitializeComponent();

            Unidade unidade = new Unidade();
            unidade.UnidadeID = unidadeSelecao.UnidadeID;

            unidade.UnidadeNome = textBoxAlterarUnidadeNome.Text;
            unidade.UnidadeCidade = textBoxAlterarUnidadeCidade.Text;
            unidade.UnidadeEstado = textBoxAlterarUnidadeEstado.Text;
            unidade.UnidadePais = textBoxAlterarUnidadePais.Text;

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

                    MessageBox.Show("Registro alterado com sucesso! Código: ", "Aviso", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possível completar a operação! Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }

            /*
            try
            {
                int unidadeID = Convert.ToInt32(retorno);

                MessageBox.Show("Registro inserido com sucesso! Código: ", "Aviso", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show("Não foi possível completar a operação! Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }*/


        }

        private void buttonAlterarUnidadeCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAlterarUnidadeConfirmar_Click(object sender, EventArgs e)
        {
            /*
            this.textBoxAlterarUnidadeNome.Text = unidade.UnidadeNome;
            this.textBoxAlterarUnidadeCidade.Text = unidade.UnidadeCidade;
            this.textBoxAlterarUnidadeEstado.Text = unidade.UnidadeEstado;
            this.textBoxAlterarUnidadePais.Text = unidade.UnidadePais;
             */ 
        }
    }
}
