using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow
{
    class Program
    {      
        static void Main(string[] args)
        {


            #region off Listing 1-1 Parallel.Invoke in use
            /*
            Listing11ParallelInvoke();
            void Listing11ParallelInvoke()
            {
                Parallel.Invoke(() => Task1(), () => Task2());
                Console.WriteLine("Finished processing. Press a key to end.");
                Console.ReadKey();

                static void Task1()
                {
                    Console.WriteLine("Task 1 starting");
                    Thread.Sleep(2000);
                    Console.Write("Task 1 ending");
                }

                static void Task2()
                {
                    Console.WriteLine("Task 2 starting");
                    Thread.Sleep(1000);
                    Console.WriteLine("Task 2 ending");
                }
            }
            */
            #endregion (off)

            #region off Listing 1-2 ParallelForEach in use
            /*var items = Enumerable.Range(0, 500);

            Parallel.ForEach(items, item =>
            {
                WorkOnItem(item);
            });

            Console.Write("Finished processing. Press key to end");
            Console.ReadKey();

            static void WorkOnItem(object item)
            {
                Console.WriteLine("Started working on: " + item);
                Thread.Sleep(100);
                Console.WriteLine("Finished working on:" + item);
            }
            */
            #endregion

            #region off Listing 1-3 ParallelFOr in use
            /*
            var items = Enumerable.Range(0, 500).ToArray();

            Parallel.For(0, items.Length, i =>
            {
                WorkOnItem(items[i]);
            });

            static void WorkOnItem(object item)
            {
                Console.WriteLine("Started working on: " + item);
                Thread.Sleep(100);
                Console.WriteLine("Finished working on:" + item);
            }
            */
            #endregion

            #region off Listing 1-4 Managing a parallel for loop
            /*
            var items = Enumerable.Range(0, 500).ToArray();

            ParallelLoopResult result = Parallel.For(0, items.Count(), (int i, ParallelLoopState loopState) =>
            {
                if (i == 10)
                    loopState.Stop();

                WorkOnItem(items[i]);                
            });

            Console.WriteLine("Completed:" + result.IsCompleted);
            Console.WriteLine("Items " + result.LowestBreakIteration);

            Console.WriteLine("Finished processing. Press a key to end");
            Console.ReadKey();

            static void WorkOnItem(object item)
            {
                Console.WriteLine("Started working on: " + item);
                Thread.Sleep(100);
                Console.WriteLine("Finished working on:" + item);
            }
            */
            #endregion

            #region Parallel LINQ
            Governante[] governantes = new Governante[]
            {
                new Governante { Nome = "Mandeta", FimIsolamento = "Não sei" },
                new Governante { Nome = "Doria", FimIsolamento = "ão sei" },
                new Governante { Nome = "Lula", FimIsolamento = "Não sei" },
                new Governante { Nome = "Bolsonaro", FimIsolamento = "Não sei" },
            };

            #region Listing 1-5 A Parallel LINQ query
            bool resposta = false;

            while (resposta == false)
            {
                var result = from governante in governantes.AsParallel()
                             where governante.FimIsolamento != "Não sei"
                             select governante;

                if (result.Count() == 0)
                    Console.WriteLine("Nenhum sabe");
                else
                {
                    foreach (var person in result)
                        Console.WriteLine(person.Nome);
                    resposta = true;
                }                    
            }
            

            Console.WriteLine("Finisshed processing. Press a key to end");

            Console.ReadKey();
           
            #endregion
            #endregion


        }

    }
    class Governante
    {
        public string Nome { get; set; }
        public string FimIsolamento { get; set; }
    }
}
