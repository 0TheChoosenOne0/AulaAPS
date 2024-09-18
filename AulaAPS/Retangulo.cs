

namespace AulaAPS
{
    public class Retangulo : FormaGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }

        public override string ToString()
        {
            return "Retângulo - Base: " + Base + ", Altura: " + Altura;
        }
    }
}
