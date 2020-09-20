namespace CodilityLessons
{
    public class Lesson5
    {
        public int CountDiv(int A, int B, int K)
        {
            int start = A;
            if (A % K != 0)
                start = A + (K - A % K);
            int end = B;
            if (B % K != 0)
                end = B - (B % K);
            return (end - start) / K + 1;
        }

        //This ones complexity is O(N*M) and didn't pass due to time limit.
        public int[] GenomicRangeQuery(string S, int[] P, int[] Q)
        {
            int[] r = new int[P.Length];
            int factor;
            for (int i = 0; i < P.Length; i++)
            {
                int min = NucleotToFactor(S[P[i]]);
                for (int j = P[i] + 1; j <= Q[i] && min > 1; j++)
                {
                    factor = NucleotToFactor(S[j]);
                    if (factor < min)
                        min = factor;
                }
                r[i] = min;
            }


            return r;
        }

        //This ones complexity is also O(N*M),  better in performance but still didn't pass due to time limit.
        public int[] GenomicRangeQuery2(string S, int[] P, int[] Q)
        {
            int[] s = new int[S.Length];
            char c;
            for (int i = 0; i < S.Length; i++)
            {
                c = S[i];
                if (c == 'A')
                    s[i] = 1;
                else if (c == 'C')
                    s[i] = 2;
                else if (c == 'G')
                    s[i] = 3;
                else
                    s[i] = 4;
            }

            int[] r = new int[P.Length];
            for (int i = 0; i < P.Length; i++)
            {
                int min = s[P[i]];
                for (int j = P[i] + 1; j <= Q[i] && min > 1; j++)
                {
                    if (s[j] < min)
                        min = s[j];
                }
                r[i] = min;
            }

            return r;
        }

        //This ones complexity is also O(N+M) and passes all tests.
        public int[] GenomicRangeQuery3(string S, int[] P, int[] Q)
        {
            int[,] s = new int[S.Length,2];
            char c;
            int factor;
            for (int i = S.Length-1; i >=0; i--)
            {
                c = S[i];
                if (c == 'A')
                    factor = 1;
                else if (c == 'C')
                    factor = 2;
                else if (c == 'G')
                    factor = 3;
                else
                    factor = 4;

                s[i, 0] = factor;
                if (i < S.Length - 1 && s[i + 1, 0] == factor)
                    s[i, 1] = s[i + 1, 1] + 1;
                else
                    s[i, 1] = 1;

            }

            int[] r = new int[P.Length];

            for (int i = 0; i < P.Length; i++)
            {
                int min =5;
                for (int j = P[i]; j <= Q[i] && min > 1; j+= s[j, 1])
                {
                    if (s[j,0] < min)
                        min = s[j,0];
                }
                r[i] = min;
            }

            return r;
        }
        private int NucleotToFactor(char c)
        {
            if (c == 'A')
                return 1;
            else if (c == 'C')
                return 2;
            else if (c == 'G')
                return 3;
            else if (c == 'T')
                return 4;
            else
                return -1;
        }

        public int MinAvgTwoSlice(int[] A)
        {
            int window = 2;
            int minPosition = -1;
            double min = int.MaxValue;
            double currentMin = double.MaxValue;
            int currentMinPosition = -1;

            while (window<=A.Length)
            {
                for (int i = 0; i <= A.Length - window; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < window; j++)
                    {
                        sum += A[i + j];
                    }
                    
                    if ((double)sum/window < currentMin)
                    {
                        currentMin = (double)sum / window;
                        currentMinPosition = i;
                    }
                }

                if (currentMin < min)
                {
                    min = currentMin;
                    minPosition = currentMinPosition;
                }
                else
                    break;

                window++;
            }

                return minPosition;
        }

        public int PassingCars(int[] A)
        {
            int numberOfEast = 0;
            int passing = 0;
            for(int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                    numberOfEast++;
                else
                    passing += numberOfEast;

                if (passing > 1000000000)
                    return -1;
            }

            return passing;
        }
    }
}
