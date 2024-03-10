namespace CloudHRMSTEST.Models.ViewModel
{
    public class DailyAttendanceViewModel
    {
        public DateOnly AttendanceDate { get; set; }
        public TimeOnly InTime { get; set; }
        public TimeOnly OutTime { get; set; }
        public string EmployeeId { get; set; }
        public string DepartmentId { get; set; }
    }
}
