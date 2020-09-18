using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLessons
{
    public class Lesson1
    {
        public int BinaryGap(int N)
        {
            var b = Convert.ToString(N, 2);
            int i = 0;
            int temp = 0;
            bool inn = false;
            foreach (var c in b)
            {
                if (!inn && c == '1')
                {
                    inn = true;
                }
                else if (inn && c == '0')
                {
                    temp++;
                }
                else if (inn && c == '1')
                {
                    if (i < temp)
                        i = temp;
                    temp = 0;
                }
            }
            return i;
        }
    }
}
