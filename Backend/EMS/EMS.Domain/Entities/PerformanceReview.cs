using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Domain.Entities
{
	public class PerformanceReview
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int PerformanceReviewID { get; set; }
		public int EmployeeID { get; set; }
		public DateTime ReviewDate { get; set; }
		public int ReviewScore { get; set; } 
		public string ReviewNotes { get; set; } 
		public DateTime CreatedAt { get; set; }

		// Navigation Property
		public Employee Employee { get; set; }
	}
}
