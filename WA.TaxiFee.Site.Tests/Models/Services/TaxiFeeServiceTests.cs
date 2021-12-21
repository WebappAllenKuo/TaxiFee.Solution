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
		const int dayHour = 8;
		const int nightHour = 23;

		[TestCase(1)]
		[TestCase(1500)]
		public void Calculate_日間基本距離_Returns85(int distance) {
			var dto = new RideDTO {Hour=dayHour, Distance=distance };
			var service = new TaxiFeeService();

			int expected = 85;

			var result = service.Calculate(dto);

			Assert.AreEqual(expected, result.Fee);
		}

		[TestCase(1501)]
		[TestCase(1750)]
		public void Calculate_日間跳一次_Returns90(int distance)
		{
			var dto = new RideDTO { Hour=dayHour, Distance=distance };
			var service = new TaxiFeeService();

			int expected = 90;

			var result = service.Calculate(dto);

			Assert.AreEqual(expected, result.Fee);
		}

		[TestCase(1751)]
		[TestCase(2000)]
		public void Calculate_日間跳2次_Returns95(int distance)
		{
			var dto = new RideDTO { Hour=dayHour, Distance=distance };
			var service = new TaxiFeeService();

			int expected = 95;

			var result = service.Calculate(dto);

			Assert.AreEqual(expected, result.Fee);
		}


		[TestCase(1)]
		[TestCase(1250)]
		public void Calculate_夜間基本距離_Returns85(int distance)
		{
			var dto = new RideDTO { Hour=nightHour, Distance=distance };
			var service = new TaxiFeeService();

			int expected = 85;

			var result = service.Calculate(dto);

			Assert.AreEqual(expected, result.Fee);
		}

		[TestCase(1251)]
		[TestCase(1450)]
		public void Calculate_夜間跳一次_Returns90(int distance)
		{
			var dto = new RideDTO { Hour=nightHour, Distance=distance };
			var service = new TaxiFeeService();

			int expected = 90;

			var result = service.Calculate(dto);

			Assert.AreEqual(expected, result.Fee);
		}

		[TestCase(1451)]
		[TestCase(1650)]
		public void Calculate_夜間跳2次_Returns95(int distance)
		{
			var dto = new RideDTO { Hour=nightHour, Distance=distance };
			var service = new TaxiFeeService();

			int expected = 95;

			var result = service.Calculate(dto);

			Assert.AreEqual(expected, result.Fee);
		}
	}
}
