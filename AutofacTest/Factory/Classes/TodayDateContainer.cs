using Autofac;
using AutofacTest.Classes;
using AutofacTest.Factory.Interfaces;
using AutofacTest.Interfaces;

namespace AutofacTest.Factory.Classes
{
    internal class TodayDateContainer : IDateContainer
    {
        public IContainer GetContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDateWriter>();

            return builder.Build();
        }
    }
}
