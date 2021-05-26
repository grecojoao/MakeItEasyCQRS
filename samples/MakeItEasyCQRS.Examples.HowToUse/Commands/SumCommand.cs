using DomainNotifications.Entities;
using MakeItEasyCQRS.Commands;

namespace MakeItEasyCQRS.Examples.HowToUse.Commands
{
    class SumCommand : Command
    {
        public decimal? ValueOne { get; set; }
        public decimal? ValueTwo { get; set; }

        public SumCommand() { }

        public SumCommand(decimal? valueOne, decimal? valueTwo)
        {
            ValueOne = valueOne;
            ValueTwo = valueTwo;
        }

        public override void Validate()
        {
            if (ValueOne == null)
                AddNotification(new Notification("ValueOne", "Invalid value"));
            if (ValueTwo == null)
                AddNotification(new Notification("ValueTwo", "Invalid value"));
        }
    }
}