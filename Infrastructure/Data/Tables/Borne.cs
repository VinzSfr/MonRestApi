﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MonRestApi.Infrastructure.Data.Tables
{
    public class Borne
    {
        [Key]
        public int IdBorne { get; set; }

        [Required]
        public string Numero { get; set; }

        [Required]
        public string IdMagasin { get; set; }

        public Magasin magasin;

    }
}
