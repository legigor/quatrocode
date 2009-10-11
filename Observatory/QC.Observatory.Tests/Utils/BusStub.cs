using System.Collections.Generic;
using QC.Observatory.Infrastructure;

namespace QC.Observatory.Tests.Utils
{
    public class BusStub : IBus
    {
        public IList<object> Messages = new List<object>();
        public void Publish(object message)
        {
            Messages.Add(message);
        }
    }
}