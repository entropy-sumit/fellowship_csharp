using BenchmarkDotNet.Exporters.Csv;
using CsvHelper;
using IndianCensus_Analyser;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using static IndianCensus_Analyser.IndianStateCensusAnalyser;

namespace IndianCensus_Analyzer
{
    public class ImportCSVData
    {
        public string msg;
        private void ImportCSVData1(string msg)

        {
            this.msg = msg;
        }
        string importPath;
        public ImportCSVData(string path)
        {
            this.importPath = path;
        }

        public int ImportData()
        {
            int count = 0;
            if (!File.Exists(importPath))
            {
                throw new StateCensusFileExcption("wrong File or File not exist");
            }
            if (Path.GetExtension(importPath) != ".csv")
            {
                throw new StateCensusTypeExcption("wrong type");
            }

            using (var reader = new StreamReader(importPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                try
                {
                    var records = csv.GetRecords<IndianCensusData>().ToList();


                    Console.WriteLine("read data succesfully done");
                    foreach (IndianCensusData add in records)
                    {
                        count++;
                        Console.Write(" " + add.State);
                        Console.Write(" " + add.Population);
                        Console.Write(" " + add.Density);
                        Console.Write(" " + add.Literacy);
                        Console.WriteLine("\n");
                    }
                }
                catch (CsvHelper.HeaderValidationException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            return count;

        }


    }
}