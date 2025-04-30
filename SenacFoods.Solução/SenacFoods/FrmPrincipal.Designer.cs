namespace SenacFoods
{
    partial class FrmPrincipal
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
            groupBox1 = new GroupBox();
            btnUSUARIOS = new Button();
            btnPEDIDO = new Button();
            btnCOMANDA = new Button();
            btnCARDAPIO = new Button();
            btnFechar = new Button();
            btnMinimizar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUSUARIOS);
            groupBox1.Controls.Add(btnPEDIDO);
            groupBox1.Controls.Add(btnCOMANDA);
            groupBox1.Controls.Add(btnCARDAPIO);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(63, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(872, 304);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senac Foods";
            // 
            // btnUSUARIOS
            // 
            btnUSUARIOS.BackColor = Color.LightPink;
            btnUSUARIOS.FlatAppearance.BorderSize = 0;
            btnUSUARIOS.FlatStyle = FlatStyle.Flat;
            btnUSUARIOS.Font = new Font("MV Boli", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUSUARIOS.ForeColor = Color.Black;
            btnUSUARIOS.Location = new Point(661, 69);
            btnUSUARIOS.Name = "btnUSUARIOS";
            btnUSUARIOS.Size = new Size(165, 165);
            btnUSUARIOS.TabIndex = 0;
            btnUSUARIOS.Text = "Usuários";
            btnUSUARIOS.UseVisualStyleBackColor = false;
            btnUSUARIOS.Click += btnUSUARIOS_Click;
            // 
            // btnPEDIDO
            // 
            btnPEDIDO.BackColor = Color.SkyBlue;
            btnPEDIDO.FlatAppearance.BorderSize = 0;
            btnPEDIDO.FlatStyle = FlatStyle.Flat;
            btnPEDIDO.Font = new Font("MV Boli", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPEDIDO.ForeColor = Color.Black;
            btnPEDIDO.Location = new Point(458, 69);
            btnPEDIDO.Name = "btnPEDIDO";
            btnPEDIDO.Size = new Size(165, 165);
            btnPEDIDO.TabIndex = 0;
            btnPEDIDO.Text = "Pedido Cozinha";
            btnPEDIDO.UseVisualStyleBackColor = false;
            btnPEDIDO.Click += btnPEDIDO_Click;
            // 
            // btnCOMANDA
            // 
            btnCOMANDA.BackColor = Color.PaleGreen;
            btnCOMANDA.FlatAppearance.BorderSize = 0;
            btnCOMANDA.FlatStyle = FlatStyle.Flat;
            btnCOMANDA.Font = new Font("MV Boli", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCOMANDA.ForeColor = Color.Black;
            btnCOMANDA.Location = new Point(248, 69);
            btnCOMANDA.Name = "btnCOMANDA";
            btnCOMANDA.Size = new Size(165, 165);
            btnCOMANDA.TabIndex = 0;
            btnCOMANDA.Text = "Comanda";
            btnCOMANDA.UseVisualStyleBackColor = false;
            btnCOMANDA.Click += btnCOMANDA_Click;
            // 
            // btnCARDAPIO
            // 
            btnCARDAPIO.BackColor = Color.SandyBrown;
            btnCARDAPIO.FlatAppearance.BorderSize = 0;
            btnCARDAPIO.FlatStyle = FlatStyle.Flat;
            btnCARDAPIO.Font = new Font("MV Boli", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCARDAPIO.ForeColor = Color.Black;
            btnCARDAPIO.Location = new Point(38, 69);
            btnCARDAPIO.Name = "btnCARDAPIO";
            btnCARDAPIO.Size = new Size(165, 165);
            btnCARDAPIO.TabIndex = 0;
            btnCARDAPIO.Text = "Cardápio";
            btnCARDAPIO.UseVisualStyleBackColor = false;
            btnCARDAPIO.Click += btnCARDAPIO_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Black;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(874, 43);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(61, 45);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Black;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(816, 43);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(61, 45);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.Text = "__";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(978, 594);
            Controls.Add(btnMinimizar);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCARDAPIO;
        private Button btnUSUARIOS;
        private Button btnPEDIDO;
        private Button btnCOMANDA;
        private Button btnFechar;
        private Button btnMinimizar;
    }
}