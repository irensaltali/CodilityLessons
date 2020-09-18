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

    }
}
