using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WA.TaxiFee.Site.Models.DTOs;
using WA.TaxiFee.Site.Models.Services;

namespace WA.TaxiFee.Site.Tests.Models.Services
{
	internal class TaxiFeeServiceTests
	{
		[Test]
		public void Calculate_日間基本距離_Returns85() {
			var dto = new RideDTO {Hour=8, Distance=1 };
			var service = new TaxiFeeService();

			int expected = 85;

			var result = service.Calculate(dto);

			Assert.AreEqual(expected, result.Fee);

		}
	}
}
