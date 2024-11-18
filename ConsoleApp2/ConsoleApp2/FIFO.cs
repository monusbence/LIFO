using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    using System;

    namespace FIFO
    {
        internal class FIFO
        {
            private double[] tomb;
            private int fej;
            private int veg;
            private int meret;

            public FIFO()
            {
                tomb = new double[50];
                fej = 0;
                veg = 0;
                meret = 0;
            }

            public FIFO(int meret)
            {
                tomb = new double[meret];
                fej = 0;
                veg = 0;
                this.meret = 0;
            }

            public void Push(double elem)
            {
                if (meret < tomb.Length)
                {
                    tomb[veg] = elem;
                    veg = (veg + 1) % tomb.Length;
                    meret++;
                }
                else
                {
                    throw new InvalidOperationException("A sor tele van!");
                }
            }

            public double Pop()
            {
                if (meret == 0)
                {
                    throw new InvalidOperationException("A sor üres!");
                }

                double elem = tomb[fej];
                fej = (fej + 1) % tomb.Length;
                meret--;
                return elem;
            }

            public void Clear()
            {
                fej = 0;
                veg = 0;
                meret = 0;
            }

            public int Length()
            {
                return meret;
            }

            public int GetSize()
            {
                return tomb.Length;
            }
        }
    }

}
