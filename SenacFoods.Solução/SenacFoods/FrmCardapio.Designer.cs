namespace SenacFoods
{
    partial class FrmCardapio
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnFechar = new Button();
            panel1 = new Panel();
            txtPesquisa = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnMaisItems = new Button();
            dataGridView1 = new DataGridView();
            Editar = new Button();
            Excluir = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Black;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(901, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(48, 40);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(txtPesquisa);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnFechar);
            panel1.Location = new Point(14, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 570);
            panel1.TabIndex = 3;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(150, 36);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(745, 31);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 4;
            label1.Text = "Pesquisar:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMaisItems);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(Editar);
            groupBox1.Controls.Add(Excluir);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(3, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(946, 486);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardápio";
            // 
            // btnMaisItems
            // 
            btnMaisItems.BackColor = Color.DarkGreen;
            btnMaisItems.FlatAppearance.BorderSize = 0;
            btnMaisItems.FlatStyle = FlatStyle.Flat;
            btnMaisItems.ForeColor = SystemColors.ActiveCaptionText;
            btnMaisItems.Location = new Point(23, 31);
            btnMaisItems.Name = "btnMaisItems";
            btnMaisItems.Size = new Size(118, 39);
            btnMaisItems.TabIndex = 1;
            btnMaisItems.Text = "+ Item";
            btnMaisItems.UseVisualStyleBackColor = false;
            btnMaisItems.Click += btnMaisItems_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.None;
            dataGridView1.AllowDrop = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Gray;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Gray;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.Control;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Location = new Point(23, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(906, 348);
            dataGridView1.TabIndex = 3;
            // 
            // Editar
            // 
            Editar.BackColor = Color.YellowGreen;
            Editar.FlatAppearance.BorderSize = 0;
            Editar.FlatStyle = FlatStyle.Flat;
            Editar.ForeColor = SystemColors.ActiveCaptionText;
            Editar.Location = new Point(811, 430);
            Editar.Name = "Editar";
            Editar.Size = new Size(118, 39);
            Editar.TabIndex = 3;
            Editar.Text = "# Editar";
            Editar.UseVisualStyleBackColor = false;
            // 
            // Excluir
            // 
            Excluir.BackColor = Color.DarkRed;
            Excluir.FlatAppearance.BorderSize = 0;
            Excluir.FlatStyle = FlatStyle.Flat;
            Excluir.ForeColor = Color.Black;
            Excluir.Location = new Point(687, 430);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(118, 39);
            Excluir.TabIndex = 2;
            Excluir.Text = "X Excluir";
            Excluir.UseVisualStyleBackColor = false;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(978, 594);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmCardapio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFechar;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button Editar;
        private Button Excluir;
        private TextBox txtPesquisa;
        private DataGridView dataGridView1;
        private Button btnMaisItems;
    }
}