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
    public partial class FrmMenuInserirUnidade : Form
    {
        public FrmMenuInserirUnidade()
        {
            InitializeComponent();
        }

        private void buttonInserirUnidadeCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInserirUnidadeConfirmar_Click(object sender, EventArgs e)
        {
            Unidade unidade = new Unidade();
            unidade.UnidadeNome = textBoxInserirUnidadeNome.Text;
            unidade.UnidadeCidade = textBoxInserirUnidadeCidade.Text;
            unidade.UnidadeEstado = textBoxInserirUnidadeEstado.Text;
            unidade.UnidadePais = textBoxInserirUnidadePais.Text;

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
    }
}
