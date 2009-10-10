using NUnit.Framework;

namespace QC.Observatory.Tests.Utils.Specs
{
    [TestFixture]
    public abstract class Spec
    {
        [SetUp]
        public void SetUp()
        {
            InContextOf();
            Perform();
        }

        protected abstract void InContextOf();
        protected abstract void Perform();
    }
}