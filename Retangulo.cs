using System;
using System.Globalization;
namespace CalcularRetangulo
{
    internal class Retangulo
    {
        public Double Largura;
        public Double Altura;

        public Double Area()
        {

            double a = Largura * Altura;
            return a ;
        }

        public double Perimeitro()
        {
            return 2*(Largura+Altura);

        }

        public double Diagnal() 
        {
            double d = Math.Sqrt(Math.Pow(Largura, 2)+ Math.Pow(Altura,2)); 
            return d;
        
        }
    }
}
