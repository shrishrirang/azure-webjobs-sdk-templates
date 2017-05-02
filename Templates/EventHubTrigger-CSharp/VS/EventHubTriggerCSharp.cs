using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.WebJobs.ServiceBus;


namespace Company.Function
{
    public static class EventHubTriggerCSharp
    {
        [FunctionName("FunctionNameValue")]
        public static void Run([EventHubTrigger("PathValue", Connection = "ConnectionValue")]string myEventHubMessage, TraceWriter log)
        {
            log.Info($"C# Event Hub trigger function processed a message: {myEventHubMessage}");
        }
    }
}