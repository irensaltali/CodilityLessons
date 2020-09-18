using System;
using System.Collections.Generic;
using System.Linq;

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

        public int MissingInteger(int[] A)
        {
            bool[] ints = new bool[1000001];
            for(int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    ints[A[i]] = true;
                }
            }

            for (int i = 1; i < 1000001; i++)
            {
                if (!ints[i])
                    return i;
            }

            return 1;
        }

        public int PermCheck(int[] A)
        {
            if (A.Length != A.Distinct().Count())
                return 0;
            return A.Length == A.Max() ? 1 : 0;
        }
    }
}
