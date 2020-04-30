using CreateUseTypes.Auxiliar;
using CreateUseTypes.Auxiliar.Class;
using CreateUseTypes.Auxiliar.Enuns;
using CreateUseTypes.Auxiliar.ExtensionMethods;
using System;
using System.Collections.Generic;

namespace CreateUseTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2-1 Value and reference type
            /*Auxiliar.Structs.Store xs, ys;
            ys = new Auxiliar.Structs.Store();
            ys.Data = 99;
            xs = ys;
            xs.Data = 100;

            Console.WriteLine($"xStruct: {xs.Data}");
            Console.WriteLine($"yStruct: {ys.Data}");

            Auxiliar.Class.Store xc, yc;
            yc = new Auxiliar.Class.Store();
            yc.Data = 99;
            xc= yc;
            xc.Data = 100;
            Console.WriteLine($"xClass: {xc.Data}");
            Console.WriteLine($"yClass: {yc.Data}");*/
            #endregion

            #region 2-3 Creating Structure 
            /*Auxiliar.Structs.Alien a;
            a.X = 50;
            a.Y = 50;
            a.Lives = 3;

            Console.WriteLine($"{a.ToString()}");

            Auxiliar.Structs.Alien x = new Auxiliar.Structs.Alien(100, 100);
            Console.WriteLine($"{x.ToString()}");

            Auxiliar.Structs.Alien[] swarm = new Auxiliar.Structs.Alien[100];
            swarm[0] = x;
            Console.WriteLine($"swarm [0] {swarm[0].ToString()}");

            Console.ReadKey();*/
            #endregion

            #region 2-4 Creating an Enum            
            /*AlienState alienState = AlienState.Attacking;
            Console.WriteLine(alienState);

            Console.ReadKey();*/
            #endregion

            #region 2-5 Creating a reference 
            /*Auxiliar.Class.Alien x = new Auxiliar.Class.Alien(100, 100);
            Console.WriteLine($"{x}");

            Auxiliar.Class.Alien[] swarm = new Alien[100];

            for (int i = 0; i < swarm.Length; i++)
                swarm[i] = new Alien(0, 0);

            Console.WriteLine($"Swarm [0] {swarm[0]}");*/
            #endregion

            #region 2-6 Using generic types            
            /*MyStack<string> nameStack = new MyStack<string>();
            nameStack.Push("Mateus");
            nameStack.Push("Marcos");
            Console.WriteLine($"{nameStack.Pop()}");
            Console.WriteLine($"{nameStack.Pop()}");*/
            #endregion

            #region 2-12 Calling simple methods
            Auxiliar.Class.Alien x = new Auxiliar.Class.Alien(100, 100);
            /*Console.WriteLine($"{x}");

            if (x.RemoveLives(2))
                Console.WriteLine("Still alive");
            else
                Console.WriteLine("Alien Destroyed");

            Console.WriteLine($"{x}");*/
            #endregion

            #region 2-13 Extension Methods
            string text = @"O marcos é um cara muito legal,
                        O marcos é um cara muito legal,
                        O marcos é um cara muito legal,
                        O marcos é um cara muito legal";

            Console.WriteLine($"{text.LineCount()}");
            #endregion
        }
    }    
}
