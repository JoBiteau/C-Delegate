using System;

namespace DelegateApp1
{
    public delegate int Calculer(int[] elements);

    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 12, 12 };

            Calculer calculer = new Calculer(Calcul.Additionner);
            calculer += Calcul.Multiplier;

            int result = Compute(data, Calcul.Additionner);

            Console.WriteLine($"{result}");
            Console.ReadLine();
        }

        private static int Compute(int[] data, Calculer methodeCalcul)
        {
            return methodeCalcul(data);
        }
    }
}
