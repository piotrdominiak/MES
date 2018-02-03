using System;
using System.IO;

namespace MES_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double s, k, alpha, t_alpha,l;
            int mh;

            try
            {
                StreamReader file1 = new StreamReader(@"/Users/piotrdominiak/Desktop/MES/plik.txt");
                //StreamReader file = new StreamReader(@"I:/git/MES/plik.txt");
            }
                catch (Exception e)
            {
                Console.WriteLine("file not found!");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            StreamReader file = new StreamReader(@"/Users/piotrdominiak/Desktop/MES/plik.txt");

                mh = int.Parse(file.ReadLine());
                s = double.Parse(file.ReadLine());        
                k = double.Parse(file.ReadLine());
                alpha = double.Parse(file.ReadLine());
                t_alpha = double.Parse(file.ReadLine());
                l = double.Parse(file.ReadLine());
                GlobalData global_Data = new GlobalData(mh,s, k, alpha, t_alpha,l);
                file.Close();




                double[,] hg = new double[global_Data.mh, global_Data.mh];
                double[] ht = new double[global_Data.mh];
                double[] hp = new double[global_Data.mh];
                global_Data.Print_Data();
            //    Console.WriteLine("Lines total: {0}", counter);

                SOE nowy_el = new SOE(hg, ht, hp);


                Grid grid = new Grid(global_Data);
                SOE global = new SOE(global_Data.mh);
                grid.Generate_Grid();
                grid.Generate_Node(global_Data);
                grid.Generate_LH(global_Data);
                grid.Generate_LP(global_Data);
                global.Generate_SOE(grid);


                global.Solve_Gauss();


                Console.ReadLine();
            }

        }
    }
