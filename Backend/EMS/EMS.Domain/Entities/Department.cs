using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Domain.Entities
{
	[Table("Department")]
	public class Department
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int DepartmentID { get; set; } 
		public string DepartmentName { get; set; }
		public int? ManagerID { get; set; }
		public decimal Budget { get; set; } 
		public DateTime CreatedAt { get; set; }

		// Navigation Properties
		[NotMapped]
		public Employee Manager { get; set; }
		[NotMapped] 
		
		public ICollection<Employee> Employees { get; set; } 
	}
}
