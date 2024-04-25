namespace Periodic_Table_Elements.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class element
    {
        [Key]
        public int element_id { get; set; }

        public int? group { get; set; }

        public int? period { get; set; }

        public int? atomic_number { get; set; }

        public decimal? atomic_mass { get; set; }

        [StringLength(50)]
        public string symbol { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string type { get; set; }
    }
}
