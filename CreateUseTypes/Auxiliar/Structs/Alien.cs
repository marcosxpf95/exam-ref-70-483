using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateUseTypes.Auxiliar.Structs
{
    public struct Alien
    {
        public int X;
        public int Y;
        public int Lives;

        public Alien(int x, int y)
        {
            X = x;
            Y = y;
            Lives = 3;
        }
        public override string ToString()
        {
            return $"X: {X} Y: {Y} Lives: {Lives}";
        }
    }
}
