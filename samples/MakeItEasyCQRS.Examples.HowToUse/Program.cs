using DomainNotifications.Entities;
using MakeItEasyCQRS.Examples.HowToUse.Commands;
using MakeItEasyCQRS.Examples.HowToUse.Handlers;
using System;
using System.Collections.Generic;

namespace MakeItEasyCQRS.Examples.HowToUse
{
    static class Program
    {
        static void Main()
        {
            var handler = new CalculatorHandler();
            var command = new SumCommand(null, null);
            var commandResult = handler.Handle(command).Result;
            Console.WriteLine($"Command Result - " +
                $"Sucess: { commandResult.Sucess}, " +
                $"Message: {commandResult.Message}, " +
                $"Notifications: {((IReadOnlyCollection<Notification>)commandResult.Data).Count}");

            handler = new CalculatorHandler();
            command = new SumCommand(10, 10);
            commandResult = handler.Handle(command).Result;
            Console.WriteLine($"Command Result - " +
                $"Sucess: { commandResult.Sucess}, " +
                $"Message: {commandResult.Message}, " +
                $"Calculed value: {(decimal)commandResult.Data}");
        }
    }
}