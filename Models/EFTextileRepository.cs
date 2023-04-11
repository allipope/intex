using System.Linq;
using intex.Models;

namespace intex.Models
{
    public class EFTextileRepository : ITextileRepository
    {

        private MummyContext context {get; set;}

        public EFTextileRepository (MummyContext temp)
        {
            context = temp;
        }

            public IQueryable<textile> textiles => context.textile;
    }
}