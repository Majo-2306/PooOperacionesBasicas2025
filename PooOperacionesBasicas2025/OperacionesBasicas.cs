namespace PooOperacionesBasicas2025
{
    abstract class OperacionesBasicas
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }

        public abstract double Calcular();
        public double Hola() 
        {
            Valor1 = Calcular();
            return Valor2;
        }
    }
}
