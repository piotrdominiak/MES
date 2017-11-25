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

        public void Gen_Grid()
        {
            
        }
    }
}
