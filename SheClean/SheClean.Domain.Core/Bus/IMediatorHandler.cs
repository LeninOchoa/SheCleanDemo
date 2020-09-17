using System.Threading.Tasks;
using SheClean.Domain.Core.Commands;

namespace SheClean.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}