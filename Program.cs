namespace TP2_POO_heritage;

class Program
{
    static void Main(string[] args)
    {
        Personnage perso1 = new Personnage("perso1", 100);
        perso1.RecevoirDegats(10);
        perso1.Afficher();
    }
}
