class Guerrier : Personnage
{
    private int armure;
    public Guerrier(string nom, int pointsDeVie, int armure): base(nom, pointsDeVie)
    {
        this.armure = armure;
    }
    public new void Afficher()
    {
        Console.WriteLine($"nom du perso: {nom} | Point de vie: {pointsDeVie} | armure: {armure}");
        Console.WriteLine();
    }
}