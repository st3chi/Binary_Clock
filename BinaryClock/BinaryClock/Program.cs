using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryClock
{
    internal class Program
    {
        static string ConvertToBinary(int val)
        {
            return Convert.ToString(val, 2).PadLeft(4, '0');
        }

        static void ConvertTimeToBinary(string timpCurent)
        {
            try
            {
                string[] timp = timpCurent.Split(':');
                int ore = int.Parse(timp[0]);
                int minute = int.Parse(timp[1]);
                int secunde = int.Parse(timp[2]);

                string oraB = ConvertToBinary(ore);
                string minutB = ConvertToBinary(minute);
                string secundaB = ConvertToBinary(secunde);

                Console.WriteLine($"Ceasul binar: {oraB}:{minutB}:{secundaB}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Formatul orei introdus nu este valid.");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Introduceți ora curentă în formatul HH:MM:SS: ");
            string timpCurent = Console.ReadLine();

            ConvertTimeToBinary(timpCurent);
        }
    }
}

