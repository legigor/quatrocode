using System.Diagnostics.Contracts;
using QC.Observatory.Domain.Reviews;
using QC.Observatory.Infrastructure;

namespace QC.Observatory.Web.Controllers.Reviews
{
    public class ReviewsController
    {
        readonly IBus _bus;

        public ReviewsController(IBus bus)
        {
            Contract.Requires(_bus != null);

            _bus = bus;
        }

        public void Raise(ReviewModel review)
        {
            _bus.Publish(new RaiseReviewMessage());
        }
    }
}