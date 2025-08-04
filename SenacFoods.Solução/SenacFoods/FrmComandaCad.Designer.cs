namespace SenacFoods
{
    partial class FrmComandaCad
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
            txtCardapio = new TextBox();
            cmbMesa = new ComboBox();
            btnMaisItems = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btnCancelar = new Button();
            btnSalvar = new Button();
            label2 = new Label();
            label1 = new Label();
            txtnomeCliente = new TextBox();
            btnFechar = new Button();
            label4 = new Label();
            Cardapio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Cardapio
            // 
            Cardapio.BackColor = Color.Black;
            Cardapio.Controls.Add(txtCardapio);
            Cardapio.Controls.Add(cmbMesa);
            Cardapio.Controls.Add(btnMaisItems);
            Cardapio.Controls.Add(label3);
            Cardapio.Controls.Add(dataGridView1);
            Cardapio.Controls.Add(btnCancelar);
            Cardapio.Controls.Add(btnSalvar);
            Cardapio.Controls.Add(label2);
            Cardapio.Controls.Add(label1);
            Cardapio.Controls.Add(txtnomeCliente);
            Cardapio.ForeColor = SystemColors.ControlLightLight;
            Cardapio.Location = new Point(0, 52);
            Cardapio.Name = "Cardapio";
            Cardapio.Size = new Size(801, 398);
            Cardapio.TabIndex = 10;
            Cardapio.TabStop = false;
            Cardapio.Text = "Comanda";
            // 
            // txtCardapio
            // 
            txtCardapio.Location = new Point(113, 163);
            txtCardapio.Name = "txtCardapio";
            txtCardapio.Size = new Size(570, 31);
            txtCardapio.TabIndex = 16;
            // 
            // cmbMesa
            // 
            cmbMesa.FormattingEnabled = true;
            cmbMesa.Location = new Point(113, 110);
            cmbMesa.Name = "cmbMesa";
            cmbMesa.Size = new Size(570, 33);
            cmbMesa.TabIndex = 15;
            // 
            // btnMaisItems
            // 
            btnMaisItems.BackColor = Color.CadetBlue;
            btnMaisItems.FlatAppearance.BorderSize = 0;
            btnMaisItems.FlatStyle = FlatStyle.Flat;
            btnMaisItems.ForeColor = SystemColors.ActiveCaptionText;
            btnMaisItems.Location = new Point(707, 162);
            btnMaisItems.Name = "btnMaisItems";
            btnMaisItems.Size = new Size(66, 34);
            btnMaisItems.TabIndex = 14;
            btnMaisItems.Text = "+";
            btnMaisItems.TextAlign = ContentAlignment.TopCenter;
            btnMaisItems.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 166);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 12;
            label3.Text = "Cardápio";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 212);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(749, 107);
            dataGridView1.TabIndex = 11;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(174, 335);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(193, 41);
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
            btnSalvar.Location = new Point(434, 336);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(192, 40);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 113);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 10;
            label2.Text = "Mesa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 9;
            label1.Text = "Nome Cliente";
            // 
            // txtnomeCliente
            // 
            txtnomeCliente.Location = new Point(22, 61);
            txtnomeCliente.Name = "txtnomeCliente";
            txtnomeCliente.Size = new Size(750, 31);
            txtnomeCliente.TabIndex = 1;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Black;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(745, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(48, 40);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(13, 8);
            label4.Name = "label4";
            label4.Size = new Size(250, 32);
            label4.TabIndex = 8;
            label4.Text = "Cadastro de Comanda";
            // 
            // FrmComandaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(Cardapio);
            Controls.Add(btnFechar);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComandaCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmComandaCad";
            Cardapio.ResumeLayout(false);
            Cardapio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Cardapio;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label label2;
        private Label label1;
        private TextBox txtnomeCliente;
        private Button btnFechar;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private ComboBox cmbMesa;
        private Button btnMaisItems;
        private TextBox txtCardapio;
    }
}