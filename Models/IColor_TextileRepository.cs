using System;
using intex.Models;

namespace intex.Models
{
    public interface IColor_TextileRepository
    {
        IQueryable<color_textile> color_textiles {get;}
    }
}