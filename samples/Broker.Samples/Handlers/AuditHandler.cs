using System;
using System.Threading.Tasks;
using Broker.Samples.Messages;

namespace Broker.Samples.Handlers
{
    public class AuditHandler : IHandle<IAudit>
    {
        public Task Handle(IAudit message)
        {
            Console.WriteLine($"User: {message.User}");
            return Task.CompletedTask;
        }
    }
}
