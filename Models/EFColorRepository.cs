using System.Linq;
using intex.Models;

namespace intex.Models
{
    public class EFColorRepository : IColorRepository
    {

        private MummyContext context {get; set;}

        public EFColorRepository (MummyContext temp)
        {
            context = temp;
        }

            public IQueryable<color> colors => context.color;
    }
}