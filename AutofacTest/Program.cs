using Autofac;
using AutofacTest.Containers;
using AutofacTest.Interfaces;

namespace AutofacTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteDate();
        }

        private static void WriteDate()
        {
            using (var scope = MainContainer.RegisterContainer().BeginLifetimeScope())
            {
                var writer = scope.Resolve<IDateWriter>();
                writer.WriteDate();
            }
        }
    }
}
