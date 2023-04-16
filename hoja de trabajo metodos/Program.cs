// See https://aka.ms/new-console-template for more information

using System;
using System.Security.Cryptography.X509Certificates;

public class figura
{
    public double calculartriangulo(double bs, double alt)
    {
        return (bs * alt) / 2;
    }
    public double calcularcuadrado(double lado)
    {
        return (lado * lado);
    }
    public double calcularcirculo(double rad)
    {
        return Math.Pow(rad,2);
    }
    public static void Main()
    {
        Console.WriteLine("Ingrese el ejercicio que desea ejecutar");
        Console.WriteLine("1. Figuras");
        Console.WriteLine("2. Producto");
        Console.WriteLine("3. Divisores");
        int ej = Convert.ToInt16(Console.ReadLine());
        Console.Clear();
        switch (ej)
        {
            case 1:
                figura f = new figura();
                Console.WriteLine("Ingrese la figura");
                Console.WriteLine("1. triangulo");
                Console.WriteLine("2. circulo");
                Console.WriteLine("3. cuadrado");
                int fig = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                switch (fig)
                {
                    case 1:
                        Console.WriteLine("Ingrese la base del triangulo");
                        double bs = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Ingrese la altura del triangulo");
                        double alt = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("El area del triangulo es " + f.calculartriangulo(bs, alt));

                        break;

                    case 2:
                        Console.WriteLine("Ingrese el radio del circulo");
                        double rad = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("El area del circulo es " + f.calcularcirculo(rad));
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el lado del cuadrado");
                        double lado = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("El area del cuadrado es " + f.calcularcuadrado(lado));
                        break;
                }
                break;

            case 2:
                Console.WriteLine("Ingrese el precio base del producto");
                double pre = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Ingrese el consumo energetico");
                Char con = Convert.ToChar(Console.ReadLine());
                while (con != 'A' && con != 'B' && con != 'C' & con != 'D')
                {
                    Console.WriteLine("Ingrese un consumo valido");
                    con = Convert.ToChar(Console.ReadLine());
                }
                Console.Clear();
                Console.WriteLine("Ingrese el color");
                String col = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Ingrese el peso en kg");
                double pe = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                double preF = 0;
                if (con == 'A')
                {
                    preF = pre + 100;
                }
                else if (con == 'B')
                {
                    preF = pre + 80;
                }
                else if (con == 'C')
                {
                    preF = pre + 60;
                }
                else if (con == 'D')
                {
                    preF = pre + 50;
                }

                if (pe > 20 && pe < 40)
                {
                    preF = preF + (pre * 0.05);
                }
                else if (pe >= 40)
                {
                    preF = preF + (pre * 0.1);
                }

                Console.WriteLine("El precio final es "+preF);
             break;

            case 3:
                Console.WriteLine("Ingrese un numero");
                int n = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                int div = 0;
                Console.WriteLine("Los divisores de "+n+" son:");
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                break;
        }
        
    }

}
