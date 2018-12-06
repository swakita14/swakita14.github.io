namespace cs_Final_part2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Astronaut")]
    public partial class Astronaut
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Astronaut()
        {
            Crews = new HashSet<Crew>();
        }

        public int AstronautID { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DateCorrectRange(ValidateBirthDate = true, ErrorMessage = "Birth Date can not be greater than current date")]
        public DateTime Birthday { get; set; }

        public int Nationality { get; set; }

        public virtual Country Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Crew> Crews { get; set; }
    }
}
