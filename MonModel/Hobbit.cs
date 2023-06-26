namespace SdA.Games.Core.Models
{
    public class Hobbit : Character
    {
        private Dictionary<EtatFaim, IMoyenDeDeplacement> _moyenDeDeplacements;

        public Hobbit(int id) : base(id)
        {
        }

        public Hobbit(Action<string> afficher) : base(0)
        {
            this._moyenDeDeplacements = new()
            {
                { EtatFaim.PasFaim, new Marche(afficher) },
                { EtatFaim.Faim, new Courir() },
                { EtatFaim.TresFaim, new Sauter() },
            };
        }

        private EtatFaim etatFaim = EtatFaim.PasFaim;
        public EtatFaim EtatFaim
        {
            get => etatFaim;
            private set
            {
                this.etatFaim = value;
                this.MoyenDeDeplacement = this._moyenDeDeplacements[value];
            }
        }

        public IMoyenDeDeplacement? MoyenDeDeplacement { get; set; }
    }
}
