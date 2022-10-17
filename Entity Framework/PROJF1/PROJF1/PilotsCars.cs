namespace PROJF1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PilotsCars
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_piloto { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_carro { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime data_evento { get; set; }

        public virtual Cars Cars { get; set; }

        public virtual Pilots Pilots { get; set; }
    }
}
