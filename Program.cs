using System;
using System.Collections.Generic;

namespace ej
{
    class Program
    {
        static void Main(string[] args)
        
        {  
            List<int> multiplos = new List<int>();
            Console.WriteLine("Indique un número");
            int m = Convert.ToInt16(Console.ReadLine());
            for (int i=1; m >= multiplos.Count; i++)
            
            {
                if (i % 3 ==0)
                {
                if (i % 5 != 0)
                {
                    multiplos.Add(i);
                }
                }
            }
            foreach(var num in multiplos)
            {
                Console.WriteLine("{0}",num);
            }



        }
    }
}
