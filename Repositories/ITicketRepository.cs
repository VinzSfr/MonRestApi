using MonRestApi.Infrastructure.Data.Tables;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonRestApi.Repositories
{
    public interface ITicketRepository
    {
        Task<Ticket[]> GetAllTicketItemsAsync();
        int GetNewTicket();
    }
}
