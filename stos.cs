using System;
using System.Collections;


namespace stosig
{
    public class stos
    {
        public Stack liczby;
        public int min;
        
        public stos()
        {
            liczby = new Stack();
        }
        public void PeekMin()
        {
            if (liczby.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Stos jest pusty");

            }
            else
            {
                Console.Clear();
                Console.WriteLine("minimalna wartość w stosie to: " + min);
            }
        }
        public void Peek()
        {
            if (liczby.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Stos jest pusty");
                return;
            }

            int t = (int)liczby.Peek();
            Console.Clear();
            Console.WriteLine("Wartosc na szczycie stosu to: ");

            if (t < min)
            {
                Console.WriteLine(min);
            }
            else
                Console.WriteLine(t);
        }
        public void pop()
        {
            if (liczby.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Stos jest pusty");
                return ;
            }
            Console.Clear();
            Console.Write("wartosc na szczycie stosu usnieta: ");
            int t = (int)liczby.Pop();

            if (t < min)
            {
                Console.WriteLine(min);
                min = 2 * min - t;
            }
            else
                Console.WriteLine(t);
        }
        public void Push(int x)
        {
            if (liczby.Count == 0)
            {
                min = x;
                liczby.Push(x);
                Console.Clear();
                Console.WriteLine("Wartosc wlozona do stosu: " + x);
                
                return;
            }

            if (x < min)
            {
                liczby.Push(2 * x - min);
                min = x;
            }
            else
                liczby.Push(x);
            Console.Clear();
            Console.WriteLine("Wartosc wlozona do stosu: " + x);
        }
       
    }
    public class main
    {
        
        public static void Main(string[] args)
        {
          
            stos liczby = new stos();
        uy:
            
            Console.WriteLine("pop = o, push = p, peek = l, peekmin = k, wyjscie = q");
            if (Console.ReadKey().Key == ConsoleKey.O)
            {
                
                liczby.pop();
                goto uy;
            }
            if (Console.ReadKey().Key == ConsoleKey.P)
            {
                Console.WriteLine("wprowadz wartosc ktora chcesz wlozyc do stosu");
                int wartosc = Int32.Parse( Console.ReadLine());
                liczby.Push(wartosc);
                goto uy;  
            }
            if (Console.ReadKey().Key == ConsoleKey.L)
            {
                liczby.Peek();
                goto uy;
            }
            if (Console.ReadKey().Key == ConsoleKey.K)
            {
                liczby.PeekMin();
                goto uy;
            }
            if (Console.ReadKey().Key == ConsoleKey.Q)
            {
                Environment.Exit(0);
            }
        }
        public void CLEAR()
        {
            Console.Clear();
        }



    }
}
