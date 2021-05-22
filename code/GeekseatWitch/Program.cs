using System;
using System.Collections.Generic;
using System.Linq;

namespace GeekseatWitch
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;

            List<Deceased> deceaseds = new List<Deceased>();
            while (true)
            {
                Console.Write($"please enter decease #{deceaseds.Count + 1} valid age of death and year of death, separated by space: ");
                var inputs = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                deceaseds.Add(new Deceased(inputs[0], inputs[1]));

                Console.Write("add another decease? [y/n]");
                string yesOrNo = Console.ReadLine();
                if (!yesOrNo.Equals("y", StringComparison.CurrentCultureIgnoreCase)) break;
            }

            Console.WriteLine($"Average people killed on each deceased year of birth: {AveragePeopleKilledOnYoB(deceaseds)}");
            Console.ReadLine();
        }

        static decimal AveragePeopleKilledOnYoB(List<Deceased> deceaseds)
        {
            var totalPeopleKilled = 0;
            foreach (var decease in deceaseds) totalPeopleKilled += decease.PeopleKilledOnYoB();

            return (decimal)totalPeopleKilled / deceaseds.Count;
        }

        private static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is InvalidDeceasedDataException) Console.WriteLine("not a valid deceased data!");

            Console.WriteLine("Please enter a valid data the next time :( .");
            Environment.Exit(-1);
        }

    }
}
