using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivalsOverview.DAL.Entities
{
    public record Stage : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public ICollection<Band> BandList { get; set; } = new List<Band>();


    }
}
