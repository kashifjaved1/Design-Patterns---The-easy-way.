using SingletonAndThread;

Parallel.Invoke
(
    () => HiFromThreadNonSafeObject1(),
    () => HiFromThreadNonSafeObject2()
);

Console.WriteLine("\n<-------------------------------------------------------> \n");

Parallel.Invoke
(
    () => HiFromThreadSafeObject1(),
    () => HiFromThreadSafeObject2()
);

void HiFromThreadNonSafeObject1()
{
    //ThreadNonsafeSingleton object1 = ThreadNonsafeSingleton.GetInstance;
    ThreadNonsafeSingleton object1 = ThreadNonsafeSingleton.GetInstance();
    object1.Print("Hi! from thread non-safe singleton object1");
}

void HiFromThreadNonSafeObject2()
{
    //ThreadNonsafeSingleton object2 = ThreadNonsafeSingleton.GetInstance;
    ThreadNonsafeSingleton object2 = ThreadNonsafeSingleton.GetInstance();
    object2.Print("Hi! from thread non-safe singleton object2");
}

void HiFromThreadSafeObject1()
{
    //ThreadSafeSingleton object1 = ThreadSafeSingleton.GetInstance;
    ThreadSafeSingleton object1 = ThreadSafeSingleton.GetInstance();
    object1.Print("Hi! from thread safe singleton object1");
}

void HiFromThreadSafeObject2()
{
    //ThreadSafeSingleton object2 = ThreadSafeSingleton.GetInstance;
    ThreadSafeSingleton object2 = ThreadSafeSingleton.GetInstance();
    object2.Print("Hi! from thread safe singleton object2");
}