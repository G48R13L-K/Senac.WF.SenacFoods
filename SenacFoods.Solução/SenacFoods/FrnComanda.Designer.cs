namespace SenacFoods
{
    partial class FrnComanda
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtPesquisa = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnMaisItems = new Button();
            dataGridView1 = new DataGridView();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnFechar = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 4;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(150, 36);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(703, 31);
            txtPesquisa.TabIndex = 0;
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
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(3, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(946, 486);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Comanda";
            // 
            // btnMaisItems
            // 
            btnMaisItems.BackColor = Color.YellowGreen;
            btnMaisItems.FlatAppearance.BorderSize = 0;
            btnMaisItems.FlatStyle = FlatStyle.Flat;
            btnMaisItems.ForeColor = SystemColors.ActiveCaptionText;
            btnMaisItems.Location = new Point(23, 31);
            btnMaisItems.Name = "btnMaisItems";
            btnMaisItems.Size = new Size(178, 39);
            btnMaisItems.TabIndex = 1;
            btnMaisItems.Text = "Nova comanda";
            btnMaisItems.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.None;
            dataGridView1.AllowDrop = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.Gray;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.LightGray;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.Gray;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.Control;
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.Location = new Point(23, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(906, 348);
            dataGridView1.TabIndex = 3;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkGreen;
            btnEditar.Enabled = false;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(811, 430);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(118, 39);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "# Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.DarkRed;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Location = new Point(687, 430);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(118, 39);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "X Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
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
            // 
            // FrnComanda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(978, 594);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrnComanda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrnComanda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtPesquisa;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnMaisItems;
        private DataGridView dataGridView1;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnFechar;
    }
}