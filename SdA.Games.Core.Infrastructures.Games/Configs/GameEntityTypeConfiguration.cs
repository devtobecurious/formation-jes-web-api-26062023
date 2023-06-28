using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SdA.Games.Core.Models.Games;

namespace SdA.Games.Core.Infrastructures.Games.Configs
{
    internal class GameEntityTypeConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(t => t.Id);
            builder.ToTable("Game");
        }
    }
}
