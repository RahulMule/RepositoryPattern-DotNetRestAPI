using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RepositoryPattern.Models
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        
        [MaxLength(100)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(100)]
        [Required]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public int DepartmentId { get; set; }
       
        [JsonIgnore]
        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }

    }
}
