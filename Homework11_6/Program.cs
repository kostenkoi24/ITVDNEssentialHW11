using System;
using System.Collections;

namespace Homework11_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //преобразование в object
            ArrayList list = new ArrayList();
            list.Add(0.999); 
            list.Add(2222); 
            list.AddRange(new string[] { "Hello", "world" });

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]); 
            }


            Console.ReadKey();
        }
    }
}
