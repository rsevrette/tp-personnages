namespace TP2_POO_heritage;

class Program
{
    static void Main(string[] args)
    {
        //Partie 1
        Personnage perso1 = new Personnage("perso1", 100);
        perso1.RecevoirDegats(10);
        perso1.Afficher();

        //Partie 2
        Guerrier guerrier1 = new Guerrier("guerrier1", 150, 10);
        Magicien magicien1 = new Magicien("magicien1", 80, 10);
        guerrier1.Afficher();
        magicien1.Afficher();

        //Partie 5
        guerrier1.RecevoirDegats(50);
        guerrier1.Afficher();
        guerrier1.RecevoirDegats(50, 20);
        guerrier1.Afficher();

        //Partie 6
        guerrier1.Attaquer();
        magicien1.LancerSort();

        //Partie 7 — Polymorphisme
        Console.WriteLine();
        List<Personnage> personnages = new List<Personnage>();
        personnages.Add(new Guerrier("Arthur", 100, 20));
        personnages.Add(new Magicien("Merlin", 80, 50));
        foreach (Personnage p in personnages)
        {
            if (p is Guerrier guerrier)
            {
                p.Afficher();
                guerrier.Attaquer();
            }
            else if (p is Magicien magicien)
            {
                p.Afficher();
                magicien.LancerSort();
            }

        }
        // Partie 10 — Mauvais casting
        Personnage magicien2 = new Magicien("Gandalf", 90, 60);
        if (magicien2 is Guerrier)
        {
            Guerrier castOk = (Guerrier)magicien2;
            castOk.Attaquer();
        }
        else
        {
            Console.WriteLine($"{magicien2} n'est pas un Guerrier, cast impossible.");
        }
    }
}
