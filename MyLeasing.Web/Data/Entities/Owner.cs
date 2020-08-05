using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner
    {

        public int Id { get; set; }
        [MaxLength(14, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "El Campo {0} es Obligatorio.")]
        [Display(Name = "Identificacion")]
        public String Document { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [MaxLength(20)]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [MaxLength(20)]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        [MaxLength(100)]
        [Display(Name = "Address ")]
        public string Address { get; set; }


        [Display(Name = "Nombre Completo")]
        public string FullName => $"{FirstName} {LastName}";

        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

        public ICollection<Property> Properties { get; set; }

        public ICollection<Contract> Contracts { get; set; }

    }
}
