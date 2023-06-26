namespace SdA.Games.Core.Models;
internal class Marche : IMoyenDeDeplacement
{
    private readonly Action<string> afficher;

    public Marche(Action<string> afficher)
    {
        this.afficher = afficher;
    }

    public void SeDeplacer()
    {
        this.afficher?.Invoke("Je marche");
    }
}

