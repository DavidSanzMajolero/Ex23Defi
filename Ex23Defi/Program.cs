using System;
namespace Activitats;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Introduce la base y luego la altura del cuadrado(y rectangulo): ");
        double Numbase = Convert.ToInt16(Console.ReadLine());
        double altura = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("El area del cuadrado y del rectangulo es: " + Area(Numbase, altura, false));

        Console.WriteLine("Introduce la apotema y luego la longitud del pentagono: ");
        Numbase = Convert.ToInt16(Console.ReadLine());
        altura = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("El area del pentagono es: " + Area(Numbase, altura, true));
    }
    public static double Area(double Base, double Altura, bool isPentagon)
    {
        if (isPentagon)
        {
            return (Base * Altura) / 2;
        }
        else
        {
            return Base * Altura;
        }
    }

}
