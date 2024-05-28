using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class StudentCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int StudentCourseId { get; set; } 
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }   
        public Courses Course { get; set; }
    }
}
