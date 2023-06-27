namespace SdA.Games.Core.Models
{
    public class Hobbit : Character
    {

        private readonly Dictionary<EtatFaim, IMoyenDeDeplacement>? _moyenDeDeplacements;

        public Hobbit(int id, Action<string> afficher) : base(id)
        {
            this._moyenDeDeplacements = new()
            {
                { EtatFaim.PasFaim, new Marche(afficher) },
                { EtatFaim.Faim, new Courir() },
                { EtatFaim.TresFaim, new Sauter() },
            };
        }

        public Hobbit(Action<string> afficher) : this(0, afficher)
        {

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
