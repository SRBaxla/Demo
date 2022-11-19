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
                    var records=csvReader.GetRecords<dynamic>(andaze).ToList();
                }
            }

        }
        public class andaze
        {
            //DATE,grain,BeerProduction,FactoryManagerName
            [Name("DATE")]
            public DateOnly DATE{get; set;}
            [Name("grain")]
            public string grain{get; set;}
            [Name("BeerProduction")]
            public int BeerProduction{get; set;}
            [Name("FactoryManagerName")]
            public string FactoryManagerName{get; set;}
        }
    }
}