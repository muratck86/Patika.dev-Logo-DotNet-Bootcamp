using System;
using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
    public class CustomerViewModel
    {
        public CustomerViewModel()
        { }
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty ;
        public string Address { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Description { get; set; } = string.Empty;

        private DateTime _birthDate;

        [Display(Name="Yas")]
        public DateTime BirthDate 
        {   get { return _birthDate; } 
            set 
            { 
                if (value.Year > 1970)
                {
                    Description = "Müşterinin doğum tarihi 1970'ten büyük";
                }
                _birthDate = value;
            } 
        }

    }
}
