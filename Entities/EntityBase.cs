using System;

namespace FestivalsOverview.DAL.Entities
{
    public abstract record EntityBase
    {
        public Guid Id { get; set; }
    }
}