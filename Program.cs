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
        public static sameyear(int year)
        {

        }
        static void Main(string[] args)
        {
            using( var streamReader = new StreamReader(@"C:\Users\srb73\Desktop\Demo\csvfile\Input_v1.0.csv"))
            {
                using( var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    var records=csvReader.GetRecords<Andaze>().ToList();

                    //List<Person> persons = students.Select(student => new Person {FirstName = student.FirstName, LastName = student.LastName}).ToList();
                    List<OUTPUT> output = records.Select(records => new OUTPUT {Date=records.DATE, Grain=records.grain,BeerProduction=records.BeerProduction, Manager=records.FactoryManagerName}).ToList();
                    List<compute> computes = output.Select(output => new compute {year=output.Date.Year,BeerProduction=output.BeerProduction}).ToList();
                    foreach (compute i in computes)
                    {
                        var year=i.year;
                        if(year == i.year)
                        {
                            computes.BinaryS
                        }
                    }
                }
            }

        }
        public class compute
        {
            public int year{get; set;}
            public double BeerProduction{get;set;}
            public double YearMean{get;set;}
            public double YearMedian{get;set;}
        }
        public class Andaze
        {
            //DATE,grain,BeerProduction,FactoryManagerName
            [Name("DATE")]
            public DateOnly DATE{get; set;}
            [Name("grain")]
            public string grain{get; set;}
            [Name("BeerProduction")]
            public double BeerProduction{get; set;}
            [Name("FactoryManagerName")]
            public string FactoryManagerName{get; set;}
            
        }
        public class OUTPUT
        {
            public DateOnly Date{get; set;}
            public string Grain{get; set;}
            public double BeerProduction{get; set;}
            public string Manager{get; set;}

            public double YearMean{get; set;}

            public double YearMedian{get; set;}

            public string IsBearProduct{get; set;}
        }
    }
}