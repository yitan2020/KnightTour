using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assginment1_YiTan
{

    /*
     * This class simulate the square on the chess board. 
     * It has three properties X coordiante, Y coordiante and rate value. 
     * 
     */
    class Square
    {
        private int x;
        private int y;
        private int rate;


        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Square(int x, int y, int rate)
        {
            this.x = x;
            this.y = y;
            this.rate = rangeCheckedRate(rate);
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int RATE
        {
            get { return rate; }
            set { rate = rangeCheckedRate(value); }
        }

        public static int rangeCheckedRate(int rate)
        {
            if (rate < 2 || rate == 5 || rate > 8)
                rate = 0;

            return rate;

        }


    }
}
