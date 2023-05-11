using System.Windows.Forms;

namespace AtividadeDeTreinoPRJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal real;
            decimal ValorTotal;
            string mensagem;

            mensagem = "WU";

            NUDnumeros.Focus();

            if (NUDnumeros.Value == 0)
            {
                NUDnumeros.Focus();

                mensagem = "preencha os dados corretamente";

            }
            else if (NUDnumeros.Value > 0)
            {


                real = NUDnumeros.Value;

                if (RADIOd�lar.Checked == true)
                {
                    NUDnumeros.Focus();
                    ValorTotal = real * 0.20m;
                    mensagem = "o valor convertido para D�lar � " + ValorTotal;
                    MessageBox.Show(mensagem, "aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                else if (RADIOeuro.Checked == true)
                {
                    NUDnumeros.Focus();

                    ValorTotal = real * 0.18m;
                    mensagem = "o valor convertido para Euros � " + ValorTotal;
                    MessageBox.Show(mensagem, "aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }



            }

            MessageBox.Show(mensagem, "aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXTsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BNTeuro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BNTd�lar_CheckedChanged(object sender, EventArgs e)
        {
        }
    }

    internal record struct NewStruct(string Item1, decimal ValorTotal, object Item3)
    {
        public static implicit operator (string, decimal ValorTotal, object)(NewStruct value)
        {
            return (value.Item1, value.ValorTotal, value.Item3);
        }

        public static implicit operator NewStruct((string, decimal ValorTotal, object) value)
        {
            return new NewStruct(value.Item1, value.ValorTotal, value.Item3);
        }
    }
}