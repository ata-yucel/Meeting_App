using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad alani zorunlu")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Telefon numaranizi girin")]
        public string? Phone { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Email alani hatasiz girilmeli")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Katilim durumunuzu secin")]
        public bool? WillAttend { get; set; }
    }
}