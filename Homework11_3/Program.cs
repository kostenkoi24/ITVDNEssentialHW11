using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Homework11_3
{



    class MyDictionary<T> 
    {
        T[] dictionaryKeys;
        T[] dictionaryValues;
        int length;


        public int Length { get => length; }



        public void Add(T key, T value)
        {

            if (dictionaryKeys == null)
            {
                dictionaryKeys = new T[1];
                dictionaryValues = new T[dictionaryKeys.Length];
            }
            else
            {
                length = dictionaryKeys.Length;
                Array.Resize<T>(ref dictionaryKeys, length + 1);
                Array.Resize<T>(ref dictionaryValues, length + 1);
            }


            dictionaryKeys[length] = key;
            dictionaryValues[length] = value;
        }

        public T this [int index]
        {
            get
            {
                if (index < dictionaryValues.Length)
                {
                    return dictionaryValues[index];
                }
                else
                {
                    return default;
                }
                
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {


            MyDictionary<string> myDictionary = new MyDictionary<string>();


            myDictionary.Add("Akey", "Avalue");
            myDictionary.Add("Bkey", "Bvalue");


            Console.WriteLine(myDictionary.Length);

            Console.WriteLine(myDictionary[0]);
            Console.WriteLine(myDictionary[1]);
            Console.WriteLine(myDictionary[3]); //return default

            Console.ReadKey();

        }
    }
}
