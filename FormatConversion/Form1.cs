using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatConversion
{
    public partial class FrmNumConv : Form
    {
        public FrmNumConv()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // usando valores ASCII do teclado pra manejar os itens permitidos
            const int BACKSPACE = 8;
            const int DECIMAL_POINT = 44;
            const int ZERO = 48;
            const int NOVE = 57;
            const int NAO_ENCONTRADO = -1;

            int keyvalue = (int)e.KeyChar; // não necessariamente precisa fazer o casting pra int 

            if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NOVE))) return;
            // PERMITINDO SOMENTE O PRIMEIRO . (PONTO) NOS NÚMEROS
            if ((keyvalue == DECIMAL_POINT) && (txtNumero.Text.IndexOf(",") == NAO_ENCONTRADO)) return;
            // PERMITINDO TODO O RESTO
            e.Handled = true;
        }

        private void btnConverte_Click(object sender, EventArgs e)
        {

            //falta ver se está vazio
            if (txtNumero.Text != ""){

                double numDigitado = double.Parse(txtNumero.Text);
                Console.WriteLine(numDigitado);

                int numConvertido = (int)numDigitado;
                Console.WriteLine(numConvertido);

                lblConvertido.Text = numConvertido.ToString();
            } else {
                MessageBox.Show("Digite um número!!");
            }
        }
    }
}
