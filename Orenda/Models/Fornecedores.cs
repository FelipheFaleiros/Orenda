namespace Orenda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fornecedores
    {
        [Key]
        public int cod_For { get; set; }

        [Required]
        [StringLength(100)]
        public string forNome { get; set; }

        public decimal forCNPJ { get; set; }

        [Required]
        [StringLength(100)]
        public string forEndereco { get; set; }

        [Column(TypeName = "money")]
        public decimal forPreco { get; set; }

        public TimeSpan? forTempo { get; set; }
    }
}
