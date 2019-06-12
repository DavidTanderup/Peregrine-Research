using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ResearchLibrary.Locations
{
    public class FileLocations
    {
        /// <summary>
        /// Returns the location of the historical stock data.
        /// </summary>
        /// <param name="stock"></param>
        /// <returns></returns>
        public string StockData(string stock)
        {
            string location = @"C:\Peregrine Research\Stock Data\"+stock+".csv";
            return location;
        }

        public string DatabaseConnectionString(string database)
        {
            string connectionString = $"Persist Security Info=False;Integrated Security=true;" +
                                      $"Initial Catalog={database};server=LAPTOP-JGOUUEDF";
            return connectionString;
        }

    }
}
