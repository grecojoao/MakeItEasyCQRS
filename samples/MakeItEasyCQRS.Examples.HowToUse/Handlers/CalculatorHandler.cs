using MakeItEasyCQRS.Commands;
using MakeItEasyCQRS.Commands.Contracts;
using MakeItEasyCQRS.Examples.HowToUse.Commands;
using MakeItEasyCQRS.Handlers.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace MakeItEasyCQRS.Examples.HowToUse.Handlers
{
    class CalculatorHandler : IHandler<SumCommand>
    {
        public Task<ICommandResult> Handle(SumCommand command, CancellationToken cancellationToken = default)
        {
            command.Validate();
            if (command.IsInvalid)
                return Task.FromResult((ICommandResult)new CommandResult(false, command.NotificationsMessage(), command.Notifications));

            var calculatedValue = Calculator.Sum((decimal)command.ValueOne, (decimal)command.ValueTwo);
            return Task.FromResult((ICommandResult)new CommandResult(true, "Calculation done", calculatedValue));
        }
    }
}