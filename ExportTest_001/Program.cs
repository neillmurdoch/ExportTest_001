using System;

namespace ExportTest_001
{
    class Program
    {
        static void Main(string[] args)
        {
            var export = new Export();

            export.ExportData(new DataModel().GetPerson());

            Console.ReadLine();
        }
    }
}
