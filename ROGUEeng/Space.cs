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
        public int[,] CreatField()
        {
            int a = 25;
            int b = 25;
            int[,] Field = new int[a, b];
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                {
                    Field[i, j] = 1;

                }
            return Field;

        }
        public void RenderSpace()
        {
            int[,] sp = CreatField();
            for (int i = 0; i < sp.GetLength(1); i++)
            {

                for (int j = 0; j < sp.GetLength(0); j++)
                {
                    Console.Write(sp[j, i]);
                }
                Console.WriteLine();
            }


        }

    }
}
