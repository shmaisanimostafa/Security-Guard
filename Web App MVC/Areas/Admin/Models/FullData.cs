using Security_Guard.Models;
using File = Security_Guard.Models.File;

namespace Security_Guard.Areas.Admin.Models
{
    public class FullData
    {
        public List<UserViewModel> UserViews { get; set; }
        public List<Link> Links { get; set; }
        public List<File> Files { get; set; }
    }
}
