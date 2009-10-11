using System.Collections.Generic;
using QC.Observatory.Domain.Reviews;

namespace QC.Observatory.Tests.Specs.Reviews.Model.Stubs
{
    public class ReviewsRepositoryStub : IReviewsRepository
    {
        public IList<Review> Store = new List<Review>();
        public void Add(Review review)
        {
            Store.Add(review);
        }
    }
}