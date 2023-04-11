using System.ComponentModel.DataAnnotations;

namespace intex.Models
{
    public class color_textile
    {
        [Key]
        public long maincolorid { get; set; }
        public color? color { get; set; }
        public long maintextileid { get; set; }
        public textile? textile { get; set; }
    }
}
