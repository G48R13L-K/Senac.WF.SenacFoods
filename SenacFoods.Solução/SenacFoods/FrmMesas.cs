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
        Mesa? mesaSelecionada;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {   //seleciona celula na tabela
                mesaSelecionada = dataGridView1.Rows[e.RowIndex].DataBoundItem as Mesa;
                btnEditar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (mesaSelecionada != null)
            {
                //abrir formulario pra edição
                var frmMesaCad = new FrmMesasCad(mesaSelecionada);
                frmMesaCad.ShowDialog();

                //atualiza o item no cardapio
                BuscarMesas();
                mesaSelecionada = null;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            {
                if (mesaSelecionada != null)
                {
                    using (var bancoDeDados = new ComandaDBContest())
                    {
                        bancoDeDados.Mesas.Remove(mesaSelecionada);
                        bancoDeDados.SaveChanges();
                    }
                    MessageBox.Show("Mesa excluida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BuscarMesas();
                    mesaSelecionada = null;

                }
                else
                {
                    MessageBox.Show("Selecione uma mesa para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
