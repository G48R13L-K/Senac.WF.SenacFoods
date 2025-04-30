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
            this.Hide();
            var FrmPrincipal = new FrmPrincipal();
            FrmPrincipal.Show();
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
