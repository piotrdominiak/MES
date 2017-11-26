using System;
using System.IO;

namespace MES_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int counter = 0;
            string line;
            try
            {
                //      StreamReader file = new StreamReader(@"/Users/piotrdominiak/Desktop/MES/plik.txt");
                StreamReader file = new StreamReader(@"I:/git/MES/plik.txt");
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    counter++;
                }

                file.Close();
                Console.WriteLine("Lines total: {0}", counter);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("file not found!");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
