using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateApp1
{
    public static class Calcul
    {
        public static int Additionner(int[] elements)
        {
            int resultat = 0;

            foreach(int element in elements)
            {
                resultat += element;
            }

            return resultat;
        }
        public static int Multiplier(int[] elements)
        {
            int resultat = 1;

            foreach(int element in elements)
            {
                resultat = resultat * element;
            }

            return resultat;
        }
        public static int Soustraire(int[] elements)
        {
            int resultat = elements[0];

            for(int key = 1; key < elements.Length; key++)
            {
                resultat -= elements[key];
            }

            return resultat;
        }
        
    }
}
