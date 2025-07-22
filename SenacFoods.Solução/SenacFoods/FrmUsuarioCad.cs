using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
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
                comboPerfil.Text = _usuario.Perfil;
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
                string Perfil = comboPerfil.Text;



                if (string.IsNullOrEmpty(nomeUsuario))
                {
                    MessageBox.Show("Nome do usuário não pode ser nulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(Email))
                {
                    MessageBox.Show("Email não pode ser nulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MskSenha.Text != MskConfirmacaoSenha.Text)
                {
                    MessageBox.Show("As senhas precisam ser iguais.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MskSenha.Text.Length < 5)
                {
                    MessageBox.Show("A senha precisam ter mais de 5 digitos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                //Atualiza as informações
                var usuario = banco.Usuarios.First(x => x.Id == _usuario.Id);
                usuario.Nome = nomeUsuario;
                usuario.Email = Email;
                usuario.Senha = senha;
                usuario.Ativo = usuarioAtivo;
                usuario.Perfil = Perfil;
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
                string perfil = comboPerfil.Text;

                if (string.IsNullOrEmpty(nomeUsuario))
                {
                    MessageBox.Show("Nome do usuário não pode ser nulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(Email))
                {
                    MessageBox.Show("Email não pode ser nulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MskSenha.Text != MskConfirmacaoSenha.Text)
                {
                    MessageBox.Show("As senhas precisam ser iguais.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MskSenha.Text.Length < 5)
                {
                    MessageBox.Show("A senha precisam ter mais de 5 digitos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                //criar um novo item cardapio
                var usuario = new Usuario()
                {
                    Nome = nomeUsuario,
                    Email = Email,
                    Senha = senha,
                    Ativo = usuarioAtivo,
                    Perfil = perfil
                };



                //Salva as informações
                banco.Usuarios.Add(usuario);
                banco.SaveChanges();

                MessageBox.Show("Usuário salvo com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
                           
                            
                        

        }
                    
                    
                
            
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}

