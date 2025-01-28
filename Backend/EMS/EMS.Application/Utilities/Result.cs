using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.Utilities
{
	public class Result<T>
	{
		public bool Success { get; set; }
		public string Message { get; set; }
		public int StatusCode { get; set; }
		public T Data { get; set; }

		public static Result<T> SuccessResult(T data, int statusCode, string message = "Operation Successfull")
		{
			return new Result<T>
			{
				Success = true,
				StatusCode = statusCode,
				Message = message,
				Data = data
			};
		}

		public static Result<T> SuccessResult(int statusCode, string message = "Operation Successful")
		{
			return new Result<T>
			{
				Success = true,
				StatusCode = statusCode,
				Message = message,
				Data = default
			};
		}

		public static Result<T> FailureResult( int statusCode, string message = "Operation Failed")
		{
			return new Result<T>
			{
				Success = false,
				StatusCode = statusCode,
				Message = message
			};
		}
	}
}
