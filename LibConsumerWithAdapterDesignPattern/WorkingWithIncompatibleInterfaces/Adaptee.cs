namespace LibConsumerWithAdapterDesignPattern.WorkingWithIncompatibleInterfaces
{
    public class Adaptee
    {
        public void SomeLogicNeedToPassToTarget()
        {
            Console.WriteLine("This is from adaptee");
        }
    }
}
