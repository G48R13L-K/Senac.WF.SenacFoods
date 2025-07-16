namespace SenacFoods
{
    public partial class FrmMesasCad : Form
    {
        private Mesa _mesaSelecionada;

        public FrmMesasCad(Mesa mesaSelecionada)
        {
            _mesaSelecionada = mesaSelecionada;
            InitializeComponent();

            carregarDadosTela();
        }

        private void carregarDadosTela()
        {
            //Popular os campos de texto e checkbox
            if (_mesaSelecionada != null)
            {
                txtNumeroMesa.Text = _mesaSelecionada.NumeroMesa.ToString();

            }
        }


        public FrmMesasCad()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {//inserir
            if (_mesaSelecionada == null)
            {
                InserirMesa();
            }
            //atualizar
            else
            {
                AtualizarCardapio();
            }

        }


        private void AtualizarCardapio()
        {
            using (var banco = new ComandaDBContest())
            {   //Capta as informações
                int.TryParse(txtNumeroMesa.Text, out int numeroMesa);

                //Atualiza as informações
                var mesa = banco.Mesas.First(x => x.Id == _mesaSelecionada.Id);
                mesa.NumeroMesa = numeroMesa;

                //Salva as informações
                banco.Mesas.Update(mesa);
                banco.SaveChanges();

                MessageBox.Show("Mesa salva com sucesso!", "Sucesso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void InserirMesa()
        {
            //conectar
            using (var banco = new ComandaDBContest())
            {

                //captar os dados da tela
                int.TryParse(txtNumeroMesa.Text, out int numeroMesa);



                //criar um nova mesa
                var Mesa = new Mesa()
                {
                    NumeroMesa = numeroMesa
                };

                //adiciona o mesa
                banco.Mesas.Add(Mesa);

                //salva as alterações
                banco.SaveChanges();
            }
            MessageBox.Show("Mesa salva com sucesso!", "Sucesso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
