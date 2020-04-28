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
            if (txtNumero.Text != ""){
                // fazer essas tarefas:

                /* Capturando o valor do campo txtNumero, convertendo em double
                 * e colocando na variável numDigitado */
                double numDigitado = double.Parse(txtNumero.Text);


                /* pedindo ao programa para escrever no Output 
                 *  o valor da variável numDigitado */
                Console.WriteLine(numDigitado);


                /* Convertendo o valor da variável numDigitado em int
                 * e colocando esse valor convertido na variável numConvertido */
                int numConvertido = (int)numDigitado;

                /* pedindo ao programa para escrever no Output
                 *  o valor da variável numDigitado */
                Console.WriteLine(numConvertido);

                /* copiando o valor da variável num Convertido em forma 
                 * de texto para o objeto do form lblConvertido */
                lblConvertido.Text = numConvertido.ToString();

            } else {
                // fazer essas tarefas:

                /* Mostrar uma mensagem se não houver número digitado */
                MessageBox.Show("Digite um número!!");
            }
        }
    }
}
