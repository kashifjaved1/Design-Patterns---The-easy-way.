using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ThingsWithSingleton
{
    public sealed class Singleton
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
    }
}
