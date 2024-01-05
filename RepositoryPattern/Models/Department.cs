using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RepositoryPattern.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        
        [MaxLength(100)]
        public string DepartmentName { get; set; }
    [JsonIgnore]
        public ICollection<Employees>? Employee { get; set; }

        public static implicit operator Department(string v)
        {
            throw new NotImplementedException();
        }
    }
}
