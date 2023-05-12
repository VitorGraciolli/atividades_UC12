namespace calculodesalarioPRJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {

            string msg;
            decimal bruto,imposto,taxtrans,liquido,taxconvenio;
            
            bruto = decimal.Parse(txtsalariobruto.Text);

            if (decimal.TryParse(txtsalariobruto.Text,out decimal teste)==true)
            {
                
                if (bruto < 980) 
                {

                    imposto = bruto * 0.08m;
                    
                    if(transporte.Checked == true)
                    {

                        taxtrans = bruto * 0.06m;
                        liquido = bruto - (taxtrans + imposto);

                        MessageBox.Show("o seu liquido deu exatos: "+liquido);
                    }
                    else if (convênio.Checked == true)
                    {
                        taxconvenio = bruto - 20;
                        liquido = bruto - (taxconvenio - imposto);

                        MessageBox.Show("");

                    }

                }
                else if (bruto > 980 && bruto < 1500)
                {

                    

                }







            }
            else
            {

                MessageBox.Show("não aceitamos letras ou caracteres por favor: "+bruto);

            }








        }
    }
}