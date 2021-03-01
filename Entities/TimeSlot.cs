using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivalsOverview.DAL.Entities
{
    public record TimeSlot : EntityBase
    {
        public DateTime Time { get; set; }
        public Stage Stage { get; set; }
        public Band Band { get; set; }

    }
}
