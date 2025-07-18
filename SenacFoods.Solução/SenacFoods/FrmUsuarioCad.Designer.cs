namespace SenacFoods
{
    partial class FrmUsuarioCad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Cardapio = new GroupBox();
            chkUsuarioAtivo = new CheckBox();
            label5 = new Label();
            comboPerfil = new ComboBox();
            label4 = new Label();
            MskConfirmacaoSenha = new MaskedTextBox();
            MskSenha = new MaskedTextBox();
            TxtEmail = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNomeUsuario = new TextBox();
            label6 = new Label();
            btnFechar = new Button();
            Cardapio.SuspendLayout();
            SuspendLayout();
            // 
            // Cardapio
            // 
            Cardapio.BackColor = Color.Black;
            Cardapio.Controls.Add(chkUsuarioAtivo);
            Cardapio.Controls.Add(label5);
            Cardapio.Controls.Add(comboPerfil);
            Cardapio.Controls.Add(label4);
            Cardapio.Controls.Add(MskConfirmacaoSenha);
            Cardapio.Controls.Add(MskSenha);
            Cardapio.Controls.Add(TxtEmail);
            Cardapio.Controls.Add(btnCancelar);
            Cardapio.Controls.Add(btnSalvar);
            Cardapio.Controls.Add(label3);
            Cardapio.Controls.Add(label2);
            Cardapio.Controls.Add(label1);
            Cardapio.Controls.Add(txtNomeUsuario);
            Cardapio.ForeColor = SystemColors.ControlLightLight;
            Cardapio.Location = new Point(-3, 78);
            Cardapio.Name = "Cardapio";
            Cardapio.Size = new Size(962, 458);
            Cardapio.TabIndex = 8;
            Cardapio.TabStop = false;
            Cardapio.Text = "Usuario";
            // 
            // chkUsuarioAtivo
            // 
            chkUsuarioAtivo.AutoSize = true;
            chkUsuarioAtivo.Location = new Point(384, 312);
            chkUsuarioAtivo.Name = "chkUsuarioAtivo";
            chkUsuarioAtivo.Size = new Size(142, 29);
            chkUsuarioAtivo.TabIndex = 19;
            chkUsuarioAtivo.Text = "Usuario ativo";
            chkUsuarioAtivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 280);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 18;
            label5.Text = "Perfil";
            // 
            // comboPerfil
            // 
            comboPerfil.FormattingEnabled = true;
            comboPerfil.Items.AddRange(new object[] { "Administrador", "Operador" });
            comboPerfil.Location = new Point(46, 308);
            comboPerfil.Name = "comboPerfil";
            comboPerfil.Size = new Size(201, 33);
            comboPerfil.TabIndex = 17;
           
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(384, 204);
            label4.Name = "label4";
            label4.Size = new Size(189, 25);
            label4.TabIndex = 16;
            label4.Text = "Confirmação de senha";
            // 
            // MskConfirmacaoSenha
            // 
            MskConfirmacaoSenha.Location = new Point(384, 232);
            MskConfirmacaoSenha.Name = "MskConfirmacaoSenha";
            MskConfirmacaoSenha.Size = new Size(284, 31);
            MskConfirmacaoSenha.TabIndex = 15;
            // 
            // MskSenha
            // 
            MskSenha.Location = new Point(45, 232);
            MskSenha.Name = "MskSenha";
            MskSenha.Size = new Size(284, 31);
            MskSenha.TabIndex = 14;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(46, 157);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(622, 31);
            TxtEmail.TabIndex = 13;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(412, 378);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 40);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(543, 378);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 40);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 200);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 12;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 129);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 10;
            label2.Text = "E-mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 56);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 9;
            label1.Text = "Nome Usuario";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(45, 84);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(623, 31);
            txtNomeUsuario.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 25);
            label6.Name = "label6";
            label6.Size = new Size(228, 32);
            label6.TabIndex = 9;
            label6.Text = "Cadastro de Usuário";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Black;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(657, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(48, 40);
            btnFechar.TabIndex = 10;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmUsuarioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(717, 523);
            Controls.Add(btnFechar);
            Controls.Add(label6);
            Controls.Add(Cardapio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarioCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuarioCad";
            Cardapio.ResumeLayout(false);
            Cardapio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Cardapio;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNomeUsuario;
        private TextBox TxtEmail;
        private Label label5;
        private ComboBox comboPerfil;
        private Label label4;
        private MaskedTextBox MskConfirmacaoSenha;
        private MaskedTextBox MskSenha;
        private Label label6;
        private Button btnFechar;
        private CheckBox chkUsuarioAtivo;
    }
}