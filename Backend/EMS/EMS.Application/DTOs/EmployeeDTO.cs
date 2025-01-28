using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.DTOs
{
	public class EmployeeDTO
	{
		public int EmployeeID { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public int DepartmentID { get; set; }
		public string DepartmentName { get; set; }
		public string Position { get; set; }
		public DateTime JoiningDate { get; set; }
		public bool Status { get; set; }
		public DateTime CreatedAt { get; set; }
	}
}
