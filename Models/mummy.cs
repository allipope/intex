using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace intex.Models
{
    public class mummy
    {
        [Key]
        [Required]
        public long id { get; set; }
        public  string? depth { get; set; }
        public string? sex { get; set; }
        public string? haircolor { get; set; }
        public string? headdirection { get; set; }
        public string? squarenorthsouth { get; set; }
        public string? northsouth { get; set; }
        public string? squareeastwest { get; set; }
        public string? eastwest { get; set; }
        public string? area { get; set; }
        public string? burialnumber { get; set;}
        public string? text { get; set; }
        public string? wrapping { get; set; }
        public string? length { get; set; }
        public string? ageatdeath { get; set; }
    }
}
