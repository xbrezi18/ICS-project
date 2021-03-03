using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FestivalsOverview.DAL.Enums;

namespace FestivalsOverview.DAL.Entities
{
    public class BandEntity : EntityBase
    {
        public string Name { get; set; }
        public Genres Genre { get; set; }
        public string? Photo { get; set; }
        public Countries Country { get; set; }
        public string? Description { get; set; }
        public string? LineUpDescription { get; set; }

        // problém při porovnání 
        //Zase je to zbytecne, informaci o tom, kde a kdy kapela hraje lze ziskat z tabulky timeslot
        //public ICollection<TimeSlot> PerformanceList { get; set; } = new List<TimeSlot>();


        public BandEntity(string name, Genres genre, Countries country, string description, string photo )
        {
            this.Name = name;
            this.Genre = genre;
            this.Country = country;
            this.Description = description;
            this.Photo = photo;
        }

        public static IEqualityComparer<BandEntity> Comparer { get; } = new BandEntityEqualityComparer();

        public static IEqualityComparer<BandEntity> CountryGenreNameIdComparer { get; } = new BandEntityCountryGenreNameIdComparer();

        private sealed class  BandEntityEqualityComparer : IEqualityComparer<BandEntity>, IEntityComparer
        {
            //TODO
            public bool Equals(BandEntity? x, BandEntity? y)
            {
                if (IEntityComparer.NullOrTypeMismatch(x,y))
                {
                    return false;
                }

                if (IEntityComparer.ReferenceEquals(x, y))
                {
                    return true;
                }

                return x.Name.Equals(y.Name) &&
                       x.Genre.Equals(y.Genre) &&
                       x.Photo.Equals(y.Photo) &&
                       x.Country.Equals(y.Country) &&
                       x.Description.Equals(y.Description) &&
                       x.LineUpDescription.Equals(y.LineUpDescription) &&
                      // x.PerformanceList.OrderBy(perf => perf.Id).SequenceEqual(y.PerformanceList.OrderBy(perf => perf.Id), TimeSlot.) &&
                       x.Id.Equals(y.Id);
            }

            //TODO
            public int GetHashCode(BandEntity obj)
            {
                throw new NotImplementedException();
            }
        }

        private sealed class BandEntityCountryGenreNameIdComparer : IEqualityComparer<BandEntity>, IEntityComparer
        {
            public bool Equals(BandEntity? x, BandEntity? y)
            {
                if (IEntityComparer.NullOrTypeMismatch(x, y))
                {
                    return false;
                }

                if (IEntityComparer.ReferenceEquals(x, y))
                {
                    return true;
                }

                return x.Country.Equals(y.Country) &&
                       x.Genre.Equals(y.Genre) &&
                       x.Name.Equals(y.Name) &&
                       x.Id.Equals(y.Id);
            }

            public int GetHashCode(BandEntity obj)
            {
                throw new NotImplementedException();
            }
        }


    }

}

