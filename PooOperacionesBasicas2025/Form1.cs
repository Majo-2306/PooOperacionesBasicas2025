namespace PooOperacionesBasicas2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Calcular(OperacionesBasicas operacionesBasicas)
        {
            MessageBox.Show(operacionesBasicas.Calcular().ToString());
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Suma suma = new Suma();
            suma.Valor1 = double.Parse(TxtValor1.Text);
            suma.Valor2 = double.Parse(TxtValor2.Text);
            Calcular(suma);
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            Resta resta = new Resta();
            resta.Valor1 = double.Parse(TxtValor1.Text);
            resta.Valor2 = double.Parse(TxtValor2.Text);
            Calcular(resta);

        }

        private void BtnMultiplicacion_Click(object sender, EventArgs e)
        {
            Multiplicacion multiplicacion = new Multiplicacion();
            multiplicacion.Valor1 = double.Parse(TxtValor1.Text);
            multiplicacion.Valor2 = double.Parse(TxtValor2.Text);
            Calcular(multiplicacion);
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            Division division = new Division();
            division.Valor1 = double.Parse(TxtValor1.Text);
            division.Valor2 = double.Parse(TxtValor2.Text);
            Calcular(division);

        }
    }
}
