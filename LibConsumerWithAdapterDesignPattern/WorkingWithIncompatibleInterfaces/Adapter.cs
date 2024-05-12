using SomeExternalOrNugetLibrary.Interface;

namespace LibConsumerWithAdapterDesignPattern.WorkingWithIncompatibleInterfaces
{
    public class Adapter : IExpectedByTarget
    {
        public void DoSomeWork()
        {
            var adaptee = new Adaptee();
            adaptee.SomeLogicNeedToPassToTarget();
            Console.WriteLine("Hi! from adapter");
        }
    }
}
