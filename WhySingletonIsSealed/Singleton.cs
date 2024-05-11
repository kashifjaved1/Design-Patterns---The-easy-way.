using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ThingsWithSingleton
{
    //public class DrivedSingleton : Singleton // CSO122: 'Singleton.Singleton()' is inaccessible due to its protection level
    //{
    // DrivedSingleton class can't inherit from Singleton class as its having private constructor.
    //}

    //public sealed class Singleton
    public class Singleton
    {
        private static int counter = 0;
        private static Singleton Instance;

        //public static Singleton GetInstance
        //{
        //    get
        //    {
        //        if (Instance == null)
        //            Instance = new Singleton();

        //        return Instance;
        //    }
        //}

        public static Singleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
            }

            return Instance;
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine($"Counter: {counter}");
        }

        public void Print(string input)
        {
            Console.WriteLine(input);
        }


        public class DrivedSingleton : Singleton // Here Nested class "DrivedSingleton" can be inherit from Singleton class even its having private constructor is private because its a part of base class now. And sealing it will prevent inheritance even for nested classes.
        {

        }
    }
}
