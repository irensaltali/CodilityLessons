using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLessons
{
    public class Lesson5
    {
        public int CountDiv(int A, int B, int K)
        {
            int start = A;
            if(A % K!=0)
                start = A + (K - A % K);
            int end = B;
            if(B % K !=0)
                end = B - (B % K);
            return (end-start)/K+1;
        }
    }
}
