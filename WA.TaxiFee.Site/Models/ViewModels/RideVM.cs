using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WA.TaxiFee.Site.Models.ViewModels
{
	public class RideVM
	{
		[Display(Name ="上車時間")]
		[Range(0,23, ErrorMessage ="{0} 必需介於 {1} ~ {2}")]
		public int Hour { get; set; }

		[Display(Name = "搭乘距離(公尺)")]
		[Range(0, 300000, ErrorMessage = "{0} 必需介於 {1} ~ {2}")]
		public int Distance { get; set; }
	}
}