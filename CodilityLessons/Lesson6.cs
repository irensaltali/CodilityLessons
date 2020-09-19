using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLessons
{
    public class Lesson6
    {
        /// <summary>
        /// It is too easy that way but passes all tests :)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int Distinct(int[] A)
        {
            return A.Distinct().Count();
        }

        /// <summary>
        /// This one has same copmlexity but I didn't use linq;
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int Distinct2(int[] A)
        {
            int[] v = new int[2000001];
            for (int i = 0; i < A.Length; i++)
            {
                v[A[i] + 1000000]++;
            }

            int r = 0;
            foreach (var vv in v)
            {
                if (vv > 0)
                    r++;
            }

            return r;
        }
    }
}
