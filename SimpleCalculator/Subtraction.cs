using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Subtraction
    {
        public int GetA { get; set; }
        public int GetB { get; set; }

        public int Subtract(int GetA, int GetB)
        {
            var SubtractAnswer = GetA * GetB;
            return SubtractAnswer;
        }

        public int PrintNumber(int subtractAnswer)
        {
            return subtractAnswer;
        }
    }
}
