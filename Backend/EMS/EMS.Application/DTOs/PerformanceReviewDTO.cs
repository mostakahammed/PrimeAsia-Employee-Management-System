using EMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.DTOs
{
	internal class PerformanceReviewDTO
	{
		public int PerformanceReviewID { get; set; }
		public int EmployeeID { get; set; }
		public string EmployeeName { get; set; }
		public DateTime ReviewDate { get; set; }
		public int ReviewScore { get; set; }
		public string ReviewNotes { get; set; }
		public DateTime CreatedAt { get; set; }

	}
}
