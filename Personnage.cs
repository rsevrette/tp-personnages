using System.Drawing;

class Personnage
{
    protected string nom;
    protected int pointsDeVie;
    public string Getnom()
    {
        return nom;
    }
    public void Setnom(string Nom)
    {
        nom = Nom;
    }
    public int GetPointDeVie()
    {
        return pointsDeVie;
    }
    public void SetPointDeVie(int PointsDeVie)
    {
        pointsDeVie = PointsDeVie;
    }

    
    public Personnage(string nom, int pointsDeVie)
    {
        this.nom = nom;
        this.pointsDeVie = pointsDeVie;
    }
    public virtual void Afficher()
    {
        Console.WriteLine($"nom du perso: {nom} | Point de vie: {pointsDeVie}");
        Console.WriteLine();
    }
    public void RecevoirDegats(int degats)
    {
        pointsDeVie -= degats;
    }
    public void RecevoirDegats(int degats, int reduction)
    {
        int degats_reduc = degats - reduction;
        pointsDeVie -= degats_reduc;
    }
}