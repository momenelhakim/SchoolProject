using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class Teachers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }
        [MinLength(6)] 
        
        public required string  TeacherName { get; set; }    
       [ Range(20,50)]
        public int TeacherAge { get; set; }
        
    }
}
