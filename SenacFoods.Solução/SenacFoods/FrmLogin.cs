namespace SenacFoods
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnENTRADA_Click(object sender, EventArgs e)
        {
            bool loginValido = ValidarLogin(txtLOGIN.Text, txtSENHA.Text);
            if (loginValido)
            {
                this.Hide();
                var FrmPrincipal = new FrmPrincipal(txtLOGIN.Text, txtSENHA.Text);
                FrmPrincipal.Show();
            }
        }

        private bool ValidarLogin(string nome, string senha)
        {
            if (nome == "admin" && senha == "123")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Login ou Senha inválidos");
            }
            return false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void txtLOGIN_Enter(object sender, EventArgs e)
        {
            if (txtLOGIN.Text == "USUÁRIO")
            {
                txtLOGIN.Text = String.Empty;

            }
        }

        private void txtLOGIN_Leave(object sender, EventArgs e)
        {
            if (txtLOGIN.Text == String.Empty)
            {
                txtLOGIN.Text = "USUÁRIOS";
            }
        }

        private void txtSENHA_Enter(object sender, EventArgs e)
        {
            if (txtSENHA.Text == "SENHA")
            {
                txtSENHA.Text = String.Empty;
            }
        }

        private void txtSENHA_Leave(object sender, EventArgs e)
        {
            if(txtSENHA.Text == String.Empty)
            {
                txtSENHA.Text = "SENHA";
            }
        }
    }
}
