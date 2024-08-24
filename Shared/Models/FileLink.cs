using Shared.Models;
using File = Shared.Models.File;

namespace Shared.Models { 
    public class FileLink
{
    public List<Link> links { get; set; }
    public List<File> files { get; set; }
}

}