using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MonRestApi.Infrastructure.Data.Tables
{
    public class Adresse
    {
        [Key]
        public int IdAdresse { get; set; }

        [Required]
        public string AddrNum { get; set; }

        [Required]
        public string AddrRue { get; set; }

        [Required]
        public string AddrCodePostal { get; set; }

        [Required]
        public string AddrPays { get; set; }
    }
}
