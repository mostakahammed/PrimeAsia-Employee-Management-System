using EMS.Domain.Entities;
using EMS.Domain.IRepositories.EntityRepositories;
using EMS.Infrastructure.DataContext;


namespace EMS.Infrastructure.Repositories.EntityRepositories
{
	public class EmployeeRepository: GenericRepository<Employee>, IEmployeeRepository
	{
		public EmployeeRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
