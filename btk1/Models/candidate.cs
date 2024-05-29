using System.ComponentModel.DataAnnotations;

namespace btk1
{
    public class candidate
    {
        [Required (ErrorMessage ="e-mail is required.")]
        public string email { get; set; } = string.Empty;

        [Required(ErrorMessage = "name is required.")]
        public string name { get; set; } = string.Empty;

        
        public string lastname { get; set; } = string.Empty;
        
        public int age { get; set; }
        public string selectedcourse { get; set; } = string.Empty;
        public DateTime applyat { get; set; }

        public candidate()
        {
            applyat=DateTime.Now;
        }
    }
}