using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAndThread
{
    public sealed class ThreadNonsafeSingleton
    {
        private static int counter = 0;
        private static ThreadNonsafeSingleton Instance = null;

        //public static ThreadNonsafeSingleton GetInstance
        //{
        //    get
        //    {
        //        if (Instance is null)
        //            Instance = new ThreadNonsafeSingleton();

        //        return Instance;
        //    }
        //}

        public static ThreadNonsafeSingleton GetInstance()
        {
            if (Instance is null)
            {
                Instance = new ThreadNonsafeSingleton();
            }

            return Instance;
        }

        private ThreadNonsafeSingleton()
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
