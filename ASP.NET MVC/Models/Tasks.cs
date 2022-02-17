using System.ComponentModel.DataAnnotations;

namespace ASP.NET_MVC.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [DataType(DataType.Text)]
        [Display(Name = "Pytanie")]
        public string Question { get; set; }
        [Required]
        [StringLength(512)]
        [DataType(DataType.Text)]
        [Display(Name = "Odpowiedz")]
        public string Answer { get; set; }
    }
}
