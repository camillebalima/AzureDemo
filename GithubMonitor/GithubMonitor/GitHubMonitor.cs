using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace GithubMonitor
{
    public static class GitHubMonitor
    {
        [FunctionName("GitHubMonitor")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            //Log Information to the function invocation details
            log.LogInformation("Our Github Monitor processed an action");

            //Get the request body and log it to the function invocation details
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            log.LogInformation(requestBody);

            return new OkResult();
        }
    }
}
