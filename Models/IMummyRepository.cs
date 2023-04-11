using System;
using intex.Models;

namespace intex.Models
{
    public interface IMummyRepository
    {
        IQueryable<mummy> mummies {get;}
    }
}