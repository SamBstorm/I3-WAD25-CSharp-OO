using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Monopoly
{
    public static class De
    {
        public static int valeurMin = 1;
        public static int valeurMax = 6;
        public static Random rng = new Random();

        public static int[] Lancer(int nbDes)
        {
            int[] resultats = new int[nbDes];
            for (int i = 0; i < nbDes; i++)
            {
                resultats[i] = rng.Next(valeurMin, valeurMax + 1);
            }
            return resultats;
        }
    }
}
