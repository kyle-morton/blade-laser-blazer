using System.ComponentModel.DataAnnotations;

namespace BladeLaserBlazer.Core.Data.Models
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
