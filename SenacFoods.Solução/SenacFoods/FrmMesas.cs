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
    public partial class FrmMesas : Form
    {
        public FrmMesas()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMesas_Load(object sender, EventArgs e)
        {
            BuscarMesas();
        }

        private void BuscarMesas()
        {
            //conectar banco de dados
            using (var Bd = new ComandaDBContest())
            {
                //consultar tabela Mesas (barra de pesquisa)
                var Mesa = Bd.Mesas.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    Mesa = Mesa.Where(m => m.NumeroMesa == int.Parse(txtPesquisa.Text));
                }
                //popular o grid
                dataGridView1.DataSource = Mesa.ToList();
            }


        }

        private void btnMaisMeasas_Click(object sender, EventArgs e)
        {
            new FrmMesasCad().ShowDialog();
            BuscarMesas();
        }

        private void txtPesquisa_TextChanged_1(object sender, EventArgs e)
        {
            BuscarMesas();
        }
    }
}
