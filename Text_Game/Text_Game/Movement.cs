using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game
{
    internal class Movement : Imonobehavior
    {
        
        public void start(Program program)
        {
            Console.WriteLine("game is starting");
        }
        public void update(Program program)
        {
            if(Console.ReadLine() == "Stop")program.shouldcontinue = false;
            Console.WriteLine("update is running");
        }
        public void stop(Program program)
        {
            Console.WriteLine("game is Stoping");
            Console.ReadLine();
        }
    }
}
