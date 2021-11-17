using System;
using System.IO;

namespace BlackSheep
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kirjuta programm, mis loeb faili sisu maha, asendab kõik numbrid tähtedega.
            //Uuenda faili sisu, et salvestada sinna uuendatud teksti versiooni.

            string filepath = @"C:\Users\opilane\samples\BlackSheep.txt";
            string[] dataFromFile = File.ReadAllLines(filepath);
            for (int i = 0; i < dataFromFile.Length; i++)
            {
                dataFromFile[i] = dataFromFile[i].Replace('4', 'a');
                dataFromFile[i] = dataFromFile[i].Replace('3', 'e');
                dataFromFile[i] = dataFromFile[i].Replace('0', 'o');
                dataFromFile[i] = dataFromFile[i].Replace('1', 'i');
            }
               
            foreach (string line in dataFromFile)
            {
               Console.WriteLine(line);
            }

            //update the file content
            File.WriteAllLines(filepath, dataFromFile);
             
        }


    }
        
    
}
