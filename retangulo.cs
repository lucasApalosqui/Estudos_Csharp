using System;

namespace Primeiro
{
    internal class retangulo
    {
        public double largura;
        public double altura;

        public double Area() {
            return largura * altura;
        }

        public double Perimetro()
        {
            return (largura + altura) + (altura + largura);
        }

        public double Diagonal()
        {
            double d;
            d = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(largura, 2));
            return d;
        }
    }
}
