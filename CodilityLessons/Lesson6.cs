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

        public int MaxProductOfThree(int[] A)
        {
            int max = int.MinValue;
            int v;

            if (A.Length > 5)
            {
                Array.Sort(A);
                int[] Ar = new int[] { A[0], A[1], A[A.Length - 3], A[A.Length - 2], A[A.Length - 1] };

                for (int i = 0; i < Ar.Length; i++)
                {
                    for (int j = i + 1; j < Ar.Length; j++)
                    {
                        for (int k = j + 1; k < Ar.Length; k++)
                        {
                            v = Ar[i] * Ar[j] * Ar[k];
                            if (v > max)
                                max = v;
                        }
                    }
                }
            }
            else
            {

                for (int i = 0; i < A.Length; i++)
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        for (int k = j + 1; k < A.Length; k++)
                        {
                            v = A[i] * A[j] * A[k];
                            if (v > max)
                                max = v;
                        }
                    }
                }

            }

            return max;
        }

        public int NumberOfDiscIntersections(int[] A)
        {
            if (A.Length < 2)
                return 0;

            long[] starts = new long[A.Length];
            long[] ends = new long[A.Length];


            for (int i = 0; i < A.Length; i++)
            {
                starts[i] = i - A[i];
                ends[i] = (long)i + A[i];
            }

            Array.Sort(starts);
            Array.Sort(ends);

            long startsIndex = 0;
            long endsIndex = 0;
            long index = starts[0];
            long discCount = 0;
            long intersection = 0;
            while (index <= ends[ends.Length - 1])
            {
                while (startsIndex < starts.Length && starts[startsIndex] == index)
                {
                    intersection += discCount;
                    discCount++;
                    startsIndex++;
                }

                while (endsIndex < ends.Length && ends[endsIndex] == index)
                {
                    discCount--;
                    endsIndex++;
                }

                index = Math.Min(startsIndex < starts.Length ? starts[startsIndex] : long.MaxValue, endsIndex < ends.Length ? ends[endsIndex] : long.MaxValue);

                if (intersection > 10000000)
                    return -1;
            }

            return (int)intersection;
        }
    }
}
