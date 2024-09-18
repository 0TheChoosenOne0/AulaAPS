using System;

namespace AulaAPS
{
    public class Circunferencia : FormaGeometrica
    {
        public double Raio { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        public override string ToString()
        {
            return "Circunferência - Raio: " + Raio;
        }
    }

}
