using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Domain.Enum
{
	public enum StatusCode
	{
		OK =200,
		InternalServerError = 500,
		NotFound = 404,
		UserNotFound = 0,
		CarNotFound = 15


	}
}
