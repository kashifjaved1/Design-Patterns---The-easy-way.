using ThingsWithSingleton;

Singleton object1 = Singleton.GetInstance();
object1.Print("Hi! from object1");

Singleton object2 = Singleton.GetInstance();
object2.Print("Hi! from object2");