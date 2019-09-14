using System;
using Domain_Event.Core.Entities;
using Domain_Event.Core.Interfaces;
using Domain_Event.Infrastructure.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace Domain_Event.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set up the DI
            //Scan the assembly and register types that implements IDomainHandler interface with .Net Core IoC
            var serviceProvider = new ServiceCollection()
                .Scan( scan => scan
                    .FromAssemblyOf<StudentRegisteredHandler>()
                    .AddClasses(classes => classes.AssignableTo(typeof(IDomainHandler<>))).AsImplementedInterfaces()
                ).BuildServiceProvider();

            DomainEvent._serviceProvider = serviceProvider;
            
            //Create an order
            
            var newOrder = new Order(5, "Amazon");
            //Raise an order completed event
            newOrder.OrderComplete();
            
            
            var studentReg = new Student(Title.Mr, "John", "Murphy");
            studentReg.RegisterStudent();
            
            var emailSent = new Email("recipient@contact.com", "sender@contact.com", "Event Message Subject", "This is a short email to say thank you!");
            emailSent.RaiseEmailSent();

            Console.ReadKey();
        }
    }
}