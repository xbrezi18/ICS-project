using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivalsOverview.DAL.Entities
{
    public record Band : EntityBase
    {
        public string? BandName { get; init; }
        public string? BandDescription { get; init; }
        public string? LineUpDescription { get; init; }
    }
}
