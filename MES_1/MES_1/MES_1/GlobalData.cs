using System;
namespace MES_1
{
    public class GlobalData
    {
        public double s, k, alpha, l, q, T0;
        public int mh, me;
                
        public GlobalData(int mh, double s1, double k1, double a1,double l1,double q1, double T01)
        {
            this.mh = mh;
            this.me = mh - 1;
            this.s = s1;
            this.k = k1;
            this.alpha = a1;
            this.l = l1;
            this.q = q1;
            this.T0 = T01;
        }

        public void Print_Data()
        {
            Console.WriteLine("S - {0}, K - {1}, Alpha - {2}, T_0 - {3}, mh - {4}, q - {5}, l - {6}", s,k, alpha,T0,mh,q,l);    
        }

        
    }
}
