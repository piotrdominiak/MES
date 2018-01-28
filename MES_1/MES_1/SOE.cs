using System;
namespace MES_1
{
    public class SOE
    {
        public int[,] HG;
        public int[] PG;
        public int[] TG;

        public SOE(int[,] h, int[] t, int[] p)
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

        void Fill_Zero(int[,] t){
            for (int i = 0; i < t.GetLength(0);i++){
                for (int j = 0; j < t.GetLength(1); j++){
                    t[i, j] = 0;
                }
            }
        }

        void Fill_Zero(int[] t)
        {
            for (int i = 0; i < t.GetLength(0); i++)
            {
               t[i] = 0;
             }
        }

        void Print_SOE(int[] t){
            for (int i = 0; i < t.GetLength(0); i++)
            {
                Console.Write(t[i]+" ");
            }
            Console.WriteLine();
        }
        void Print_SOE(int[,] t)
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
     }
}
