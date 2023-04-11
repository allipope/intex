using System;
using intex.Models;

namespace intex.Models
{
    public interface ITextileRepository
    {
        IQueryable<textile> textiles {get;}
    }
}