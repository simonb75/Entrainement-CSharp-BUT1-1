namespace Exo3_Entrainement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint nbEtu, etudiantsAdmis = 0;
            double moyenne, somme = 0;

            Console.WriteLine("Combien d'étudiants y a-t-il dans la promo ?");
            nbEtu = uint.Parse(Console.ReadLine());

            double[] notes = new double[nbEtu];

            for (int i = 0;  i < nbEtu; i++)
            {
                Console.WriteLine($"Entrez la note de l'étudiant {i + 1} :");
                notes[i] = double.Parse(Console.ReadLine()!);
            }

            double noteHaute = notes[0], noteBasse = notes[0];

            foreach (double note in notes)
            {
                somme += note;

                if (note > noteHaute)
                {
                    noteHaute = note;
                }

                if (note < noteBasse)
                {
                    noteBasse = note;
                }

                if (note >= 10)
                {
                    etudiantsAdmis++;
                }
            }

            moyenne = somme / notes.Length;                               

            Console.WriteLine($"\nLa moyenne des étudiants est de : {moyenne}.\nLa note la plus haute est : {noteHaute}.\nLa note la plus basse est : {noteBasse}.\n" +
                $"Le nombre d'étudiants admis est de : {etudiantsAdmis}.");
        }
    }
}
