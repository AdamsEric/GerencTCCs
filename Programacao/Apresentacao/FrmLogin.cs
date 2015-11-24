using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTO;
using Negocios;

namespace Apresentacao
{
    public partial class FrmLogin : Form
    {
        public string ValorLogin
        {
            get { return comboBoxLoginUsuario.Text; }
            set { comboBoxLoginUsuario.Text = value; }
        }

        public string ValorGrupo
        {
            get { return labelLoginGrupo.Text; }
            set { labelLoginGrupo.Text = value; }
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void buttonLoginOK_Click(object sender, EventArgs e)
        {
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();

            int verificacao = usuarioNegocios.RealizarLogin(comboBoxLoginUsuario.Text, textBoxLoginSenha.Text);

            if (textBoxLoginSenha.Text == "")
            {
                MessageBox.Show("Informe uma senha.      ", "Acesso negado");
            }
            else
            if (verificacao == 0)
            {
                MessageBox.Show("Senha incorreta.        ", "Acesso negado");
            }
            else
            {
                labelLoginGrupo.Text = usuarioNegocios.VerificarGrupo(verificacao);
                this.Close();
            }


            //textBoxLoginUsuario.Text
            //textBoxLoginSenha
        }

        private void buttonLoginCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsuario.tblUsuario' table. You can move, or remove it, as needed.
            this.tblUsuarioTableAdapter.Fill(this.dataSetUsuario.tblUsuario);
        }

        private void textBoxLoginSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonLoginOK.PerformClick();
            }
        }

        private void comboBoxLoginUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonLoginOK.PerformClick();
            }
        }
    }
}
