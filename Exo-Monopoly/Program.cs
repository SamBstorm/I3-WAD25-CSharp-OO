using Exo_Monopoly.Enums;

namespace Exo_Monopoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Test de la class De
            De.valeurMax = 20;

            int[] lances = De.Lancer(5);
            foreach (int lance in lances)
            {
                Console.WriteLine(lance);
            }*/

            /* Test de la class Joueur */

            Joueur j1 = new Joueur() { 
                Nom = "Samuel",
                Pion = Pions.Dino
            };

            Console.WriteLine($"Le premier joueur : {j1.Nom} ; va jouer avec le pion {j1.Pion}.");
            Console.WriteLine($"{j1.Nom} vous êtes en case {j1.Position}, lancer les dés!");
            Console.ReadLine();
            if (j1.Avancer())
            {
                Console.WriteLine("Super un double!");
            }
            Console.WriteLine($"Vous avancer à la case {j1.Position}");
        }
    }
}
