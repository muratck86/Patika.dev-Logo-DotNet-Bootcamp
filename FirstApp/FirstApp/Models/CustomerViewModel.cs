using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
    public class CustomerViewModel
    {
        public CustomerViewModel()
        { }
        public int Id { get; set; }

        [Required(ErrorMessage = "İsim girilmesi zorunludur.")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Soyisim girilmesi zorunludur.")]
        [MaxLength(10)]
        public string LastName { get; set; } = string.Empty ;
        [Required(ErrorMessage = "Adres girilmesi zorunludur.")]

        [StringLength(300, ErrorMessage ="En az 5 karakter olmalıdır.")]
        [MinLength(5)]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; } = string.Empty;
        [Required(ErrorMessage = "Yaş alanı zorunludur.")]
        [Range(18,65)]
        public int Age { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }


    }
}
