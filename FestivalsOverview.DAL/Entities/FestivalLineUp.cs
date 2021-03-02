using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivalsOverview.DAL.Entities
{
    public record FestivalLineUp : EntityBase
    {
        public ICollection<TimeSlot> LineUp { get; set; } = new List<TimeSlot>();
    }
}
