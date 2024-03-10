using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHRMSTEST.Models.DataModel
{
    [Table("Department")]
    public class DepartmentEntity:BaseEntity
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string? ExtensionPhone { get; set; }
        //Many to One
       //public virtual IList<EmployeeEntity> Employees { get; set; }
    }
}
