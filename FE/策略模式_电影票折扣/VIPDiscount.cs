﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式_电影票折扣
{
	class VIPDiscount:Discount
	{
		public override void Caculate()
		{
			Console.WriteLine("原价打5折！并增加积分！");
		}
	}
}
