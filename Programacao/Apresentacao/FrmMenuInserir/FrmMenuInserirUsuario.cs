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
    public partial class FrmMenuInserirUsuario : Form
    {
        public FrmMenuInserirUsuario()
        {
            InitializeComponent();
        }

        private void buttonInserirUsuarioCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenuInserirUsuario_Load(object sender, EventArgs e)
        {

        }

        private void buttonInserirUsuarioConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxInserirUsuarioLogin.Text == "" || textBoxInserirUsuarioSenha.Text == ""
                || comboBoxInserirUsuarioGrupo.Text == "" || textBoxInserirUsuarioNome.Text == "")
            {
                FrmInserirConfirmacaoProblema frmInserirConfirmacaoProblema = new FrmInserirConfirmacaoProblema();
                frmInserirConfirmacaoProblema.ShowDialog();
            }
            else
            {
                FrmInserirConfirmacaoSucesso frmInserirConfirmacaoSucesso = new FrmInserirConfirmacaoSucesso();
                frmInserirConfirmacaoSucesso.ShowDialog();
                this.Close();
            }
        }
    }
}
