using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Text_Game
{
    internal class Program 
    {
       
        

        public bool shouldcontinue = true;
        static void Main(string[] args)
        {

            //https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-write-user-settings-at-run-time-with-csharp?view=netframeworkdesktop-4.8&redirectedfrom=MSDN

            // game loop(todo)
            // render 
            // input
            // update
            Render.update();
            Console.ReadLine();
        }
    }
}
