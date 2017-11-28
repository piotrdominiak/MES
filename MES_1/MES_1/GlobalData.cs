using System;
namespace MES_1
{
    public class GlobalData
    {
        double S, K, Alpha, T_Alpha = 0;
        int _mh, _me= 0;

        public GlobalData(int mh)
        {
            this._mh = mh;
            this._me = mh - 1;
        }

        public GlobalData(double s, double k, double al, double tal)
        {
            this.S = s;
            this.K = k;
            this.Alpha = al;
            this.T_Alpha = tal;
        }

        public void Gen_Grid()
        {
            
        }

        public void Print_Data()
        {
            Console.WriteLine("S - {0}, K - {1}, Alpha - {2}, T_Alpha - {3}", S,K,Alpha,T_Alpha);    
        }
    }
}
