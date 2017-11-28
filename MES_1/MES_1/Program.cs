using System;
using System.IO;

namespace MES_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double S, K, Alpha, T_Alpha;

            try
            {
                StreamReader file = new StreamReader(@"/Users/piotrdominiak/Desktop/MES/MES/plik.txt");
                //   StreamReader file = new StreamReader(@"I:/git/MES/plik.txt");
                S = double.Parse(file.ReadLine());        
                K = double.Parse(file.ReadLine());
                Alpha = double.Parse(file.ReadLine());
                T_Alpha = double.Parse(file.ReadLine());
                GlobalData global_Data = new GlobalData(S, K, Alpha, T_Alpha);
                file.Close();

                global_Data.Print_Data();
            //    Console.WriteLine("Lines total: {0}", counter);
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
