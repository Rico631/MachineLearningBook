using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsRecognizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var trainingPath = @"E:\Projects\SharedProjects\MachineLearning\Data\trainingsample.csv";
            var training = DataReader.ReadObservations(trainingPath);
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
