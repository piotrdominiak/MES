using System;
namespace MES_1
{
    public class GlobalData
    {
        double s, k, alpha, t_alpha, q = 0;
        int mh, me;
                
        public GlobalData(int mh, double s1, double k1, double a1, double tal)
        {
            this.mh = mh;
            this.me = mh - 1;
            this.s = s1;
            this.k = k1;
            this.alpha = a1;
            this.t_alpha = tal;
        }

        public void Gen_Grid()
        {
            
        }

        public void Print_Data()
        {
            Console.WriteLine("S - {0}, K - {1}, Alpha - {2}, T_Alpha - {3}, mh - {4}", s,k, alpha,t_alpha,mh);    
        }

        
    }
}
