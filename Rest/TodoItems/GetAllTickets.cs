using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using MonRestApi.Business;

namespace MonRestApi.Rest.TicketItems
{
    public class GetAllTickets
    {
        private readonly ITicketBusiness ticketBusiness;
        public GetAllTickets(ITicketBusiness ticketBusiness)
        {
            this.ticketBusiness = ticketBusiness;
        }

        [FunctionName("GetAllTickets")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult(await ticketBusiness.GetTicketsItemsAsync());
        }
    }
}