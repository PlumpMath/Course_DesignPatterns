﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式_房产
{
	internal class SohoFactory : IFactory
	{
		public IVilla ProduceVilla()
		{
			return new SohoVilla();
		}

		public IApartment ProduceApartment()
		{
			return new SohoApartment();
		}
	}
}