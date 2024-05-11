using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonWithEagerLoadingAndLazyLoading
{
    public sealed class SingletonWithEagerLoading
    {
        private static int counter = 0;
        private static readonly SingletonWithEagerLoading Instance = new(); // By making it readonly now its initialization and thread safety.

        //public static SingletonWithEagerLoading GetInstance
        //{
        //    get
        //    {
        //        return Instance;
        //    }
        //}

        public static SingletonWithEagerLoading GetInstance()
        {
            return Instance;
        }

        private SingletonWithEagerLoading()
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
