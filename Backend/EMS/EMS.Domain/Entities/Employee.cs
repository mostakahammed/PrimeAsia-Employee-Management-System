using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Domain.Entities
{
	public class Employee
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int EmployeeID { get; set; }
		public string Name { get; set; } 
		public string Email { get; set; }
		public string Phone { get; set; } 
		public int DepartmentID { get; set; }
		public string Position { get; set; }
		public DateTime JoiningDate { get; set; }
		public bool Status { get; set; }
		public DateTime CreatedAt { get; set; } 

		// Navigation Properties
		public Department Department { get; set; }
		public ICollection<PerformanceReview> PerformanceReviews { get; set; }
	}
}
