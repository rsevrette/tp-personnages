class Archer : Personnage
{
    private int precision;
    public Archer(string nom, int pointsDeVie, int armure): base(nom, pointsDeVie)
    {
        this.precision = armure;
    }
    public override void Afficher()
    {
        Console.WriteLine($"nom du perso: {nom} | Point de vie: {pointsDeVie} | precision: {precision}");
        Console.WriteLine();
    }
    public void Tirer()
    {
        Console.WriteLine($"L'archer tire une fleche avec une precision de {precision}");
    }
}