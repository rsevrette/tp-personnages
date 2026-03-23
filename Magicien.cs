class Magicien : Personnage 
{
    private int puissanceMagique;
    public Magicien(string nom, int pointsDeVie, int puissanceMagique): base(nom, pointsDeVie)
    {
        this.puissanceMagique = puissanceMagique;
    }
    public new void Afficher()
    {
        Console.WriteLine($"nom du perso: {nom} | Point de vie: {pointsDeVie} | puissance magique: {puissanceMagique}");
        Console.WriteLine();
    }
}