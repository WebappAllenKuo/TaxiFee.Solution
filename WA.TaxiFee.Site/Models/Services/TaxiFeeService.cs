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
			if (IsDay(dto.Hour))
			{
				return CalcDay(dto);
			}
			else {
				return CalcNight(dto);
			}
		}

		private RideResponse CalcDay(RideDTO dto)
		{
			const int basicFee = 85;
			const int basicDistance = 1500;

			int fee = basicFee;
			if (dto.Distance > basicDistance) {
				// 加錢
				fee += (int)Math.Ceiling((dto.Distance - basicDistance)/250.0) * 5;
			}

			return new RideResponse { Hour=dto.Hour, Distance = dto.Distance, Fee=fee, ChargeType=ChargeType.Day };
		}

		private RideResponse CalcNight(RideDTO dto)
		{
			const int basicFee = 85;
			const int basicDistance = 1250;

			int fee = basicFee;
			if (dto.Distance > basicDistance)
			{
				// 加錢
				fee += (int)Math.Ceiling((dto.Distance - basicDistance)/200.0) * 5;
			}

			return new RideResponse { Hour=dto.Hour, Distance = dto.Distance, Fee=fee, ChargeType=ChargeType.Night };
		}
		private bool IsDay(int hour)
		{
			return hour >=7 && hour <=22;
		}
	}
}