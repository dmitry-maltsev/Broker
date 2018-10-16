﻿using System;
using System.Threading.Tasks;
using Broker.Samples.Messages;

namespace Broker.Samples.Handlers
{
    public class DerivedHandler : BaseHandler
    {
        public override Task Handle(GreetingMessage message)
        {
            Console.WriteLine("Derived");
            return Task.CompletedTask;
        }
    }
}
