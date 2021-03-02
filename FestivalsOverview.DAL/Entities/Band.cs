using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestivalsOverview.DAL.Enums;

namespace FestivalsOverview.DAL.Entities
{
    public record Band : EntityBase
    {
        public string Name { get; set; }
        public Genres Genre { get; set; }
        public string Photo { get; set; }
        public Countries Country { get; set; }
        public string Description { get; set; }
        public string LineUpDescription { get; set; }
        public ICollection<TimeSlot> PerformanceList { get; set; } = new List<TimeSlot>();

    }

}

