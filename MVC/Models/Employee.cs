using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeID { get; set;}  
        public string EmployeeName { get; set;}
        public string EmployeeDiachi { get; set;}
    }
}