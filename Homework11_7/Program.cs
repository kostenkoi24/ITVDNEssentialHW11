using System;

namespace Homework11_7
{

    


    class MyClass<T> where T : new()
    {
        static T FactoryMethod()
        {
            return new T();
        }

        public MyClass()
        {
            FactoryMethod();
        }
    }

    



    class Program
    {
        static void Main(string[] args)
        {
            /*
             Використовуючи Visual Studio, створіть проект 
            за шаблоном Console Application. Створіть узагальнений клас 
            MyClass, що містить статичний фабричний метод – T FacrotyMethod(), 
            який породжуватиме екземпляри типу, вказаного як параметр типу 
            (покажчика місця заповнення типом – Т). Яким має бути тип, що підставляється під T?
             */

            
            MyClass<int> myClassInt = new MyClass<int>();
            MyClass<char> myClassChar = new MyClass<char>();
            MyClass<bool> myClassBool = new MyClass<bool>();

            //MyClass<string> myClass1 = new MyClass<string>(); //error
            //Яким має бути тип, що підставляється під T - значимые типы.

            Console.WriteLine(myClassInt.GetType());
            Console.WriteLine(myClassChar.GetType());
            Console.WriteLine(myClassBool.GetType());

            Console.ReadKey();
        }
    }
}
