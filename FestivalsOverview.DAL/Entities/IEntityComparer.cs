using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FestivalsOverview.DAL.Entities
{
    interface IEntityComparer
    {
        public static bool NullOrTypeMismatch(object? x, object? y)
        {
           
            if (ReferenceEquals(x, null) || (ReferenceEquals(y,null)))
            {
                return true;
            }

            return x?.GetType() != y?.GetType();

        }

        public static bool ReferenceEquals(object? x, object? y)
        {
            return x == y;
        }
    }
}
