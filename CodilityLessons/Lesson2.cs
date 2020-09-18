using System.Collections.Generic;
using System.Linq;

namespace CodilityLessons
{
    public class Lesson2
    {
        public int[] CyclicRotation(int[] A, int K)
        {
            K %= A.Length;

            if (K == 0 || K == A.Length || A.Length == 0)
                return A;

            int[] tempArray = new int[K];

            for (int i = 0; i < K; i++)
            {
                tempArray[i] = A[A.Length - K + i];
            }

            for (int i = A.Length-K-1; i >=0; i--)
            {
                A[i + K] = A[i];
            }

            for (int i = 0; i < K; i++)
            {
                A[i] = tempArray[i];
            }

            return A;
        }

        public int OddOccurrencesInArray(int[] A)
        {
            var odds = new Dictionary<int, bool>();

            foreach(var a in A)
            {
                bool o;
                if(odds.TryGetValue(a, out o))
                {
                    odds[a] = !o;
                }
                else
                {
                    odds.Add(a, true);
                }
            }

            return odds.Where(x => x.Value == true).FirstOrDefault().Key;
        }
    }
}
