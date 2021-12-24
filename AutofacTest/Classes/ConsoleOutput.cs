using AutofacTest.Interfaces;
using System;

namespace AutofacTest.Classes
{
    public class ConsoleOutput : IOutput
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}
