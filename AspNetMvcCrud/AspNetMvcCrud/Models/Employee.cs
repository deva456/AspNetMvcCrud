using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcCrud.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Salary { get; set; }
        public DateTime DateOfBirth { get; set;}
        
        // Foreign key
        [Display(Name = "Department")]
        public int DepartmentName { get; set; }

        [ForeignKey("DepartmentName")]
        public virtual Department Departments { get; set; }
    }
}
