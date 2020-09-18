using System;
using System.Linq;

namespace CodilityLessons
{
    public class Lesson3
    {
        public int FrogJmp(int X, int Y, int D)
        {
            return (int)Math.Ceiling(((double)Y - X) / D);
        }

        public int PermMissingElem(int[] A)
        {
            bool[] existance = new bool[A.Length + 1];
            for (int i = 0; i < A.Length; i++)
            {
                existance[A[i] - 1] = true;
            }

            for (int i = 0; i < existance.Length; i++)
            {
                if (!existance[i])
                    return i + 1;
            }
            return 0;
        }

        public int TapeEquilibrium(int[] A)
        {
            if (A.Length == 2)
                return Math.Abs(A[0] - A[1]);

            int[] leftSums = new int[A.Length];

            leftSums[0] = A[0];
            for (int i = 1; i < A.Length - 1; i++)
            {
                leftSums[i] = leftSums[i - 1] + A[i];
            }

            int[] rightSums = new int[A.Length];

            rightSums[A.Length - 1] = A[A.Length - 1];
            for (int i = A.Length - 2; i >= 0; i--)
            {
                rightSums[i] = rightSums[i + 1] + A[i];
            }

            int[] differences = new int[A.Length - 1];
            for (int i = 0; i < differences.Length; i++)
            {
                differences[i] = Math.Abs(leftSums[i] - rightSums[i + 1]);
            }

            return differences.Min();
        }
    }
}
