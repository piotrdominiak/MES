using System;
namespace MES_1
{
    
    public class SOE
    {
     //   private static double EPSILON = 1e-10;
        public double[,] HG;
        public double[] PG;
        public double[] TG;
        public int size;


        public SOE(int size)
        {
            HG = new double[size, size];
            PG = new double[size];
            TG = new double[size];
            this.size = size;
        }


        public SOE(double[,] h, double[] t, double[] p)
        {
            this.HG = h;
            this.TG = t;
            this.PG = p;
            Fill_Zero(h);
            Fill_Zero(t);
            Fill_Zero(p);
            Print_SOE(h);
            Print_SOE(t);
            Print_SOE(p);
        }

        void Fill_Zero(double[,] t){
            for (int i = 0; i < t.GetLength(0);i++){
                for (int j = 0; j < t.GetLength(1); j++){
                    t[i, j] = 0;
                }
            }
        }

        void Fill_Zero(double[] t)
        {
            for (int i = 0; i < t.GetLength(0); i++)
            {
               t[i] = 0;
             }
        }

        void Print_SOE(double[] t){
            for (int i = 0; i < t.GetLength(0); i++)
            {
                Console.Write(t[i]+" ");
            }
            Console.WriteLine();
        }
        void Print_SOE(double[,] t)
        {
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    Console.Write(t[i,j] + " ");
                } Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void Generate_SOE(Grid grid){
            int ID1, ID2;
            for (int i = 0; i < grid.me;i++){
                ID1 = grid.E[i].ID[0];
                ID2 = grid.E[i].ID[1];
                HG[ID1,ID1] += grid.E[i].LH[0,0];
                HG[ID1,ID2] += grid.E[i].LH[0,1];
                HG[ID2,ID1] += grid.E[i].LH[1,0];
                HG[ID2,ID2] += grid.E[i].LH[1,1];
                PG[ID1] += grid.E[i].LP[0];
                PG[ID2] += grid.E[i].LP[1];
            }
        }
        public void Solve_Gauss()
        {
            for (int k = 0; k < size; k++)
            {
                for (int i = k + 1; i < size; i++)
                {
                    double m = HG[i, k] / HG[k, k];
                    for (int j = k; j < size;j++)
                    {
                        HG[i, j] -= m * HG[k, j];
                    }
                    PG[i] -= m * PG[k];
                }
            }
            for (int i = size - 1; i >= 0; i--)
            {
                TG[i] = -PG[i];
                for (int j = i + 1; j < size;j++)
                {
                    TG[i] -= HG[i, j] * TG[j];
                }
                TG[i] /= HG[i, i];
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(" temp: {0}", TG[i]);
            }
        }

        void Print_Gauss()
        {
            
        }

     }
}
