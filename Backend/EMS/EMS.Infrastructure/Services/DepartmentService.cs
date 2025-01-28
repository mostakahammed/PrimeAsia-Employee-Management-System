using EMS.Application.DTOs;
using EMS.Application.IServices.EntityServices;
using EMS.Application.Utilities;
using EMS.Domain.Entities;
using EMS.Domain.IRepositories.EntityRepositories;
using EMS.Infrastructure.Helper;


namespace EMS.Infrastructure.Services
{
	public class DepartmentService : IDepartmentService
	{
		private readonly IDepartmentRepository _departmentRepository;
		public DepartmentService(IDepartmentRepository departmentRepository)
		{
			_departmentRepository = departmentRepository;
		}

		// Get all departments
		public async Task<Result<IEnumerable<DepartmentDTO>>> GetAllDepartments()
		{
			try
			{
				var departments = await _departmentRepository.GetAllAsync();

				var departmentDTOs = departments.Select(d => new DepartmentDTO
				{
					DepartmentID = d.DepartmentID,
					DepartmentName = d.DepartmentName,
					ManagerID = d.ManagerID,
					Budget = d.Budget,
					CreatedAt = d.CreatedAt
				});

				return Result<IEnumerable<DepartmentDTO>>.SuccessResult(departmentDTOs, (int)HttpStatusCode.OK, "Departments retrieved successfully");
			}
			catch (Exception ex)
			{
				return Result<IEnumerable<DepartmentDTO>>.FailureResult((int)HttpStatusCode.InternalServerError, ex.Message);
			}
		}

		// Get department by ID
		public async Task<Result<DepartmentDTO>> GetDepartmentById(int id)
		{
			try
			{
				var department = await _departmentRepository.GetByIdAsync(id);
				if (department == null)
				{
					return Result<DepartmentDTO>.FailureResult((int)HttpStatusCode.NotFound, "Department not found");
				}

				var departmentDTO = new DepartmentDTO
				{
					DepartmentID = department.DepartmentID,
					DepartmentName = department.DepartmentName,
					ManagerID = department.ManagerID,
					Budget = department.Budget,
					CreatedAt = department.CreatedAt
				};

				return Result<DepartmentDTO>.SuccessResult(departmentDTO, (int)HttpStatusCode.OK, "Department retrieved successfully");
			}
			catch (Exception ex)
			{
				return Result<DepartmentDTO>.FailureResult((int)HttpStatusCode.InternalServerError, ex.Message);
			}
		}


		public async Task<Result<DepartmentDTO>> AddDepartment(DepartmentDTO departmentDTO)
		{
			try
			{
				var department = new Department
				{
					DepartmentID = departmentDTO.DepartmentID,
					DepartmentName = departmentDTO.DepartmentName,
					ManagerID = departmentDTO.ManagerID,
					Budget = departmentDTO.Budget,
					CreatedAt = departmentDTO.CreatedAt
				};
				bool isSuccess = await _departmentRepository.AddAsync(department);
				if (!isSuccess)
				{
					return Result<DepartmentDTO>.FailureResult((int)HttpStatusCode.InternalServerError, "Failed to add department");
				}
				return Result<DepartmentDTO>.SuccessResult(departmentDTO, (int)HttpStatusCode.Created);
			}
			catch (Exception ex)
			{
				return Result<DepartmentDTO>.FailureResult((int)HttpStatusCode.InternalServerError, ex.Message);
			}
		}

		// Update department
		public async Task<Result<DepartmentDTO>> UpdateDepartment(int id, DepartmentDTO departmentDTO)
		{
			try
			{
				var department = await _departmentRepository.GetByIdAsync(id);
				if (department == null)
				{
					return Result<DepartmentDTO>.FailureResult((int)HttpStatusCode.NotFound, "Department not found");
				}

				department.DepartmentName = departmentDTO.DepartmentName;
				department.ManagerID = departmentDTO.ManagerID;
				department.Budget = departmentDTO.Budget;

				bool isSuccess = await _departmentRepository.UpdateAsync(department);
				if (!isSuccess)
				{
					return Result<DepartmentDTO>.FailureResult((int)HttpStatusCode.InternalServerError, "Failed to update department");
				}

				var updatedDepartmentDTO = new DepartmentDTO
				{
					DepartmentID = department.DepartmentID,
					DepartmentName = department.DepartmentName,
					ManagerID = department.ManagerID,
					Budget = department.Budget,
					CreatedAt = department.CreatedAt
				};

				return Result<DepartmentDTO>.SuccessResult(updatedDepartmentDTO, (int)HttpStatusCode.OK, "Department updated successfully");
			}
			catch (Exception ex)
			{
				return Result<DepartmentDTO>.FailureResult((int)HttpStatusCode.InternalServerError, ex.Message);
			}
		}

		// Delete department
		public async Task<Result<DepartmentDTO>> DeleteDepartment(int id)
		{
			try
			{
				var department = await _departmentRepository.GetByIdAsync(id);
				if (department == null)
				{
					return Result<DepartmentDTO>.FailureResult((int)HttpStatusCode.NotFound, "Department not found");
				}

				bool isSuccess = await _departmentRepository.DeleteAsync(department);
				if (!isSuccess)
				{
					return Result<DepartmentDTO>.FailureResult((int)HttpStatusCode.InternalServerError, "Failed to delete department");
				}

				return Result<DepartmentDTO>.SuccessResult(null, (int)HttpStatusCode.OK, "Department deleted successfully");
			}
			catch (Exception ex)
			{
				return Result<DepartmentDTO>.FailureResult((int)HttpStatusCode.InternalServerError, ex.Message);
			}
		}


	}
}
