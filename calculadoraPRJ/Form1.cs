using System.Windows.Forms;

namespace calculadoraPRJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal primeironumero, segundonumero, valortotal;
            string mensagem;

            valortotal = 1;
            primeironumero = NUDprimeironumero.Value;
            segundonumero = NUDsegundonumero.Value;

            textBox1.Clear();
            NUDprimeironumero.Focus();



            if (radiomais.Checked == true)
            {
                valortotal = primeironumero + segundonumero;
                mensagem = "o valor da soma � " + valortotal;

            }
            else if (radiomenos.Checked == true)
            {

                valortotal = primeironumero - segundonumero;
                mensagem = "o valor do menos � " + valortotal;
            }
            else if (radiovezes.Checked == true)
            {

                valortotal = primeironumero * segundonumero;
                mensagem = "o valor da divis�o � " + valortotal;

            }
            else
            {

                if (NUDprimeironumero.Value == 0 || NUDsegundonumero.Value == 0)
                {
                    mensagem = "numero para divis�o invalido ";

                }
                else
                {

                    valortotal = primeironumero / segundonumero;
                    mensagem = "o valor da divis�o � " + valortotal;
                }

            }

            MessageBox.Show(mensagem, "aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);




        }
    }
}