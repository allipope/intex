using System.Linq;
using intex.Models;

namespace intex.Models
{
    public class EFBurialMain_TextileRepository : IBurialMain_TextileRepository
    {

        private MummyContext context {get; set;}

        public EFBurialMain_TextileRepository (MummyContext temp)
        {
            context = temp;
        }

            public IQueryable<burialmain_textile> burialmain_textiles => context.burialmain_textile;
    }
}