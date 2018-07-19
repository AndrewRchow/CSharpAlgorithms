using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class totalEvensInArray
    {
        public static int Algorithm(int[] input)
        {
            int total = 0;

            for (int i = 0; i <input.Length; i++)
            {
                if(input[i]%2==0)
                {
                    total += input[i];
                }
            }

            return total;
        }
    }
}
