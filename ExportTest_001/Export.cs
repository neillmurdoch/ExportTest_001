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

        public int Output(object data, int startRow, int startCol)
        {
            var row = startRow;
            var col = startCol;

            var rowsToAdd = 0;

            if (data.GetType().IsGenericType && data.GetType().GetGenericTypeDefinition() == typeof(List<>))
            {
                var listData = (IList)data;

                foreach (var item in listData)
                {
                    rowsToAdd = CalculateRowsInItem(item);

                    if (!item.GetType().IsPrimitive && item.GetType() != typeof(DateTime) && item.GetType() != typeof(string))
                    {
                        foreach (var prop in item.GetType().GetProperties())
                        {
                            var propName = prop.Name;
                            var propValue = prop.GetValue(item, null);

                            if (propValue.GetType().IsGenericType && propValue.GetType().GetGenericTypeDefinition() == typeof(List<>))
                            {
                                // Sub list.
                                Output(propValue, row, col);

                            }
                            else
                            {
                                // Single value.
                                Console.WriteLine($"Outputting to row: {row:D2}, col: {col:D2} - {propValue}");

                            }
                            col++;
                        }
                    }
                    else
                    {
                        // Single value.
                        Console.WriteLine($"Outputting to row: {row:D2}, col: {col:D2} - {item}");
                    }

                    col = startCol;
                    row++;
                }
            }
            else
            {
                // Not a list


            }

            return row;
        }

        private int CalculateRowsInItem(object item)
        {
            var itemRowCount = 0;

            if (!item.GetType().IsPrimitive && item.GetType() != typeof(DateTime) && item.GetType() != typeof(string))
            {
                foreach (var prop in item.GetType().GetProperties())
                {
                    var propName = prop.Name;
                    var propValue = prop.GetValue(item, null);

                    var listCount = 0;
                    if (propValue.GetType().IsGenericType && propValue.GetType().GetGenericTypeDefinition() == typeof(List<>))
                    {
                        var propValueList = (IList)propValue;
                        var propListItem = propValueList[0];

                        if (!propListItem.GetType().IsPrimitive && propListItem.GetType() != typeof(DateTime) && propListItem.GetType() != typeof(string))
                        {
                            foreach (var propValueListItem in propValueList)
                            {
                                listCount += CalculateRowsInItem(propValueListItem);
                            }
                        }
                        else
                        {
                            listCount = ((IList)propValue).Count;
                        }
                    }
                    else
                    {
                        // Single value.
                        listCount = 1;
                    }

                    if (listCount > itemRowCount)
                    {
                        itemRowCount = listCount;
                    }
                }
            }
            else
            {
                itemRowCount = 1;
            }

            return itemRowCount;
        }
    }
}