using Autofac;
using AutofacTest.Classes;
using AutofacTest.Interfaces;

namespace AutofacTest.Containers
{
    public static class MainContainer
    {
        public static IContainer RegisterContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDateWriter>();

            return builder.Build();
        }
    }
}
