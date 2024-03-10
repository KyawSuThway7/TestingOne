using System.ComponentModel.DataAnnotations;

namespace CloudHRMSTEST.Models.ViewModel
{
    public class DepartmentViewModel
    {
        public string  Id { get; set; }
        
        public string Code { get; set; }

        public string Name { get; set; }
        public string? ExtensionPhone { get; set; }
        public int TotalEmployeeCount { get; set; }
    }
}
