using QC.Observatory.Domain.Reviews;
using QC.Observatory.Tests.Utils;
using QC.Observatory.Tests.Utils.Specs;
using NUnit.Framework;
using QC.Observatory.Web.Controllers.Reviews;

namespace QC.Observatory.Tests.Specs.Reviews.UI
{
    public class When_user_raises_a_review : Spec
    {
        ReviewsController controller;
        ReviewModel aReview;
        BusStub bus;

        protected override void InContextOf()
        {
            bus = new BusStub();
            controller = new ReviewsController(bus);
            
            aReview = new ReviewModel();
        }

        protected override void Perform()
        {
            controller.Raise(aReview);
        }

        [Should]
        public void Should_request_for_a_new_review_creation()
        {
            bus.Messages[0].Should().Be.AssignableFrom<RaiseReviewMessage>();
        }
    }
}