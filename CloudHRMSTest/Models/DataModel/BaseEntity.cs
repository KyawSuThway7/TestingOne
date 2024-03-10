using CloudHRMSTEST.Utilities;
using System.ComponentModel.DataAnnotations;

namespace CloudHRMSTEST.Models.DataModel
{
    public class BaseEntity
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? ModifiedAt { get; set; }
        public string IpAddress { get; set; } = NetworkHelper.GetLocalIPAddress();

    }
}
