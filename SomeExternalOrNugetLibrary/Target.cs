using SomeExternalOrNugetLibrary.Interface;

namespace SomeExternalOrNugetLibrary
{
    public class Target
    {
        private readonly IExpectedByTarget expectedByTarget;

        public Target(IExpectedByTarget expectedByTargetInterface)
        {
            this.expectedByTarget = expectedByTargetInterface;
        }

        public void LetsDoSomeWorkWithExpectedInterface()
        {
            this.expectedByTarget.DoSomeWork();
        }
    }
}
