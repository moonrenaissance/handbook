using System.ComponentModel.DataAnnotations;

namespace Handbook.Models
{
    public class Employees
    {
        public int Id { get; set; }

        [Display(Name="Full name")]
        public string FullName { get; set; }
        public string Department { get; set; }

        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Cabinet number")]
        public string CabinetNumber { get; set; }

    }
}
