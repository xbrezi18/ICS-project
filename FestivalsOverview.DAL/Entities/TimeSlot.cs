using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivalsOverview.DAL.Entities
{
    public class TimeSlot : EntityBase
    {
        public DateTime Time { get; set; }
        public Guid StageId { get; set; }
        public StageEntity Stage { get; set; }
        public Guid BandId { get; set; }
        public BandEntity Band { get; set; }

        private sealed class TimeSlotComparer : IEqualityComparer<TimeSlot>, IEntityComparer
        {
            public bool Equals(TimeSlot? x, TimeSlot? y)
            {
                if (IEntityComparer.NullOrTypeMismatch(x, y))
                {
                    return false;
                }

                if (IEntityComparer.ReferenceEquals(x, y))
                {
                    return true;
                }

                return x.Time.Equals(y.Time) &&
                       x.StageId.Equals(y.StageId) &&
                       x.BandId.Equals(y.BandId) &&
                       x.Id.Equals(y.Id);
            }

            public int GetHashCode(TimeSlot obj)
            {
                throw new NotImplementedException();
            }
        }

        public IEqualityComparer<TimeSlot> TimeSlotEqualityComparer { get; } = new TimeSlotComparer();
    }
}
