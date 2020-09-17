using System.Threading.Tasks;
using MediatR;
using SheClean.Domain.Core.Bus;
using SheClean.Domain.Core.Commands;

namespace SheClean.Infra.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}