using System;
using SheClean.Domain.Core.Events;

namespace SheClean.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public  DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}