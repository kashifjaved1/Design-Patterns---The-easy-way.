using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAndThread
{
    public sealed class ThreadSafeSingleton
    {
        private static int counter = 0;
        private static ThreadSafeSingleton Instance = null;
        private static readonly object lockObj = new object();

        //public static ThreadSafeSingleton GetInstance
        //{
        //    get
        //    {
        //        if (Instance is null)
        //        {
        //            lock (lockObj) // As lock statement is pretty expensive so that's why placed inside if statement to execute only when required with double-check locking: https://en.wikipedia.org/wiki/Double-checked_locking.
        //            {
        //                if (Instance is null)
        //                {
        //                    Instance = new ThreadSafeSingleton();
        //                }
        //            }
        //        }

        //        return Instance;
        //    }
        //}

        public static ThreadSafeSingleton GetInstance()
        {
            if (Instance is null)
            {
                lock (lockObj) // As lock statement is pretty expensive so that's why placed inside if statement to execute only when required with double-check locking: https://en.wikipedia.org/wiki/Double-checked_locking.
                {
                    if (Instance is null)
                    {
                        Instance = new ThreadSafeSingleton();
                    }
                }
            }

            return Instance;
        }

        private ThreadSafeSingleton()
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
