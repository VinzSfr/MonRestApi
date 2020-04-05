using MonRestApi.Contracts.Responses;
using MonRestApi.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MonRestApi.Business.Implements
{
    public class TicketBusiness : ITicketBusiness
    {
        private readonly ITicketRepository ticketRepository;

        public TicketBusiness(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        public int GetNewTicket()
        {
            return ticketRepository.GetNewTicket();
        }

        public int GetRandomNumber()
        {
            return new Random().Next();
        }

        public async Task<TicketItemContractResponse[]> GetTicketsItemsAsync()
        {
            var tickets = await ticketRepository.GetAllTicketItemsAsync();

            return tickets.Select(t => new TicketItemContractResponse()
            {
                IdTicket = t.IdTicket,
                EstConfirme = t.EstConfirme,
                EstSorti = t.EstSorti,
                FKUser = t.IdUtilisateur
            }).ToArray();
        }
    }
}
