using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class Student {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int StudentId { get; set; }
        [MaxLength(40)]
        [MinLength(6)]
        public string StudentName { get; set; }    
        public bool IsActive { get; set; }
        [Range(6,20)]
        
        public int StudentAge{ get; set; }  
    }
}
