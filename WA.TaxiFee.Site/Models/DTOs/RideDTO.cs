using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using WA.TaxiFee.Site.Models.ViewModels;

namespace WA.TaxiFee.Site.Models.DTOs
{
	public class RideDTO
	{
		public int Hour { get; set; }
		public int Distance { get; set; }
	}

	public static class RideVMExts { 
		public static RideDTO ToDTO(this RideVM source)
		{
		return new RideDTO { Hour = source.Hour, Distance =source.Distance };
		}
	}
}