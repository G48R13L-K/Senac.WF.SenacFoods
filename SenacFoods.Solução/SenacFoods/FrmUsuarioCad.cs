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
    public partial class FrmUsuarioCad : Form
    {
        private Usuario _usuario;
        public FrmUsuarioCad()
        {
            InitializeComponent();
            
        }

        public FrmUsuarioCad(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();

            //Carregar os dados da tela
            CarregarDadosDaTela();


        }

        private void CarregarDadosDaTela()
        {
            if (_usuario != null)
            {

                txtNomeUsuario.Text = _usuario.Nome;
                TxtEmail.Text = _usuario.Email;
                MskSenha.Text = _usuario.Senha;
                chkUsuarioAtivo.Checked = _usuario.Ativo;
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (_usuario == null)
            {
                InserirUsuario();
            }
            //atualizar
            else
            {
                AtualizarUsuario();
            }

        }

        private void AtualizarUsuario()
        {
            using (var banco = new ComandaDBContest())
            {   //Capta as informações
                string nomeUsuario = txtNomeUsuario.Text;
                string Email = TxtEmail.Text;
                string senha = MskSenha.Text;
                bool usuarioAtivo = chkUsuarioAtivo.Checked;
                //Atualiza as informações
                var usuario = banco.Usuarios.First(x => x.Id == _usuario.Id);
                usuario.Nome = nomeUsuario;
                usuario.Email = Email;
                usuario.Senha = senha;
                usuario.Ativo = usuarioAtivo;
                if (MskSenha.Text == MskConfirmacaoSenha.Text)
                {
                    //Salva as informações
                    banco.Usuarios.Update(usuario);
                    banco.SaveChanges();

                    MessageBox.Show("Usuário salvo com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("As senhas precisam ser iguais.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void InserirUsuario()
        {
            using (var banco = new ComandaDBContest())
            {

                //captar os dados da tela
                string nomeUsuario = txtNomeUsuario.Text;
                string Email = TxtEmail.Text;
                string senha = MskSenha.Text;
                bool usuarioAtivo = chkUsuarioAtivo.Checked;
                

                //criar um novo item cardapio
                var usuario = new Usuario()
                {
                    Nome = nomeUsuario,
                    Email = Email,
                    Senha = senha,
                    Ativo = usuarioAtivo,
                   

                };

                //adiciona o cardapio
                banco.Usuarios.Add(usuario);

                //salva as alterações
                banco.SaveChanges();
            }
            MessageBox.Show("Usuário salvo com sucesso!", "Sucesso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}

