using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonWithEagerLoadingAndLazyLoading
{
    public sealed class SingletonWithLazyLoading
    {
        private static int counter = 0;
        private static readonly Lazy<SingletonWithLazyLoading> Instance = new(() => new SingletonWithLazyLoading());

        private SingletonWithLazyLoading()
        {
            counter++;
            Console.WriteLine($"Counter: {counter}");
        }

        //public static SingletonWithLazyLoading GetInstance
        //{
        //    return Instance.Value;
        //}

        public static SingletonWithLazyLoading GetInstance()
        {
            return Instance.Value;
        }

        public void Print(string input)
        {
            Console.WriteLine(input);
        }
    }
}
