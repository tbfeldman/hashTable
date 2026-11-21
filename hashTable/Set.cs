using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTable
{
    internal class Set
    {
        public List<int>[] A;

        void Add(int x)
        {
            List<int> s = A[h(x)];
            bool b = false;
            foreach (var item in s)
            {
                if (item == x)
                {
                    b = true;
                }
            }
            if (!b)
            {
                s.Add(x);

            }
        }
        bool find(int x)
        {
            List<int> s= A[h(x)];
            foreach (var item in s)
            {
                if (item == x)
                {
                   return true;
                }
            }
            return false;   
        }
        void remove(int x)
        {
            if (find(x))
            {
                List<int> s = A[h(x)];
                s.Remove(x);
            }
        }
        int h(int x)
        {
            return x * 4 + 7;
        }

    }
}
