using System;
using System.IO;

namespace MES_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double s, k, alpha, t_alpha;
            int mh; 

            try
            {
                // StreamReader file = new StreamReader(@"/Users/piotrdominiak/Desktop/MES/MES/plik.txt");
                StreamReader file = new StreamReader(@"I:/git/MES/plik.txt");
                mh = int.Parse(file.ReadLine());
                s = double.Parse(file.ReadLine());        
                k = double.Parse(file.ReadLine());
                alpha = double.Parse(file.ReadLine());
                t_alpha = double.Parse(file.ReadLine());
                GlobalData global_Data = new GlobalData(mh,s, k, alpha, t_alpha);
                file.Close();

                double dx = 0;
                double[] array1 = new Double[global_Data.mh];
                double[] array2 = new Double[global_Data.me];

                Node N = new Node(array1);
                Node E = new Node(array2);
                
                N.a

                for (int i = 0; i < global_Data.mh; i++) {
                   N[i].x
                } 
                  


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
