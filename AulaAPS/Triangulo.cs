using System;

namespace AulaAPS
{
    public class Triangulo : FormaGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
        public override double CalcularPerimetro()
        {
            return (Base + (2* Altura));
        }

        public override string ToString()
        {
            return "Triângulo - Base: " + Base + ", Altura: " + Altura;
        }
    }
}
