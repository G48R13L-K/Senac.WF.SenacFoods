using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(string nome, string senha)
        {
            InitializeComponent();
            //exibe nome do usuario
            lblMensagem.Text = "Bem vindo "+nome;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            var FrmLogin = new FrmLogin();
            FrmLogin.Show();
        }

        private void btnCARDAPIO_Click(object sender, EventArgs e)
        {

            var FrmCardapio = new FrmCardapio();
            FrmCardapio.ShowDialog();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       
        }

        private void btnCOMANDA_Click(object sender, EventArgs e)
        {
            var FrmComanda = new FrnComanda();
            FrmComanda.ShowDialog();
        }

        private void btnPEDIDO_Click(object sender, EventArgs e)
        {
            var FrmPedidoCozinha = new FrmPedidoCozinha();
            FrmPedidoCozinha.ShowDialog();
        }
    }
}
