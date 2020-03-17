using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateApp1
{
    public delegate void ResultatEventHandler(object sender, EventArgs e);
    public class Resultats
    {
        private List<int> resultats;

        public event ResultatEventHandler onResultatChanged;

        public Resultats()
        {
            resultats = new List<int>();
        }


        public void AjouterUnResultat(int resultat)
        {

            this.resultats.Add(resultat);

            if(onResultatChanged != null)
            {
                onResultatChanged(this, EventArgs.Empty);

            }

        }

      
    }

   
}
