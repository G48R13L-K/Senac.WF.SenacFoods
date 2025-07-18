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
    public partial class FrmUsuario : Form
    {
        Usuario? UsuarioSelecionado;
        public FrmUsuario()
        {
            InitializeComponent();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void BuscarUsuario()
        {
            using (var bd = new ComandaDBContest())
            {
                var usuario = bd.Usuarios.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    usuario = usuario.Where(c => c.Nome.Contains(txtPesquisa.Text) ||
                                                    c.Email.Contains(txtPesquisa.Text) ||
                                                    c.Senha.Contains(txtPesquisa.Text));
                }
                //popular o grid
                dataGridView1.DataSource = usuario.ToList();

            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void btnMaisItems_Click(object sender, EventArgs e)
        {
            new FrmUsuarioCad().ShowDialog();
            BuscarUsuario();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {   //seleciona celula na tabela
                UsuarioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
                btnEditar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (UsuarioSelecionado != null)
            {
                //abrir formulario pra edição
                var FrmUsuarioCad = new FrmUsuarioCad(UsuarioSelecionado);
                FrmUsuarioCad.ShowDialog();

                //atualiza o item no cardapio
                BuscarUsuario();
                UsuarioSelecionado = null;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            {
                if (UsuarioSelecionado != null)
                {
                    using (var bancoDeDados = new ComandaDBContest())
                    {
                        bancoDeDados.Usuarios.Remove(UsuarioSelecionado);
                        bancoDeDados.SaveChanges();
                    }
                    MessageBox.Show("Usuário excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BuscarUsuario();
                    UsuarioSelecionado = null;

                }
                else
                {
                    MessageBox.Show("Selecione um usuário para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
