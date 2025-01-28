using EMS.Domain.Entities;
using EMS.Domain.IRepositories.EntityRepositories;
using EMS.Infrastructure.DataContext;

namespace EMS.Infrastructure.Repositories.EntityRepositories
{
	public class PerformanceReviewRepository: GenericRepository<PerformanceReview>, IPerformanceReviewRepository
	{
		public PerformanceReviewRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
