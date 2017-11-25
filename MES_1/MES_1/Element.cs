using System;
namespace MES_1
{
    public class Element
    {
        double S, K = 0;

        public int[] ID = new int[2];
        public int[,] LH = new int[2,2];
        public int[,] LP = new int[2, 1];

        public Element()
        {
        }
    }
}
