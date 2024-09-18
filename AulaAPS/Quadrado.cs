namespace AulaAPS
{
    public class Quadrado : FormaGeometrica
    {
        public double Lado { get; set; }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }

        public override string ToString()
        {
            return "Quadrado - Lado: " + Lado;
        }
    }
}
 