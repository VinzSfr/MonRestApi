using MonRestApi.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonRestApi.Business
{
    public interface ITicketBusiness
    {
        Task<TicketItemContractResponse[]> GetTicketsItemsAsync();
        int GetRandomNumber();
        int GetNewTicket();
    }
}
