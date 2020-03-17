using System;

namespace DelegateApp1
{
    public delegate int Calculer(int[] elements);

    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 12, 11 };

            Calculer calculer = new Calculer(Calcul.Additionner);
            calculer += Calcul.Multiplier;
            calculer += Calcul.Soustraire;

            int result = Compute(data, Calcul.Soustraire);

            Console.WriteLine($"{result}");
            Console.ReadLine();
        }

        private static int Compute(int[] data, Calculer methodeCalcul)
        {
            return methodeCalcul(data);
        }
    }
}
