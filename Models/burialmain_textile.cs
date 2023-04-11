using System.ComponentModel.DataAnnotations;

namespace intex.Models
{
    public class burialmain_textile
    {
        [Key]
        public long mainburialmainid { get; set; }
        public mummy? mummy { get; set; }
        public long maintextileid { get; set; }
        public textile? textile { get; set; }
    }
}
