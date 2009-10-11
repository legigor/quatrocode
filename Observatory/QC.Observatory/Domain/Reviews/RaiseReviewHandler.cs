using System.Diagnostics.Contracts;

namespace QC.Observatory.Domain.Reviews
{
    public class RaiseReviewHandler
    {
        readonly IReviewsRepository _repository;

        public RaiseReviewHandler(IReviewsRepository repository)
        {
            Contract.Requires(repository != null);

            _repository = repository;
        }

        public void Process(RaiseReviewMessage message)
        {
            Contract.Requires(message != null);

            _repository.Add(new Review());
        }
    }
}