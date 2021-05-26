using MakeItEasyCQRS.Commands.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace MakeItEasyCQRS.Handlers.Contracts
{
    public interface ICommandHandler<TCommand, TCommandResult>
        where TCommand : ICommand
        where TCommandResult : ICommandResult
    {
        Task<TCommandResult> Handle(TCommand command, CancellationToken cancellationToken);
    }
}