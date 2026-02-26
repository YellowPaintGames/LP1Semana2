using System;
using System.Globalization;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture=CultureInfo.InvariantCulture;
            Console.Write("Temperature: ");
            float T=Convert.ToSingle(Console.ReadLine());
            Console.Write("Unit (C/F): ");
            string temp=Console.ReadLine();
            switch (temp)
            {
                case "C":
                Console.WriteLine($"{T:f2} C = {T*1.8+32:f2}F");
                Console.WriteLine($"Absolute Value: {Math.Abs(T*1.8+32):f2}");
                break;
                case "F":
                Console.WriteLine($"{T:f2} F = {(T-32)/1.8:f2}C");
                Console.WriteLine($"Absolute Value: {Math.Abs((T-32)/1.8):f2}");
                break;
                default:
                Console.WriteLine("Invalid Unit");
                break;
            }
        }
    }
}
