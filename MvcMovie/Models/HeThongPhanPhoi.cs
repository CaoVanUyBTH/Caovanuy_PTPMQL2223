using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class HeThongPhanPhoi
    {
        [Key]
        [ForeignKey("MaHTPP")]
        public string MaHTPP {get; set;}
        public string TenHTPP {get; set;}
    }
}