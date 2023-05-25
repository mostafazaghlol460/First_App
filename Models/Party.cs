using System.ComponentModel.DataAnnotations;

namespace First_App.Models
{
    public class Party
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        public string Email { get; set; }
        public string Message_con { get; set; }
        public bool attend { get; set; }

    }
}
