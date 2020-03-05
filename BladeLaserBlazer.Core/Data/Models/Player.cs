using System;
using System.Collections.Generic;
using System.Text;

namespace BladeLaserBlazer.Core.Data.Models
{
    public class Player : EntityBase
    {
        public int? TeamId { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public virtual Team Team { get; set; }
    }
}
