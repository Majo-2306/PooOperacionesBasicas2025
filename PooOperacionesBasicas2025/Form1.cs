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
            OperacionesBasicas op = new OperacionesBasicas();

            Suma suma = new Suma();
            Resta resta = new Resta();

            Calcular(resta);
        }

        void Calcular(OperacionesBasicas operacionesBasicas)
        {

        }
    }
}
