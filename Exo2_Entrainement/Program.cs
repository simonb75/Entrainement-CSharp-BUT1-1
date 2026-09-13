using System.ComponentModel.DataAnnotations;

namespace Exo2_Entrainement
{
    internal class Program
    {
        static readonly uint CHANCES_MAX = 3;
        static readonly string MOT_DE_PASSE = "BUTInfo2026";
        static void Main(string[] args)
        {
            string verif;
            uint chances = 0;            

            while (chances < CHANCES_MAX)
            {
                Console.WriteLine("Entrez le mot de passe :");
                verif = Console.ReadLine();

                if (verif == MOT_DE_PASSE)
                {
                    Console.WriteLine("Accès autorisé !");
                    break;
                } else
                {
                    Console.WriteLine("Mot de passe incorrect\n");
                    chances++;
                }
            }
            if (chances == CHANCES_MAX)
            {
                Console.WriteLine("Compte bloqué après 3 essais !");
            }
        }
    }
}
