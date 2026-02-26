using System;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("A temperatura:");
            float T=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Escreva C para Celsius ou F para Fahrenheit");
            string temp=Console.ReadLine();
            switch (temp)
            {
                case "C":
                Console.WriteLine($"A temperatura Celsius {T} em Fahrenheit é {T*1.8+32:f2}");
                break;
                case "F":
                Console.WriteLine($"A temperatura Fahrenheit {T} em Celsius é {(T-32)/1.8:f2}");
                break;
            }
        }
    }
}
