using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Models
{
    public class Courses
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CoursesId { get; set; }
        [MinLength(3)]
        [MaxLength(40)]

        public required string CoursesName { get; set; }
  
        public int TeacherId { get; set; }
        public Teachers teachers { get; set; }

        [Range(0, 25)]
        public int CoursesCapicty { get; set; }

    }
}
