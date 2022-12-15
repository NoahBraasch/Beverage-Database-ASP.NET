using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Beverage_Database.Models
{
    public partial class Beverage
    {
        [Key]
        [Column("id")]
        [StringLength(10)]
        public string Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [Column("pack")]
        [StringLength(20)]
        public string Pack { get; set; }
        [Column("price", TypeName = "money")]
        public decimal Price { get; set; }
        [Column("active")]
        public bool Active { get; set; }
    }
}
