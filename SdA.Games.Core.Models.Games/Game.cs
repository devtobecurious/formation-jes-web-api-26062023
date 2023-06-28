using System.Diagnostics.CodeAnalysis;

namespace SdA.Games.Core.Models.Games;

public record GameSetting(int NbPointsAGagner);

//[Table("SD001")]
public class Game
{
    public int Id { get; set; }

    public bool IsSuccess { get; set; }

    //[MaybeNull]
    private string? titre;
    public string? Titre
    {
        get => titre;
        set => titre = value ?? throw new ArgumentNullException("value");
    }


    [return: NotNullIfNotNull(nameof(toto))]
    public string? GetSate(string? toto)
    {
        return null;
    }
}
