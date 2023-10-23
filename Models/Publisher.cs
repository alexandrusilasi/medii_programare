using System.ComponentModel.DataAnnotations;

namespace Silasi_Alexandru_Lab2.Models
{
    public class Publisher
    {
        public int id { get; set; }


        [Display(Name = "Publisher name")]
        public string name { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
