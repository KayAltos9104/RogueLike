using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROGUEeng
{
   public class Space
    {


        internal int[,] _space;

        public Space(int length, int width)
        {
            
            _space = new int[length, width];
        }

    }
}
