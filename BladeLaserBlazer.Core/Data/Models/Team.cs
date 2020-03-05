using System.Collections.Generic;

namespace BladeLaserBlazer.Core.Data.Models
{
    public class Team : EntityBase
    {
        public string Location { get; set; }
        public string NickName { get; set; }

        public virtual Manager Manager { get; set; }
        public virtual ICollection<Player> Players { get; set; }

    }
}
