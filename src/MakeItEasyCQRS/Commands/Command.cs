using DomainNotifications;
using MakeItEasyCQRS.Commands.Contracts;

namespace MakeItEasyCQRS.Commands
{
    public abstract class Command : Notifiable, ICommand
    {
        public abstract void Validate();
    }
}