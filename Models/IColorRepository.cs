using System;
using intex.Models;

namespace intex.Models
{
    public interface IColorRepository
    {
        IQueryable<color> colors {get;}
    }
}