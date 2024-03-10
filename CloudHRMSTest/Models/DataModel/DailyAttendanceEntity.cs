using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHRMSTEST.Models.DataModel
{
    public class DailyAttendanceEntity:BaseEntity
    {
        public DateOnly AttendanceDate { get; set; }
        public TimeOnly InTime { get; set; }
        public TimeOnly OutTime { get; set; }
        [ForeignKey("EmployeeId")]
        public string EmployeeId { get; set; }
        public virtual EmployeeEntity Employee { get; set; }
        [ForeignKey("DepartmentId")]
        public string DepartmentId { get; set; }
        public virtual DepartmentEntity Department { get; set; }
    }
}
