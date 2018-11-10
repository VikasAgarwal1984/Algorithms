using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Armstrong : ISolve<List<int>>
    {
        public List<int> Solve()
        {
            return Slow();
        }

        private List<int> Slow()
        {
            var lst = new List<int>();
            for (int i = 1; i <= 1000; i++)
            {
                if (IsArmstrong(i)) lst.Add(i);
            }

            return lst;
        }

        private bool IsArmstrong(int number)
        {
            int s = 0;
            int t = number;
            while(t != 0)
            {
                int r = t % 10;
                t = t / 10;
                s += r * r * r;
            }

            return number == s;
        }
    }
}
