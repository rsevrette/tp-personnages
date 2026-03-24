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

        // Partie 11 — ToString()
        Personnage perso2 = new Personnage("Inconnu", 50);
        Guerrier guerrier2 = new Guerrier("Arthur", 100, 20);
        Magicien magicien3 = new Magicien("Merlin", 80, 50);

        Console.WriteLine(perso2);
        Console.WriteLine(guerrier2);
        Console.WriteLine(magicien3);

        // Partie 12
        Archer archer1 = new Archer("Archer1", 95, 20);
        archer1.Tirer();
        archer1.Afficher();
    }
}


/*
1. La surcharge = même nom, paramètres différents. La redéfinition = remplacer une méthode héritée avec override.
2. Pour que C# appelle la bonne version de la méthode selon le type réel de l'objet.
3. Manipuler des objets différents de la même façon sans se répéter.
4. Parce qu'on essaie de convertir un objet en un type qu'il n'est pas.
5. Pour éviter que le programme crash.
*/
