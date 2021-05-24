using MakeItEasyCQRS.Commands.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace MakeItEasyCQRS.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        Task<ICommandResult> Handle(T command, CancellationToken cancellationToken);
    }
}