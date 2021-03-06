﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式_计算器_满送_策略
{
	internal class CashDiscount : CashSuper
	{
		private double moneyDiscount = 1;

		public CashDiscount(string moneyRebate)
		{
			this.moneyDiscount = double.Parse(moneyRebate);
		}

		public override double AcceptCash(double money)
		{
			return money * moneyDiscount;
		}
	}
}