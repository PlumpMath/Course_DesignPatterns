﻿using System;

namespace 策略模式_计算器_满送_工厂
{
	class CaculatorReturn : Caculator
	{
		private readonly double _priceCondition;
		private readonly double _priceReturn;

		public CaculatorReturn(double priceCondition, double priceReturn)
		{
			_priceCondition = priceCondition;
			_priceReturn = priceReturn;
		}

		public override double CaculatePrice(double originalPrice)
		{
			double result = originalPrice;

			if (originalPrice >= _priceCondition)
			{
				result = originalPrice - Math.Floor(originalPrice / _priceCondition) * _priceReturn;
			}
			return result;
		}
	}
}