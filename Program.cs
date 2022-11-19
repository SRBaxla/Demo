using System;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace Csvreader
{
    class Program
    {
        static void Main(string[] args)
        {
            using( var streamReader = new StreamReader(@"C:\Users\srb73\Desktop\Demo\csvfile\Input_v1.0.csv"))
            {
                using( var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    var records=csvReader.GetRecords<dynamic>().ToList();
                }
            }

        }
        public class andaze
        {
            //DATE,grain,BeerProduction,FactoryManagerName
            public DateOnly Date{get; set;}
            public string grain{get; set;}
            public int BeerProduction{get; set;}
            public string FactoryManagerName{get; set;}
        }
    }
}