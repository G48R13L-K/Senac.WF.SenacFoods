namespace SenacFoods
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel1 = new Panel();
            panel2 = new Panel();
            btnFechar = new Button();
            btnENTRADA = new Button();
            txtUsuario = new TextBox();
            txtSENHA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 594);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnFechar);
            panel2.Controls.Add(btnENTRADA);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(txtSENHA);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(326, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(652, 594);
            panel2.TabIndex = 2;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Black;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(579, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(61, 45);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnENTRADA
            // 
            btnENTRADA.FlatAppearance.BorderSize = 0;
            btnENTRADA.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnENTRADA.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnENTRADA.FlatStyle = FlatStyle.Flat;
            btnENTRADA.Font = new Font("MS UI Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnENTRADA.ForeColor = Color.White;
            btnENTRADA.Location = new Point(69, 391);
            btnENTRADA.Name = "btnENTRADA";
            btnENTRADA.Size = new Size(501, 51);
            btnENTRADA.TabIndex = 3;
            btnENTRADA.Text = "ENTRAR";
            btnENTRADA.UseVisualStyleBackColor = true;
            btnENTRADA.Click += btnENTRADA_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Black;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("MS UI Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(69, 186);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(502, 28);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUÁRIO";
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtSENHA
            // 
            txtSENHA.BackColor = Color.Black;
            txtSENHA.BorderStyle = BorderStyle.None;
            txtSENHA.Font = new Font("MS UI Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSENHA.ForeColor = Color.White;
            txtSENHA.Location = new Point(69, 282);
            txtSENHA.Name = "txtSENHA";
            txtSENHA.Size = new Size(502, 28);
            txtSENHA.TabIndex = 2;
            txtSENHA.Text = "SENHA";
            txtSENHA.Enter += txtSENHA_Enter;
            txtSENHA.Leave += txtSENHA_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(63, 184);
            label3.Name = "label3";
            label3.Size = new Size(521, 38);
            label3.TabIndex = 2;
            label3.Text = "__________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(63, 279);
            label2.Name = "label2";
            label2.Size = new Size(521, 38);
            label2.TabIndex = 2;
            label2.Text = "__________________________________________";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(3, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 205);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(978, 594);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private TextBox txtSENHA;
        private TextBox txtUsuario;
        private Label label2;
        private Label label3;
        private Button btnENTRADA;
        private Button btnFechar;
        private PictureBox pictureBox1;
    }
}
