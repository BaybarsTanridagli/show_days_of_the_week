using System;

namespace show_days_of_the_week
{
    class Program
    {
        static void Main(string[]args)
        {
            string[] hafta = new string[7];

            hafta[0] = "Pazartesi";
            hafta[1] = "Salı";
            hafta[2] = "Çarşamba";
            hafta[3] = "Perşembe";
            hafta[4] = "Cuma";
            hafta[5] = "Cumartesi";
            hafta[6] = "Pazar";

            foreach (var day in hafta)
            {
                Console.WriteLine(day);
            }

            Console.ReadLine();

        }
    }
}
