using System.Linq;

namespace intex.Models
{
    public class EFebdbContextRepository : IebdbContextRepository
    {
        private ebdbContext context {get; set;}

        public EFebdbContextRepository (ebdbContext temp)
        {
            context = temp;
        }

        public IQueryable<Burialmain> Burialmains => context.Burialmains;
    }

}