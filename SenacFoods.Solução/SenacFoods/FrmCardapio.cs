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
            using(var Bd=new ComandaDBContest())
            {
                //consultar tabela cardapioItem
                var cardapio = Bd.CardapioItems.ToList(); 
                //popular o grip
                dataGridView1.DataSource = cardapio;
            }
            
           
        }
    }
}
