using System;
using System.Collections.Generic;

namespace MES_1
{
    public class Grid
    {
        public int mh, me;
        public  Node[] N;
        public Element[] E;

        public Grid(GlobalData data)
        {
            this.mh = data.mh;
            this.me = data.me;
        }

        public void Generate_Grid()
        {
            Node[] N = new Node[mh];
            Element[] E = new Element[me];
        }



        public void Generate_Node(GlobalData data)
        {
            double dx = 0;
            for (int i = 0; i < mh; i++)
            {
                N[i].x = dx;
                dx = dx + data.l / me;
                N[i].status = 0;

                if (i == 0)
                {
                    N[i].status = 1;
                }
                if (i == mh - 1)
                {
                    N[i].status = 2;
                }

            }
            for (int i = 0; i < me; i++)
            {
                E[i].ID[0] = i;
                E[i].ID[1] = i + 1;
                E[i].S = data.s;
                E[i].K = data.k;
                E[i].LP[0] = 0;
                E[i].LP[1] = 0;

            }

        }

        public void Generate_LH(GlobalData data)
        {
            double c;
            for (int i = 0; i < me; i++)
            {
                c = (E[i].S * E[i].K) / (N[E[i].ID[1]].x - N[E[i].ID[0]].x);
                E[i].LH[0][0] = c;
                E[i].LH[0][1] = -c;
                E[i].LH[1][0] = -c;
                E[i].LH[1][1] = c;

                if (N[E[i].ID[0]].status == 2){
                    E[i].LH[0][0] += data.alpha * E[i].S;
                }
                if (N[E[i].ID[1]].status == 2)
                {
                    E[i].LH[1][1] += data.alpha * E[i].S;
                }
            }
        }

        public void Generate_LP(GlobalData data)
        {

            for (int i = 0; i < me; i++)
            {
                if(N[E[i].ID[0]].status ==1)
                {
                    E[i].LP[0] = data.q * E[i].S;
                }
                if (N[E[i].ID[1]].status == 1)
                {
                    E[i].LP[1] = data.q * E[i].S;
                }
                if (N[E[i].ID[0]].status == 2)
                {
                    E[i].LP[0] = -data.alpha * data.t_alpha * E[i].S;
                }
                if (N[E[i].ID[1]].status == 1)
                {
                    E[i].LP[1] = -data.alpha * data.t_alpha * E[i].S;
                }
            }
        }
    }
}