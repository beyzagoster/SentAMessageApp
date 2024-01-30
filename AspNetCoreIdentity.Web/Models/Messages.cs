using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentity.Web.Models
{
    public class Messages
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public string UserId { get; set; }
        public DateTime SendDate { get; set; }

    }
}
