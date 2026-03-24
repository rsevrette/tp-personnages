class Magicien : Personnage 
{
    private int puissanceMagique;
    public Magicien(string nom, int pointsDeVie, int puissanceMagique): base(nom, pointsDeVie)
    {
        this.puissanceMagique = puissanceMagique;
    }
    public override void Afficher()
    {
        Console.WriteLine($"nom du perso: {nom} | Point de vie: {pointsDeVie} | puissance magique: {puissanceMagique}");
        Console.WriteLine();
    }
    public void LancerSort()
    {
        Console.WriteLine("Le magicien lance un sort");
    }
    public override string ToString()
    {
        return $"Magicien: {nom} | Points de vie: {pointsDeVie} | Puissance magique: {puissanceMagique}";
    }
}