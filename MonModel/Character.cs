namespace SdA.Games.Core.Models
{
    public abstract class Character
    {
        public Character(int id) : this(id, string.Empty)
        {
            this.Id = id;
        }

        public Character(int id, string name)
        {
            //this.Life = new()
            //{
            //    Point = 100
            //};
            this.Life = new(100);
        }

        #region Properties
        public int Id { get; private init; } = 0;

        public string? Name { get; set; }

        public Life Life { get; private set; }

        public Weapon Weapon { get; set; } = new();
        #endregion
    }
}
