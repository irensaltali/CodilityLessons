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
    }
}
