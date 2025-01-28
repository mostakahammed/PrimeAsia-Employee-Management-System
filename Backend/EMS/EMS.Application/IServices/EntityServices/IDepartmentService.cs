using EMS.Application.DTOs;
using EMS.Application.Utilities;
using EMS.Domain.Entities;


namespace EMS.Application.IServices.EntityServices
{
	public interface IDepartmentService
	{
		Task<Result<IEnumerable<DepartmentDTO>>> GetAllDepartments();
		Task<Result<DepartmentDTO>> GetDepartmentById(int id);
		Task<Result<DepartmentDTO>> AddDepartment(DepartmentDTO departmentDTO);
		Task<Result<DepartmentDTO>> UpdateDepartment(int id, DepartmentDTO departmentDTO);
		Task<Result<DepartmentDTO>> DeleteDepartment(int id);
	}
}
