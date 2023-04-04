using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Basicos_de_CSharp___Esfera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi, raio, volume;
            pi = 3.14159;
            raio = double.Parse(Console.ReadLine());
            volume = pi * (4.0 / 3) * Math.Pow(raio, 3);

            Console.WriteLine($"VOLUME = {volume:F3}");

            Console.ReadKey();
        }
    }
}
