using System;

namespace _28._10._2021tap1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle, TersCumle;
            Console.WriteLine("Cumle elave edin: ");
            cumle = Console.ReadLine();
            Console.WriteLine(GetWord(cumle));
        }

        static string GetWord(string cumle)
        {
            string TersCumle = String.Empty;
            for (int i = cumle.Length - 1; i >= 0; i--)
            {
                TersCumle += cumle[i];
            }
            return TersCumle;
        }
    }
}
