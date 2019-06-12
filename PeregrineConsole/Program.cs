using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeregrineConsole.MathEngine;
using PeregrineConsole.Operations;
using ResearchLibrary.DataMove;
using ResearchLibrary.Objects;
using ResearchLibrary.SQL;
using System.Timers;
using System.Net;
using ResearchLibrary.Locations;

namespace PeregrineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = DateTime.Now;
            //DownloadEngine download = new DownloadEngine();
            //Formatting formatting = new Formatting();
            //MACD macd = new MACD();
            //Stochastic stochastic = new Stochastic();
            //TechnicalIndicators indicators = new TechnicalIndicators();
            //Transactions transactions = new Transactions();
            //WebClient web = new WebClient(); // provides the ability to download from the internet
            //WebURIs uRIs = new WebURIs(); // refers to an instance of the Wall Street Journal URL
            PeregrineOperation peregrine = new PeregrineOperation();

            //string stockData = web.DownloadString(uRIs.WSJHistorical("A", "02/09/2019", "06/12/2019")); // method call to retrieve the data                           

            //Console.WriteLine(stockData);
           peregrine.Run("09:22:00");

        }


    }
}
