using MidQ19.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace CSVReader
{
    class Program
    {
        static void Main(string[] args)
        {
            CsvFileReaderWriter reader = new CsvFileReaderWriter();

            /* //From a CSV string with a header row
             string csv = "Id,StringColumn,StringWithQuotes,Number1,Number2,Number3\r\n1,test string,\"Commas, \"In Text\" are weird\",10,20,30";
             List<string[]> fields3 = reader.GetEntities(reader.ParseString(csv));
             reader.WriteFile("", fields3);

              //From a CSV File
              string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Data\csvsample.csv");
              bool fileExists = File.Exists(path);

              if (fileExists)
              {
                  List<string[]> entities = reader.GetEntities(path);
                  string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop, Environment.SpecialFolderOption.None) + "\\test.csv";
                  reader.WriteFile(filePath, entities);
              }
              else
              {
                  Console.Write($"File does not exist: \n   {path}");
              }*/
            var entities = new List<string[]>
            {
                new string[] // Header of CSV
                {
                    "StudentCode",
                    "LastName",
                    "ShoeSizeDateOfBirth",
                    "Height",
                    "DateOfBirth"
                },
                new string[]
                {
                    "12345678",
                    "Smith",
                    "7",
                    "167",
                    "2000-04-15"
                },
            };
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop, Environment.SpecialFolderOption.None) + "\\Q19.csv";
            reader.WriteFile(filePath, entities);
        }
    }
}
