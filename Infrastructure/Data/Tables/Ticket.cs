using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MonRestApi.Infrastructure.Data.Tables
{
    public class Ticket
    {
        [Key]
        public int IdTicket { get; set; }

        [Required]
        public int IdUtilisateur { get; set; }

        public Utilisateur Utilisateur { get; set; }

        [Required]
        public DateTime EstConfirme { get; set; }

        [Required]
        public DateTime EstSorti { get; set; }
    }
}
