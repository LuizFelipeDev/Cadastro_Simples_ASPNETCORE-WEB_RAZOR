﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AulaCoreDesktop.Data
{
    public partial class Categoria
    {
        [Key]
        [Column("Cat_ID")]
        public int CatId { get; set; }
        [Required]
        [Column("Cat_Nome")]
        [StringLength(50)]
        public string CatNome { get; set; }
    }
}