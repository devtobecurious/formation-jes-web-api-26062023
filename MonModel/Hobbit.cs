namespace SdA.Games.Core.Models
{
    internal class Hobbit : Character
    {
        private Dictionary<EtatFaim, IMoyenDeDeplacement> _moyenDeDeplacements = new()
        {
            { EtatFaim.PasFaim, new Marche() },
            { EtatFaim.Faim, new Courir() },
            { EtatFaim.TresFaim, new Sauter() },
        };

        public Hobbit(int id) : base(id)
        {
        }

        private EtatFaim etatFaim = EtatFaim.PasFaim;
        public EtatFaim EtatFaim
        {
            get => etatFaim;
            set
            {
                this.etatFaim = value;
                this.MoyenDeDeplacement = this._moyenDeDeplacements[value];
            }
        }

        public IMoyenDeDeplacement? MoyenDeDeplacement { get; set; }
    }
}
