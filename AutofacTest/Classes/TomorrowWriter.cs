using AutofacTest.Interfaces;
using System;

namespace AutofacTest.Classes
{
    public class TomorrowWriter : IDateWriter
    {
        private IOutput _output;

        public TomorrowWriter(IOutput output)
        {
            this._output = output;
        }

        public void WriteDate()
        {
            this._output.Write(DateTime.Today.AddDays(1).ToShortDateString());
        }
    }
}
