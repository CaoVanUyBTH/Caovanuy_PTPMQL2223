using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Student
    {
        [Key]
        public string StudentID { get; set;}
        public string StudentName { get; set;}
    }
}