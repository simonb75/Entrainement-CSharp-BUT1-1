using System.Text;

namespace Exo1_Entrainement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            uint age;
            bool student;
            
            Console.WriteLine("Quel âge as-tu ?");
            age = uint.Parse(Console.ReadLine()!);

            if (age < 14)
            {
                Console.WriteLine("Tu dois payer 5€");
            } else if (age > 65)
            {
                Console.WriteLine("Tu dois payer 7€");
            } else if (age < 27)
            {
                Console.WriteLine("Es-tu un étudiant ? (o/n)");
                string reponse = Console.ReadLine()!.ToLower();
                student = (reponse == "o" || reponse == "oui");
                if (student)
                {
                    Console.WriteLine("Tu dois payer 8€");
                } else
                {
                    Console.WriteLine("Tu dois payer 10€");
                }
            }
            else
            {               
                Console.WriteLine("Tu dois payer 12€");                
            }
        }
    }
}
