using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateUseTypes.Auxiliar.Class
{
    public class Alien
    {
        public static int Max_Lives = 99;

        public int X;
        public int Y;
        public int Lives;

        //alien code here
        static Alien()
        {
            Console.WriteLine("Static alien constructor running.");
        }

        //2-8 Overloaded constructors
        public Alien(int x, int y, int lives)
        {
            if (x < 0 || y < 0)
                throw new Exception("Invalid position");

            if (lives > Max_Lives)
                throw new Exception("Invalid lives");

            X = x;
            Y = y;
            Lives = lives;
        }
        //2-7 Constructors using 2-9 Calling Constructor
        public Alien(int x, int y) : this(x, y, 3)
        {                       
        }

        //2-12 Simple Method
        public bool RemoveLives(int livesToRemove)
        {
            Lives = Lives - livesToRemove;

            if(Lives <= 0)
            {
                Lives = 0;
                X = -1000;
                Y = -1000;
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            return $"X: {X} Y: {Y} Lives: {Lives}";
        }
    }
}
