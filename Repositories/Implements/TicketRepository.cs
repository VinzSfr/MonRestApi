using Microsoft.EntityFrameworkCore;
using MonRestApi.Infrastructure.Data;
using MonRestApi.Infrastructure.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonRestApi.Repositories.Implements
{
    public class TicketRepository : ITicketRepository
    {
        private readonly TicketDbContext ticketDbContext;
 
        private int nbTicket = 1;

        private List<Ticket> tickets = new List<Ticket>();

        public TicketRepository(TicketDbContext ticketDbContext)
        {
            this.ticketDbContext = ticketDbContext;
            tickets.Add(new Ticket()
            {
                IdTicket = 1,
                EstConfirme = new DateTime(),
                EstSorti = new DateTime(),
                IdUtilisateur = 54321
            });
        }


        public Task<Ticket[]> GetAllTicketItemsAsync()
        {
           /*a deco
            *ticketDbContext.Database.Migrate();
            return ticketDbContext.Ticket.Include(t => t.User)
                            .Where(t => t.EstConfirme < DateTime.UtcNow && t.User.Tickets.Any())
                            .ToArrayAsync();*/

            return Task.FromResult(tickets.ToArray());
        }

        public int GetNewTicket()
        {
            int temp = nbTicket;
            nbTicket++;
            tickets.Add(new Ticket()
            {
                IdTicket = 1,
                EstConfirme = DateTime.UtcNow,
                EstSorti = DateTime.UtcNow.AddDays(1),
                IdUtilisateur = 54321
            });
            return temp;
        }
    }
}
