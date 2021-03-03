using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivalsOverview.DAL.Entities
{
    public class StageEntity : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        
        // Podle me je to tu zbytecne, pokud chceme zjistit jaka kapela hraje na jake stagi a v kolik, zjistime to z tabulky timeslot
        //public ICollection<BandEntity> BandList { get; set; } = new List<BandEntity>();


        public StageEntity(string name, string description, string photo)
        {
            this.Name = name;
            this.Description = description;
            this.Photo = photo;
        }

        private sealed class StageEntityComparer : IEqualityComparer<StageEntity>, IEntityComparer
        {
            // TODO
            public bool Equals(StageEntity? x, StageEntity? y)
            {
                if (IEntityComparer.NullOrTypeMismatch(x, y))
                {
                    return false;
                }

                if (IEntityComparer.ReferenceEquals(x, y))
                {
                    return true;
                }

                return x.Name.Equals(y.Name) &&
                       x.Description.Equals(y.Description) &&
                       x.Photo.Equals(y.Photo) &&
                       x.Id.Equals(y.Id);
            }

            //TODO
            public int GetHashCode(StageEntity obj)
            {
                throw new NotImplementedException();
            }
        }
        
        public static IEqualityComparer<StageEntity> StageEqualityComparer { get; } = new StageEntityComparer();
    }

}
