namespace BladeLaserBlazer.Core.Data.Models
{
    public class Manager : EntityBase
    {
        public int? TeamId { get; set; }
        public string Name { get; set; }
        public virtual Team Team { get; set; }
    }
}
