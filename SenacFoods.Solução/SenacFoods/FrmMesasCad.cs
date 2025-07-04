using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmMesasCad : Form
    {
        public FrmMesasCad()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            SalvarMesas();
        }

        private void SalvarMesas()
        {
            //conectar
            using (var banco = new ComandaDBContest())
            {

                //captar os dados da tela
                int.TryParse(txtNumeroMesa.Text, out int numeroMesa);



                //criar um nova mesa
                var Mesa = new Mesa()
                {
                    NumeroMesa = numeroMesa
                };

                //adiciona o mesa
                banco.Mesas.Add(Mesa);

                //salva as alterações
                banco.SaveChanges();
            }
            MessageBox.Show("Mesa salva com sucesso!", "Sucesso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtNumeroMesa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
