﻿using System;
using System.IO;

namespace MES_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int counter = 0;
            string line;

            StreamReader file = new StreamReader(@"/Users/piotrdominiak/Desktop/MES/plik.txt");
            while((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                counter++;
            }

            file.Close();
            Console.WriteLine("Lines total: {0}", counter);
            Console.ReadLine();
        }
    }
}