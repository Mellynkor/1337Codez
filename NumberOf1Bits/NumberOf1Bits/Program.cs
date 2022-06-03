using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOf1Bits
{
    /*
     * This solution does not behave the same in VS and on LC website, not exactly sure why. But this is the correct solution that is accepted on LC.
     */
    internal class Program
    {
        static void Main(string[] args)
        {

             int HammingWeight(uint n)
            {

                var count = 0;
                for (int i = 0; i < 32; i++) // Uint input cannot be longer than 32 digits
                {
                    if (((n >> i) & 1) == 1) //If n input >> (bitwise right-shift))  & (I assume) the bit = 1, then
                    {
                        count++; //Increment count by 1
                    }
                }
                return count;

            }
        }
    }
}
