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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnFechar = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
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
            btnFechar.Location = new Point(725, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(48, 40);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnFechar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(557, 31);
            textBox1.TabIndex = 5;
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
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(Editar);
            groupBox1.Controls.Add(Excluir);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(3, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 339);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardápio";
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.None;
            dataGridView1.AllowDrop = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Gray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Control;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(23, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(728, 236);
            dataGridView1.TabIndex = 3;
            // 
            // Editar
            // 
            Editar.FlatAppearance.BorderSize = 0;
            Editar.FlatStyle = FlatStyle.Flat;
            Editar.ForeColor = SystemColors.Control;
            Editar.Location = new Point(633, 287);
            Editar.Name = "Editar";
            Editar.Size = new Size(118, 39);
            Editar.TabIndex = 2;
            Editar.Text = "# Editar";
            Editar.UseVisualStyleBackColor = true;
            // 
            // Excluir
            // 
            Excluir.FlatAppearance.BorderSize = 0;
            Excluir.FlatStyle = FlatStyle.Flat;
            Excluir.ForeColor = SystemColors.Control;
            Excluir.Location = new Point(503, 287);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(118, 39);
            Excluir.TabIndex = 1;
            Excluir.Text = "X Excluir";
            Excluir.UseVisualStyleBackColor = true;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(802, 450);
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
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}