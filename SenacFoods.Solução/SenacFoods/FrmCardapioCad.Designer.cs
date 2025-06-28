
namespace SenacFoods
{
    partial class FrmCardapioCad    {
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
            btnFechar = new Button();
            Cardapio = new GroupBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtDescricao = new RichTextBox();
            chkPossuiPreparo = new CheckBox();
            label3 = new Label();
            txtPreco = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtTitulo = new TextBox();
            label4 = new Label();
            Cardapio.SuspendLayout();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Black;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(744, 9);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(48, 40);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click_1;
            // 
            // Cardapio
            // 
            Cardapio.BackColor = Color.Black;
            Cardapio.Controls.Add(btnCancelar);
            Cardapio.Controls.Add(btnSalvar);
            Cardapio.Controls.Add(txtDescricao);
            Cardapio.Controls.Add(chkPossuiPreparo);
            Cardapio.Controls.Add(label3);
            Cardapio.Controls.Add(txtPreco);
            Cardapio.Controls.Add(label2);
            Cardapio.Controls.Add(label1);
            Cardapio.Controls.Add(txtTitulo);
            Cardapio.ForeColor = SystemColors.ControlLightLight;
            Cardapio.Location = new Point(-1, 58);
            Cardapio.Name = "Cardapio";
            Cardapio.Size = new Size(801, 395);
            Cardapio.TabIndex = 7;
            Cardapio.TabStop = false;
            Cardapio.Text = "Cardápio";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(537, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 40);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(668, 340);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 40);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(23, 141);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(557, 86);
            txtDescricao.TabIndex = 2;
            txtDescricao.Text = "";
            // 
            // chkPossuiPreparo
            // 
            chkPossuiPreparo.AutoSize = true;
            chkPossuiPreparo.Location = new Point(23, 308);
            chkPossuiPreparo.Name = "chkPossuiPreparo";
            chkPossuiPreparo.Size = new Size(163, 29);
            chkPossuiPreparo.TabIndex = 4;
            chkPossuiPreparo.Text = "Possui Preparo?";
            chkPossuiPreparo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 230);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 12;
            label3.Text = "Preço";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(23, 258);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(163, 31);
            txtPreco.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 113);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 10;
            label2.Text = "Descrição";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 40);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 9;
            label1.Text = "Titulo";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(23, 68);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(557, 31);
            txtTitulo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 14);
            label4.Name = "label4";
            label4.Size = new Size(243, 32);
            label4.TabIndex = 0;
            label4.Text = "Cadastro de Cardápio";
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(Cardapio);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrnComanda";
            Cardapio.ResumeLayout(false);
            Cardapio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

       

        #endregion

        private Button btnFechar;
        private GroupBox Cardapio;
        private RichTextBox txtDescricao;
        private CheckBox chkPossuiPreparo;
        private Label label3;
        private TextBox txtPreco;
        private Label label2;
        private Label label1;
        private TextBox txtTitulo;
        private Label label4;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}