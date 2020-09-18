using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLessons
{
    public class Lesson4
    {
        public int[] MaxCounters(int N, int[] A)
        {
            int max = 0;
            int sumMax = 0;
            int[] counters = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == N + 1)
                {
                    if (max > 0)
                    {
                        Array.Clear(counters, 0, counters.Length);
                        sumMax += max;
                        max = 0;
                    }
                }
                else
                {
                    counters[A[i] - 1]++;
                    if (counters[A[i] - 1] > max)
                    {
                        max = counters[A[i] - 1];
                    }
                }
            }
            Console.WriteLine("sumMax:" + sumMax);
            for (int i = 0; i < counters.Length; i++)
            {
                counters[i] += sumMax;
            }

            return counters;
        }

        public int FrogRiverOne(int X, int[] A)
        {
            Dictionary<int,bool> dropedLeaves = new Dictionary<int, bool>();

            for(int i = 0; i < A.Length; i++)
            {
                if (A[i] == X)
                {
                    while (dropedLeaves.Count != X-1)
                    {
                        i++;
                        if (i == A.Length)
                            return -1;
                        if (A[i] != X &&!dropedLeaves.ContainsKey(A[i]))
                        {
                            dropedLeaves.Add(A[i], true);
                        }
                    }
                    return i;
                }
                else
                {
                    if(!dropedLeaves.ContainsKey(A[i]))
                    {
                        dropedLeaves.Add(A[i], true);
                    }
                }
            }
            return -1;
        }
    }
}
