using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentity.Web.Models
{
    public class SiteUserGroup
    {
        [Key]
        public int Id { get; set; }
        public string GroupName { get; set; }
    }
}
