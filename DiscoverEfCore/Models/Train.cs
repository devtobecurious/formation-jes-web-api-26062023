using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiscoverEfCore.Models
{
    [Table("Train")]
    public class Train
    {
        [Key]
        public int Id { get; set; }
    }
}
