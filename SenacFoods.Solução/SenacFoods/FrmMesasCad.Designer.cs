namespace SenacFoods
{
    partial class FrmMesasCad
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
            Mesas = new GroupBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            label1 = new Label();
            txtNumeroMesa = new TextBox();
            label4 = new Label();
            btnFechar = new Button();
            Mesas.SuspendLayout();
            SuspendLayout();
            // 
            // Mesas
            // 
            Mesas.BackColor = Color.Black;
            Mesas.Controls.Add(btnCancelar);
            Mesas.Controls.Add(btnSalvar);
            Mesas.Controls.Add(label1);
            Mesas.Controls.Add(txtNumeroMesa);
            Mesas.ForeColor = SystemColors.ControlLightLight;
            Mesas.Location = new Point(1, 56);
            Mesas.Name = "Mesas";
            Mesas.Size = new Size(654, 248);
            Mesas.TabIndex = 8;
            Mesas.TabStop = false;
            Mesas.Text = "Mesas";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(140, 143);
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
            btnSalvar.Location = new Point(336, 143);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 40);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 50);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 9;
            label1.Text = "Numero Mesa";
            // 
            // txtNumeroMesa
            // 
            txtNumeroMesa.Location = new Point(32, 93);
            txtNumeroMesa.Name = "txtNumeroMesa";
            txtNumeroMesa.Size = new Size(557, 31);
            txtNumeroMesa.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(205, 32);
            label4.TabIndex = 9;
            label4.Text = "Cadastro de Mesa";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Black;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(597, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(48, 40);
            btnFechar.TabIndex = 10;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmMesasCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(657, 305);
            Controls.Add(btnFechar);
            Controls.Add(label4);
            Controls.Add(Mesas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMesasCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMesasCad";
            Mesas.ResumeLayout(false);
            Mesas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Mesas;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label label1;
        private TextBox txtNumeroMesa;
        private Label label4;
        private Button btnFechar;
    }
}