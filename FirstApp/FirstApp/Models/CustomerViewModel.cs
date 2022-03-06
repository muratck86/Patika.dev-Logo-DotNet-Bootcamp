using System;

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
        public DateTime BirthDate { get; set; }
    }
}
