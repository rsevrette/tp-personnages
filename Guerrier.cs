class Guerrier : Personnage
{
    private int armure;
    public Guerrier(string nom, int pointsDeVie, int armure): base(nom, pointsDeVie)
    {
        this.armure = armure;
    }
    public override void Afficher()
    {
        Console.WriteLine($"nom du perso: {nom} | Point de vie: {pointsDeVie} | armure: {armure}");
        Console.WriteLine();
    }
    public void Attaquer()
    {
        Console.WriteLine("Le guerrier attaque");
    }
    public override string ToString()
    {
        return $"Guerrier: {nom} | Points de vie: {pointsDeVie} | Armure: {armure}";
    }
}