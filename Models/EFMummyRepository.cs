using System.Linq;
using intex.Models;

namespace intex.Models
{
    public class EFMummyRepository : IMummyRepository
    {

        private MummyContext context {get; set;}

        public EFMummyRepository (MummyContext temp)
        {
            context = temp;
        }

            public IQueryable<mummy> mummies => context.burialmain;
    }
}