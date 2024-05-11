using SingletonWithEagerLoadingAndLazyLoading;

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
    //SingletonWithEagerLoading object1 = SingletonWithEagerLoading.GetInstance;
    SingletonWithEagerLoading object1 = SingletonWithEagerLoading.GetInstance();
    object1.Print("Hi! from eager loading singleton object1");
}

void HiFromThreadNonSafeObject2()
{
    //SingletonWithEagerLoading object2 = SingletonWithEagerLoading.GetInstance;
    SingletonWithEagerLoading object2 = SingletonWithEagerLoading.GetInstance();
    object2.Print("Hi! from eager loading singleton object2");
}

void HiFromThreadSafeObject1()
{
    //SingletonWithLazyLoading object1 = SingletonWithLazyLoading.GetInstance;
    SingletonWithLazyLoading object1 = SingletonWithLazyLoading.GetInstance();
    object1.Print("Hi! from lazy loading singleton object1");
}

void HiFromThreadSafeObject2()
{
    //SingletonWithLazyLoading object2 = SingletonWithLazyLoading.GetInstance;
    SingletonWithLazyLoading object2 = SingletonWithLazyLoading.GetInstance();
    object2.Print("Hi! from lazy loading singleton object2");
}