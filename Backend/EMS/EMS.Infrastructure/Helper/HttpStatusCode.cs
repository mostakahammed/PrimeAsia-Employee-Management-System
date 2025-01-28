using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Infrastructure.Helper
{
	internal class HttpStatusCode
	{
		public const int OK = 200;
		public const int BadRequest = 400;
		public const int NotFound = 404;
		public const int InternalServerError = 500;
		public const int Created = 201;
		public const int Unauthorized = 401;
		public const int Forbidden = 403;
	}
}
