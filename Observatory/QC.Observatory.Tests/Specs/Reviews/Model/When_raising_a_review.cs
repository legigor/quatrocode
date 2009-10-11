using QC.Observatory.Domain.Reviews;
using QC.Observatory.Tests.Specs.Reviews.Model.Stubs;
using QC.Observatory.Tests.Utils.Specs;
using NUnit.Framework;

namespace QC.Observatory.Tests.Specs.Reviews.Model
{
    public class When_raising_a_review : Spec
    {
        RaiseReviewHandler handler;
        ReviewsRepositoryStub reviewsRepository;

        protected override void InContextOf()
        {
            reviewsRepository = new ReviewsRepositoryStub();

            handler = new RaiseReviewHandler(reviewsRepository);
        }

        protected override void Perform()
        {
            handler.Process(new RaiseReviewMessage());
        }

        [Should]
        public void Should_create_a_blank_review()
        {
            reviewsRepository.Store.Count.Should().Be.GreaterThan(0);
        }
    }
}