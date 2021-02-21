using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivalsOverview.DAL.Entities
{
    public record Stage : EntityBase
    {
        public string? StageName { get; init; }
        public string? StageDescription { get; init; }
    }
}
