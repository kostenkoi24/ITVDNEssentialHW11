using System;
using System.Collections;

namespace Homework11_4
{

    class MyArrayList : ArrayList
    {
        ArrayList arrayList;

        public MyArrayList()
        {
            arrayList = new ArrayList();
        }

        public void MyAdd(object value)
        {
            arrayList.Add(value);
        }

        public ArrayList ArrayList { get { return arrayList; } }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;


            MyArrayList myArrayList = new MyArrayList();

            myArrayList.MyAdd(2);
            myArrayList.MyAdd("jyjygjgyjy");


            
            // перебор значений
            foreach (object o in myArrayList.ArrayList)
            {
                Console.WriteLine(o);
            }


            Console.ReadKey();
        }
    }
}
