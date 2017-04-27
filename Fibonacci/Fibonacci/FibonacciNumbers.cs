using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class FibonacciNumbers

    {
        /// <summary>
        /// This function generates Fibonacci qeue of numbers from 0 to <param>numberOfElements</param>
        /// </summary>
        /// <param name="lastNum"></param>
        /// <param name="numberOfElements"></param>
        /// <returns></returns>
        public static System.Collections.Generic.IEnumerable<int> FibonacciNumbersGenerator(int lastNum, int numberOfElements)
        {
            if (lastNum != 0 || lastNum != 1)
                yield return -9999;
            int result=1;
            for (int i = 0; i < numberOfElements-1; i++)
            {
                if (i == 0)
                    yield return lastNum;
                if (i == 1)
                    yield return lastNum;
                else
                {
                    yield return result += lastNum;
                    lastNum = result - lastNum;
                }
            }
        }
    }
}
