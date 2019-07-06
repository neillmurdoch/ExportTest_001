using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExportTest_001
{
    public class Export
    {
        public void ExportData(Person model)
        {
            if (model == null)
            {
                return;
            }

            // Just export the cars, as this is the problem area.

            var cars = model.Cars;

            var startRow = 1;
            var startCol = 11;

            Output(cars, startRow, startCol);
        }

        public void Output(object data, int startRow, int startCol)
        {
            if (data.GetType().IsGenericType && data.GetType().GetGenericTypeDefinition() == typeof(List<>))
            {
                var listData = (IList)data;

                var row = startRow;
                var col = startCol;

                foreach (var item in listData)
                {
                    foreach (var prop in item.GetType().GetProperties())
                    {
                        var propName = prop.Name;
                        var propValue = prop.GetValue(item, null);

                        if (propValue.GetType().IsGenericType && propValue.GetType().GetGenericTypeDefinition() == typeof(List<>))
                        {
                            // Sub list.


                        }
                        else
                        {
                            // Single value.
                            Console.WriteLine($"Outputting to row: {row:D2}, col: {col:D2} - {propValue}");

                        }


                        col++;
                    }

                    col = startCol;
                }
            }

        }
    }
}