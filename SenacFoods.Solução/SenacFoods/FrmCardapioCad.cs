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
    public partial class FrmCardapioCad : Form
    {
        private CardapioItem _cardapioItem;
        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        public FrmCardapioCad(CardapioItem cardapioItem)
        {
            _cardapioItem = cardapioItem;
            InitializeComponent();

            //Carregar os dados da tela
            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            //Popular os campos de texto e checkbox
            if(_cardapioItem != null)
            { 
                txtTitulo.Text = _cardapioItem.Titulo;
                txtDescricao.Text = _cardapioItem.Descricao;
                txtPreco.Text = _cardapioItem.Preco.ToString("F2");
                chkPossuiPreparo.Checked = _cardapioItem.PossuiPreparo;

            }
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {   //inserir
            if (_cardapioItem == null)
            {
                InserirCardapio();
            }
            //atualizar
            else
            {
                AtualizarCardapio();
            }
            
        }

        private void AtualizarCardapio()
        {
            using(var banco = new ComandaDBContest())
            {   //Capta as informações
                string titulo = txtTitulo.Text;
                string descricao= txtDescricao.Text;
                decimal.TryParse(txtPreco.Text, out var preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;
                //Atualiza as informações
                var cardapioItem = banco.CardapioItems.First(x => x.Id == _cardapioItem.Id);
                cardapioItem.Titulo = titulo;
                cardapioItem.Descricao = descricao;
                cardapioItem.Preco = preco;
                cardapioItem.PossuiPreparo= possuiPreparo;
                //Salva as informações
                banco.CardapioItems.Update(cardapioItem);
                banco.SaveChanges();

                MessageBox.Show("Cardápio salvo com sucesso!", "Sucesso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void InserirCardapio()
        {
            //conectar
            using (var banco = new ComandaDBContest())
            {

                //captar os dados da tela
                string titulo = txtTitulo.Text;
                string descricao = txtDescricao.Text;
                decimal.TryParse(txtPreco.Text, out var preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;

                //criar um novo item cardapio
                var cardapio = new CardapioItem()
                {
                    Descricao = descricao,
                    Titulo = titulo,
                    Preco = preco,
                    PossuiPreparo = possuiPreparo
                };

                //adiciona o cardapio
                banco.CardapioItems.Add(cardapio);

                //salva as alterações
                banco.SaveChanges();
            }
            MessageBox.Show("Cardápio salvo com sucesso!", "Sucesso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
