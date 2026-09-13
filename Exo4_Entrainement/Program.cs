namespace Exo4_Entrainement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secret = new Random().Next(1, 101), essaie, tentatives = 0;

            Console.WriteLine("Essaies de trouver le nombre entre 1 et 100 auquel je pense !");

            do
            {
                essaie = int.Parse(Console.ReadLine());
                tentatives++;

                if (essaie < secret)
                {
                    Console.WriteLine("\nLe nombre à deviner est plus grand. Réessaies.");
                }
                else if (essaie > secret)
                {
                    Console.WriteLine("\nLe nombre à deviner est plus petit. Réessaies.");
                }
            } while (essaie != secret);

            Console.WriteLine($"\nBravo ! Tu as trouvé en {tentatives} tentatives.");
        }
    }
}
