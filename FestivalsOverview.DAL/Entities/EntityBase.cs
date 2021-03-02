using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivalsOverview.DAL.Entities
{
    public abstract record EntityBase
    {
        public Guid Id { get; init; }
    }
}