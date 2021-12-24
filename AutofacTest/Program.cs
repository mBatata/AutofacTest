using Autofac;
using AutofacTest.Containers;
using AutofacTest.Factory;
using AutofacTest.Factory.Enums;
using AutofacTest.Interfaces;
using System;
using System.Linq;

namespace AutofacTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var dateContainerType in Enum.GetValues(typeof(DateContainerType)).Cast<DateContainerType>())
            {
                WriteDate(GetContainer(dateContainerType));
            }
        }

        private static void WriteDate(IContainer container)
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IDateWriter>();
                writer.WriteDate();
            }
        }

        private static IContainer GetContainer(DateContainerType dateContainerType)
        {
            return DateContainerFactory.GetDateContainer(dateContainerType).GetContainer();
        }
    }
}
