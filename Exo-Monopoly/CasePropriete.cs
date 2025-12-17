using Exo_Monopoly.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Monopoly
{
    public class CasePropriete
    {

        public string Nom { get; private set; }
        public Couleurs Couleur { get; private set; }
        public int Prix { get; private set; }
        public bool EstHypotequee { get; private set; }
        public Joueur? Proprietaire { get; private set; }
        public CasePropriete(string nom, Couleurs couleur, int prix)
        {
            Nom = nom;
            Couleur = couleur;
            Prix = prix;
        }

        public void Acheter(Joueur acheteur)
        {
            //...Tant que Joueur n'est pas à jour, je ne peux pas faire la méthode...
        }

    }
}
