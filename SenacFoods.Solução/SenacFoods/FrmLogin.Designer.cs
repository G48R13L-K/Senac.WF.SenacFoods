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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnENTRADA = new Button();
            txtLOGIN = new TextBox();
            txtSENHA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 141);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 594);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnENTRADA);
            panel2.Controls.Add(txtLOGIN);
            panel2.Controls.Add(txtSENHA);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(326, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(652, 594);
            panel2.TabIndex = 2;
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
            // 
            // txtLOGIN
            // 
            txtLOGIN.BackColor = Color.Black;
            txtLOGIN.BorderStyle = BorderStyle.None;
            txtLOGIN.Font = new Font("MS UI Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLOGIN.ForeColor = Color.White;
            txtLOGIN.Location = new Point(69, 186);
            txtLOGIN.Name = "txtLOGIN";
            txtLOGIN.Size = new Size(502, 28);
            txtLOGIN.TabIndex = 0;
            txtLOGIN.Text = "USUÁRIO";
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
            txtSENHA.TabIndex = 1;
            txtSENHA.Text = "SENHA";
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
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(978, 594);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtSENHA;
        private TextBox txtLOGIN;
        private Label label2;
        private Label label3;
        private Button btnENTRADA;
    }
}
