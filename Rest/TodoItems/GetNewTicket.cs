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

namespace MonRestApi.Rest.TodoItems
{
    public class GetNewTicket
    {
        private readonly ITicketBusiness ticketBusiness;
        public GetNewTicket(ITicketBusiness ticketBusiness)
        {
            this.ticketBusiness = ticketBusiness;
        }

        [FunctionName("GetNewTicket")]
        public int Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            return ticketBusiness.GetNewTicket();
        }
    }
}
