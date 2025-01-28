using EMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.DTOs
{
	public class DepartmentDTO
	{
		public int DepartmentID { get; set; }
		public string DepartmentName { get; set; }
		public int? ManagerID { get; set; }
		public decimal Budget { get; set; }
		public DateTime CreatedAt { get; set; }

	}
}
