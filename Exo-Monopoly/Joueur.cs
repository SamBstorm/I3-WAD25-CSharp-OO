using Exo_Monopoly.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Monopoly
{
    public class Joueur
    {
        public string Nom { get; set; }
        public Pions Pion { get; set; }        
        public int Position { get; private set; }
        public int Solde { get; private set; }

        public bool Avancer()
        {
            //De.valeurMin = 1;
            //De.valeurMax = 6;
            int[] lances = De.Lancer(2);
            for (int i = 0; i < lances.Length; i++)
            {
                Position += lances[i];
            }
            return lances[0] == lances[1];
        }
    }
}
