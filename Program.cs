using System;

namespace DelegateApp1
{
    public delegate int Calculer(int[] elements);

    class Program
    {
        static void Main(string[] args)
        {
            Resultats resultats = new Resultats();
            //resultats.onResultatChanged += Resultats_onResultatChanged;

            int[] data = new int[] { 12, 5 };

            Calculer calculer = new Calculer(Calcul.Additionner);
            calculer += Calcul.Multiplier;
            calculer += Calcul.Soustraire;

            resultats.AjouterUnResultat(Compute(data, data => { return data[0] - data[1]; }));
            resultats.AjouterUnResultat(Compute(data, Calcul.Additionner));
            resultats.AjouterUnResultat(Compute(data, Calcul.Multiplier));

            Console.WriteLine($"{resultats.ToString()}");
            Console.ReadLine();
        }

        private static void Resultats_onResultatChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Un nouveau résultat à été ajouté");
        }

        private static int Compute(int[] data, Calculer methodeCalcul)
        {
            return methodeCalcul(data);
        }

    }
}
