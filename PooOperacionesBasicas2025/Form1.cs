namespace PooOperacionesBasicas2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Suma suma = new Suma();
            suma.Valor1 = 10;
            suma.Valor2 = 20;
            Calcular(suma);

            Resta resta = new Resta();
            resta.Valor1 = 10;
            resta.Valor2 = 20;
            Calcular(resta);

        }

        void Calcular(OperacionesBasicas operacionesBasicas)
        {
         MessageBox.Show(operacionesBasicas.Calcular().ToString());
        }
    }
}
