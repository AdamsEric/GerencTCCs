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
    public partial class FrmMenuAcaoSala : Form
    {
        Sala salaold = new Sala();
       
        public FrmMenuAcaoSala(Sala sala, string acao)
        {
            InitializeComponent();
            SalaNegocios salaNegocios = new SalaNegocios();
            if (acao == "Inserir Sala")
            {
                this.Text = "Inserir Sala";
            }
            else if (acao == "Alterar Sala")
            {
                this.Text = "Alterar Sala";
                textBoxAcaoSalaID.Text = sala.SalaID.ToString();
                textBoxAcaoSalaNome.Text = sala.SalaNome;
                textBoxAcaoSalaDescricao.Text = sala.SalaDescricao;
                comboBoxAcaoSalaUnidadeNome.Text = sala.SalaUnidadeNome;
                comboBoxAcaoSalaTipoNome.Text = sala.SalaSalaTipoNome;
                salaold = sala;
            }
            else if (acao == "Consultar Sala")
            {
                this.Text = "Consultar Sala";
                textBoxAcaoSalaID.Text = sala.SalaID.ToString();
                textBoxAcaoSalaNome.Text = sala.SalaNome;
                textBoxAcaoSalaDescricao.Text = sala.SalaDescricao;
                comboBoxAcaoSalaUnidadeNome.Text = sala.SalaUnidadeNome;
                comboBoxAcaoSalaTipoNome.Text = sala.SalaSalaTipoNome;

                buttonAcaoSalaConfirmar.Hide();
                buttonAcaoSalaCancelar.Hide();
                textBoxAcaoSalaNome.Enabled = false;
                textBoxAcaoSalaDescricao.Enabled = false;
                comboBoxAcaoSalaUnidadeNome.Enabled = false;
                comboBoxAcaoSalaTipoNome.Enabled = false;
                labelAcaoSalaCO.Hide();
            }
        }

        private void buttonAcaoSalaCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAcaoSalaConfirmar_Click(object sender, EventArgs e)
        {
            if (this.Text == "Inserir Sala")
            {
                Sala sala = new Sala();
                SalaNegocios salaNegocios = new SalaNegocios();

                sala.SalaNome = textBoxAcaoSalaNome.Text;
                sala.SalaDescricao = textBoxAcaoSalaDescricao.Text;
                sala.SalaUnidadeNome = comboBoxAcaoSalaUnidadeNome.SelectedValue.ToString();
                sala.SalaUnidadeID = salaNegocios.RetornaUnidadeID(sala.SalaUnidadeNome);
                sala.SalaSalaTipoNome = comboBoxAcaoSalaTipoNome.SelectedValue.ToString();
                sala.SalaSalaTipoID = salaNegocios.RetornaSalaTipoID(sala.SalaSalaTipoNome);

                if (sala.SalaNome == "" && sala.SalaDescricao == "" 
                    && sala.SalaUnidadeID.ToString() == "" && sala.SalaSalaTipoID.ToString() == "")
                {
                    MessageBox.Show("Favor preencher todos os campos!");
                }
                else
                {
                    string retorno = salaNegocios.Inserir(sala);

                    try
                    {
                        int salaID = Convert.ToInt32(retorno);

                        MessageBox.Show("Registro inserido com sucesso! Código cadastrado: " + salaID.ToString());
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível completar a operação! Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.No;
                    }
                }
            }

            if (this.Text == "Alterar Sala")
            {
                Sala sala = new Sala();
                SalaNegocios salaNegocios = new SalaNegocios();

                sala.SalaNome = textBoxAcaoSalaNome.Text;
                sala.SalaDescricao = textBoxAcaoSalaDescricao.Text;
                sala.SalaUnidadeNome = comboBoxAcaoSalaUnidadeNome.SelectedValue.ToString();
                sala.SalaUnidadeID = salaNegocios.RetornaUnidadeID(sala.SalaUnidadeNome);
                sala.SalaSalaTipoNome = comboBoxAcaoSalaTipoNome.SelectedValue.ToString();
                sala.SalaSalaTipoID = salaNegocios.RetornaSalaTipoID(sala.SalaSalaTipoNome);

                if (sala.SalaNome == "" && sala.SalaDescricao == ""
                    && sala.SalaUnidadeID.ToString() == "" && sala.SalaSalaTipoID.ToString() == "")
                {
                    MessageBox.Show("Favor preencher todos os campos!");
                }

                if (sala.SalaNome == salaold.SalaNome && sala.SalaUnidadeNome == salaold.SalaUnidadeNome)
                {
                    MessageBox.Show("Os campos não foram alterados");
                }
                else
                {

                    if (sala.SalaNome == "" || sala.SalaUnidadeNome == "")
                    {
                        MessageBox.Show("Favor preencher todos os campos!");
                    }
                    else
                    {
                        string retorno = salaNegocios.Alterar(sala);

                        try
                        {
                            int salaID = Convert.ToInt32(retorno);

                            MessageBox.Show("Registro inserido com sucesso! Código: " + salaID.ToString());
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

        private void comboBoxAcaoSalaTipo_Click(object sender, EventArgs e)
        {
            this.tblSalaTipoTableAdapter.Fill(this.gerencTCCsDataSet18.tblSalaTipo);
            if (salaold.SalaSalaTipoNome == "")
            {
                comboBoxAcaoSalaTipoNome.Text = "";
            }
            else
            {
                comboBoxAcaoSalaTipoNome.Text = salaold.SalaUnidadeNome;
            }
        }

        private void comboBoxAcaoSalaUnidadeNome_Click(object sender, EventArgs e)
        {
            this.tblUnidadeTableAdapter.Fill(this.gerencTCCsDataSet19.tblUnidade);
            if (salaold.SalaUnidadeNome == "")
            {
                comboBoxAcaoSalaUnidadeNome.Text = "";
            }
            else
            {
                comboBoxAcaoSalaUnidadeNome.Text = salaold.SalaUnidadeNome;
            }
        }
    }
}
