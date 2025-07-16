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
            bool loginValido = ValidarLogin(txtUsuario.Text, txtSENHA.Text);
            if (loginValido)
            {
                this.Hide();
                var FrmPrincipal = new FrmPrincipal(txtUsuario.Text, txtSENHA.Text);
                FrmPrincipal.Show();
            }
        }

        private bool ValidarLogin(string nome, string senha)
        {
            bool usuarioValido = false;
            //Conecta no banco
            using (var banco = new ComandaDBContest())
            {   //CONSULTA A TABELA USUARIO
                var usuario = banco.Usuarios.FirstOrDefault(u => u.Email == nome.ToLower() && u.Senha == senha);

                if (usuario is not null)
                    usuarioValido = true;
            }


            if (usuarioValido)
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

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUÁRIO")
            {
                txtUsuario.Text = String.Empty;

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == String.Empty)
            {
                txtUsuario.Text = "USUÁRIO";
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
            if (txtSENHA.Text == String.Empty)
            {
                txtSENHA.Text = "SENHA";
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
