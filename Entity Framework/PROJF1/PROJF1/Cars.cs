namespace PROJF1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cars
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cars()
        {
            PilotsCars = new HashSet<PilotsCars>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string modelo { get; set; }

        public int ano { get; set; }

        public int unidade { get; set; }

        public int id_equipe { get; set; }

        public virtual Teams Teams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PilotsCars> PilotsCars { get; set; }
    }
}
