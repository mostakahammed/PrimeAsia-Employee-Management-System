using EMS.Application.DTOs;
using EMS.Application.IServices.EntityServices;
using EMS.Application.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EMS.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DepartmentController : ControllerBase
	{
		private readonly IDepartmentService _departmentService;
		public DepartmentController(IDepartmentService departmentService)
		{
			_departmentService = departmentService;
		}

		// Get all departments
		[HttpGet]
		public async Task<IActionResult> GetAllDepartments()
		{
			var result = await _departmentService.GetAllDepartments();
			return StatusCode(result.StatusCode, result);
		}

		// Get department by ID
		[HttpGet("{id}")]
		public async Task<IActionResult> GetDepartmentById(int id)
		{
			var result = await _departmentService.GetDepartmentById(id);
			if (result == null)
				return NotFound(new Result<DepartmentDTO>
				{
					Success = false,
					Message = "Department not found",
					StatusCode = (int)HttpStatusCode.NotFound
				});

			return StatusCode((int)HttpStatusCode.OK, result);
		}

		// Add department
		[HttpPost]
		public async Task<IActionResult> AddDepartment([FromBody] DepartmentDTO departmentDTO)
		{
			if (departmentDTO == null)
			{
				return BadRequest(new Result<DepartmentDTO>
				{
					Success = false,
					Message = "Invalid department data",
					StatusCode = (int)HttpStatusCode.BadRequest
				});
			}

			var result = await _departmentService.AddDepartment(departmentDTO);
			return StatusCode(result.StatusCode, result);
		}

		// Update department
		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateDepartment(int id, [FromBody] DepartmentDTO departmentDTO)
		{
			if (departmentDTO == null)
			{
				return BadRequest(new Result<DepartmentDTO>
				{
					Success = false,
					Message = "Invalid department data",
					StatusCode = (int)HttpStatusCode.BadRequest
				});
			}

			var result = await _departmentService.UpdateDepartment(id, departmentDTO);
			if (result == null)
				return NotFound(new Result<DepartmentDTO>
				{
					Success = false,
					Message = "Department not found",
					StatusCode = (int)HttpStatusCode.NotFound
				});

			return StatusCode((int)HttpStatusCode.OK, result);
		}

		// Delete department
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteDepartment(int id)
		{
			var result = await _departmentService.DeleteDepartment(id);
			return StatusCode(result.StatusCode, result);
		}
	}
}
