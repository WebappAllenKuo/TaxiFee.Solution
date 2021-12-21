using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WA.TaxiFee.Site.Models.DTOs;

namespace WA.TaxiFee.Site.Models.Services
{
	public class TaxiFeeService
	{
		public RideResponse Calculate(RideDTO dto)
		{
			return new RideResponse {Fee=85 };
		}
	}
}