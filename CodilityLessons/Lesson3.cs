using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
