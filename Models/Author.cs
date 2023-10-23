using System.ComponentModel.DataAnnotations;

namespace Silasi_Alexandru_Lab2.Models
{
    public class Author
    {
        public int AuthorID { get; set; }


        [Display(Name = "First name")]
        public string firstName { get; set; }

        [Display(Name = "Last name")]
        public string lastName { get; set; }
    }
}
