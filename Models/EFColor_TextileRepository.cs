using System.Linq;
using intex.Models;

namespace intex.Models
{
    public class EFColor_TextileRepository : IColor_TextileRepository
    {

        private MummyContext context {get; set;}

        public EFColor_TextileRepository (MummyContext temp)
        {
            context = temp;
        }

            public IQueryable<color_textile> color_textiles => context.color_textile;
    }
}