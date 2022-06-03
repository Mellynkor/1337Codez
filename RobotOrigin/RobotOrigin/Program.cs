using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotOrigin
{
    internal class Program
    {
        static string moves = "UDDU";
        static void Main(string[] args)
        {
            JudgeCircle(moves);
            bool JudgeCircle(string moves)
            {

                int[] position = new int[2];

                for (int i = 0; i < moves.Length; i++)
                {
                    if (moves[i].Equals('U'))
                    {
                        position[0] += 1;
                    }
                    if (moves[i].Equals('D'))
                    {
                        position[0] -= 1;
                    }
                    if (moves[i].Equals('R'))
                    {
                        position[1] += 1;
                    }
                    if (moves[i].Equals('L'))
                    {
                        position[1] -= 1;
                    }    
                }
                if (position[0] == 0 && position[1] == 0)
                {
                    Console.WriteLine("T");
                    Console.ReadKey();
                    return true;
                    
                }
                else
                    Console.WriteLine("F");
                    Console.ReadKey();
                    return false;
                
            }

        }
    }
}
