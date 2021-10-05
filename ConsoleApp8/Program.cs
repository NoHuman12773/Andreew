using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите время:");
                double t = double.Parse(Console.ReadLine());
                double S = Math.Pow(t, 3) - 3 * Math.Pow(t, 2) + 2;
                Console.WriteLine("Speed:{0:F2}", S);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
