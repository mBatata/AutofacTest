using AutofacTest.Factory.Classes;
using AutofacTest.Factory.Enums;
using AutofacTest.Factory.Interfaces;
using System;

namespace AutofacTest.Factory
{
    internal static class DateContainerFactory
    {
        public static IDateContainer GetDateContainer(DateContainerType dateContainerType)
        {
            switch (dateContainerType)
            {
                case DateContainerType.Today:
                    return new TodayDateContainer();

                case DateContainerType.Tomorrow:
                    return new TomorrowDateContainer();

                default:
                    throw new NotSupportedException($"Type {dateContainerType} not implemented");
            }
        }
    }
}
