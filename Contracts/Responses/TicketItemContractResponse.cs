using System;
using System.Collections.Generic;
using System.Text;

namespace MonRestApi.Contracts.Responses
{
    public class TicketItemContractResponse
    {
        public int IdTicket { get; set; }
        public int FKUser { get; set; }
        public DateTime EstConfirme { get; set; }
        public DateTime EstSorti { get; set; }
    }
}
