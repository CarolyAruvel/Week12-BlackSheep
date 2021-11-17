using System;
using System.IO;

namespace Seasons
{
    class Program
    {
        static void Main(string[] args)
        {
            string winterFile = @"C:\Users\opilane\samples\Winter.txt";
            string autumnFile = @"C:\Users\opilane\samples\Autumn.txt";

            string[] autumnData = File.ReadAllLines(autumnFile);
            string[] winterData = File.ReadAllLines(winterFile);

            File.WriteAllLines(autumnFile, autumnData);
            File.WriteAllLines(winterFile, winterData);
        }
    }
}
