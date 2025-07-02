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
    public partial class FrmCardapio : Form
    {
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
    }
}
