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
			const double unitDistance = 250.0;

			int fee = GetFee(basicFee, basicDistance, unitDistance, dto.Distance);

			return new RideResponse { Hour=dto.Hour, Distance = dto.Distance, Fee=fee, ChargeType=ChargeType.Day };
		}

		private int GetFee(int basicFee, int basicDistance, double unitDistance, int distance)
		{
			int fee = basicFee;
			if (distance > basicDistance)
			{
				fee += (int)Math.Ceiling((distance - basicDistance)/unitDistance) * 5;
			}
			return fee;
		}

		private RideResponse CalcNight(RideDTO dto)
		{
			const int basicFee = 85;
			const int basicDistance = 1250;
			const double unitDistance = 200.0;

			int fee = GetFee(basicFee, basicDistance, unitDistance, dto.Distance);

			return new RideResponse { Hour=dto.Hour, Distance = dto.Distance, Fee=fee, ChargeType=ChargeType.Night };
		}
		private bool IsDay(int hour)
		{
			return hour >=7 && hour <=22;
		}
	}
}