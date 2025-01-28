using EMS.Domain.Entities;
using EMS.Domain.IRepositories.EntityRepositories;
using EMS.Infrastructure.DataContext;

namespace EMS.Infrastructure.Repositories.EntityRepositories
{
	public class DepartmentRepository: GenericRepository<Department>, IDepartmentRepository
	{
		public DepartmentRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
