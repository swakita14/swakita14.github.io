namespace cs_Final_part2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Crew")]
    public partial class Crew
    {
        public int CrewID { get; set; }

        public int Astronaut { get; set; }

        public int Mission { get; set; }

        [Required]
        public string Position { get; set; }

        public virtual Astronaut Astronaut1 { get; set; }

        public virtual Mission Mission1 { get; set; }
    }
}
