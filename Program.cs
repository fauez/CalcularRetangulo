using System.Globalization;
namespace CalcularRetangulo
{
    class  Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a lagura e altura do retangulo");
            Console.Write("Largura: ");
             retangulo.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
             retangulo.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
           
            
            Console.WriteLine("Area: " + retangulo.Area().ToString("f2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: "+ retangulo.Perimeitro().ToString("f2",CultureInfo.InvariantCulture));
            Console.WriteLine("Diagnal: " + retangulo.Diagnal().ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
