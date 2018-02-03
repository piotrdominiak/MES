using System;
namespace MES_1
{
    public class GlobalData
    {
        public double s, k, alpha, t_alpha, q, l;
        public int mh, me;
                
        public GlobalData(int mh, double s1, double k1, double a1, double t_al, double l1)
        {
            this.mh = mh;
            this.me = mh - 1;
            this.s = s1;
            this.k = k1;
            this.alpha = a1;
            this.t_alpha = t_al;
            this.l = l1;
        }

        public void Print_Data()
        {
            Console.WriteLine("S - {0}, K - {1}, Alpha - {2}, T_Alpha - {3}, mh - {4}, l - {5}", s,k, alpha,t_alpha,mh,l);    
        }

        
    }
}
