using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Game
{
    interface Imonobehavior
    {
        void start(Program program);
        void update(Program program);
        void stop(Program program);
    }
}
