using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmCardapio : Form
    {
        CardapioItem? cardapioSelecionado;
        public FrmCardapio()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCardapio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
        {
            //conectar banco de dados
            using (var Bd = new ComandaDBContest())
            {
                //consultar tabela cardapioItem (barra de pesquisa)
                var cardapio = Bd.CardapioItems.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    cardapio = cardapio.Where(c => c.Titulo.Contains(txtPesquisa.Text) ||
                                                    c.Descricao.Contains(txtPesquisa.Text));
                }
                //popular o grid
                dataGridView1.DataSource = cardapio.ToList();
            }


        }

        private void btnMaisItems_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
            BuscarCardapio();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            //Chamar o metodo buscar cardapio
            BuscarCardapio();
        }





        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {   //seleciona celula na tabela
                cardapioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as CardapioItem;
                btnEditar.Enabled = true;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
            {
                //abrir formulario pra edição
                var frmCardapioCad = new FrmCardapioCad(cardapioSelecionado);
                frmCardapioCad.ShowDialog();

                //atualiza o item no cardapio
                BuscarCardapio();
                cardapioSelecionado=null;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            {
                if (cardapioSelecionado != null)
                {
                    using (var bancoDeDados = new ComandaDBContest())
                    {
                        bancoDeDados.CardapioItems.Remove(cardapioSelecionado);
                        bancoDeDados.SaveChanges();
                    }
                    MessageBox.Show("Cardápio excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BuscarCardapio();
                    cardapioSelecionado = null;

                }
                else
                {
                    MessageBox.Show("Selecione um cardápio para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           
        }
    }
}
