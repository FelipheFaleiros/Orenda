namespace Orenda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Produtos
    {
        [Key]
        public int cod_prod { get; set; }

        [Required]
        [StringLength(100)]
        public string prodNome { get; set; }

        public int prodQtd { get; set; }

        [Column(TypeName = "date")]
        public DateTime prodVal { get; set; }

        [Column(TypeName = "money")]
        public decimal prodPreco { get; set; }

        public TimeSpan? prodTempo { get; set; }
    }
}
