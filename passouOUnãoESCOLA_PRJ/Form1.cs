using System.DirectoryServices.ActiveDirectory;

namespace passouOUnãoESCOLA_PRJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NUDsegundonumero_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int faltas;
            string mensagem;
            decimal valortotal;
            decimal nota1, nota2, nota3;

            nota1 = NUDnota1.Value;
            nota2 = NUDnota2.Value;
            nota3 = NUDnota3.Value;

            mensagem = "eu";
            faltas = (int)NUDfaltas.Value;

            NUDfaltas.Focus();
            if (faltas > 12)
            {

                mensagem = "repetiu por falta";
                NUDfaltas.Focus();
            }
            else
            {
                NUDfaltas.Focus();
                valortotal = (nota1 + nota2 + nota3) / 3;
                if (valortotal < 4)
                {

                    mensagem = "repetiu por nota com a nota: " + valortotal;
                    NUDfaltas.Focus();
                }
                else if (valortotal > 4 && valortotal < 5.51m)
                {

                    mensagem = "estara conselho de classe com a nota: " + valortotal;
                    NUDfaltas.Focus();
                }
                else
                {

                    mensagem = "aprovado com sucesso parabems com a nota:" + valortotal;
                    NUDfaltas.Focus();
                }



            }
            






            MessageBox.Show(mensagem, "aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}