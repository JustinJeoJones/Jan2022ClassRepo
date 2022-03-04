using System.ComponentModel.DataAnnotations;

namespace efMvcDemo.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [StringLength(50)]
        public string CourseName { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
    }
}
