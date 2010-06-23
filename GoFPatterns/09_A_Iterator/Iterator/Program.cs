using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    internal static class Program
    {
        private static void Main()
        {
            var dateRange = new DateRange(DateTime.Now, DateTime.Now.AddDays(10));

            var dateTimes = dateRange.Where(d => d.DayOfWeek != DayOfWeek.Sunday);

            foreach (var date in dateTimes.ToList())
            {
                Console.WriteLine(date);
            }

            Console.ReadLine();
        }
    }

    internal class DateRange : IEnumerable<DateTime>
    {
        private readonly DateTime start;
        private readonly DateTime end;

        public DateRange(DateTime start, DateTime end)
        {
            this.start = start;
            this.end = end;
        }

        public IEnumerator<DateTime> GetEnumerator()
        {
            var numberOfLoops = 0;
            for (var day = start.Date; day <= end; day = day.AddDays(1))
            {
                if (numberOfLoops > 5)
                    break;
                yield return day;
                numberOfLoops++;
            }
            yield return new DateTime(2010, 1, 1);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}