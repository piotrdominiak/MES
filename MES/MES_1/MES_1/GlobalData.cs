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
            Console.WriteLine("MH = {0}, S = {1}, K = {2}, Alpha = {3}, L = {4}, Q = {5}, T alpha = {6}", mh,s, k, alpha,l,q,T0);    
        }

        
    }
}
