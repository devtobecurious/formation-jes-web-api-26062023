namespace SdA.Games.Core.Models
{
    internal interface IMoyenDeDeplacement
    {
        void SeDeplacer();

        void Arreter()
        {
            Console.WriteLine("Comportement par defaut");
        }
    }
}
