using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Customer
    {
        [Key]
        public string CustomerID { get; set;}
        public string CustomerName { get; set;}
    }
}