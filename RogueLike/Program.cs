using System;
using ROGUEeng;
namespace RogueLike
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 25;
            Space sp = new Space(a, b);
            sp.RenderSpace();
        }
    }
}
