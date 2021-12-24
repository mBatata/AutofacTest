using Autofac;
using AutofacTest.Classes;
using AutofacTest.Interfaces;

namespace AutofacTest.Containers
{
    public static class Container
    {
        public static void RegisterContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDateWriter>();

            builder.Build();
        }
    }
}
