using IndianCensus_Analyzer;
using System;

namespace IndianCensus_Analyser
{
    public class Program
    {
        public static void Main(string[] args)
            {
                ImportCSVData obj = new ImportCSVData("C:/Users/sumit/source/repos/IndianCensus Analyser/IndianCensus Analyser/IndianStateCensusdatamore.csv");
                obj.ImportData();
            }
       
    }
}
