using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WA.TaxiFee.Site.Models.Services
{
	public class RideResponse
	{
		public int Hour { get; set; }
		public int Distance { get; set; }
		public int Fee { get; set; }

		public ChargeType ChargeType { get; set; }
	}

	public enum ChargeType { 
		Day =1, 
		Night=2
	}
}