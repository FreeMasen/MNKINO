using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MNKINO.Models
{
    public class FileType : ValidationAttribute
    {
        private readonly string[] _fileExtentions = new string[]
        {
            ".avi",
            ".mkv",
            ".mov",
            ".mp4",
            ".mpg",
            ".mpeg"
        };

        private string _filePath;

        public override bool IsValid(object value)
        {
            if (value == null)
               return true;
            _filePath = value.ToString();
            return FileIsVideo();
        }

        private bool FileIsVideo()
        {
            return _fileExtentions.Contains(_filePath.Substring(_filePath.LastIndexOf(".")));
        }
    }
}
