using System.ComponentModel.DataAnnotations;

namespace efMvcDemo.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [StringLength(40)]
        public string FirstName { get; set; }
        [StringLength(40)]
        public string LastName { get; set; }
    }
}
