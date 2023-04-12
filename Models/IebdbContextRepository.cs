using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intex.Models
{
    public interface IebdbContextRepository
    {
        IQueryable<Burialmain> Burialmains {get;}
    }
}