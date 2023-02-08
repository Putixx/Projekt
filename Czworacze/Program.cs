using System;
using System.Text;

namespace Czworacze
{
    class Program
    {
        public static bool[] Przesiej(long n)
        {
            bool[] tab = new bool[n];

            for (int i = 2; i * i < n; i++)
            {                           
                if (!tab[i])
                {
                    for (int j = i * i; j < n; j += i)
                    {
                        tab[j] = true;
                    }
                }      
            }

            return tab;
        }

        public static void Main(string[] args)
        {
            Console.Write("Podaj zakres górny: ");

            bool[] result = Przesiej(Convert.ToInt64(Console.ReadLine()));
            StringBuilder output = new StringBuilder();
            output.AppendLine("Liczby czworacze:");

            for (int i = 2; i < result.Length - 8; i++)
            {
                if (!result[i] && !result[i + 2] && !result[i + 6] && !result[i + 8])
                {
                    output.AppendLine(i + ", " + (i + 2) + ", " + (i + 6) + ", " + (i + 8));
                }
            }

            Console.WriteLine("\n" + output);
        }

    }
}
