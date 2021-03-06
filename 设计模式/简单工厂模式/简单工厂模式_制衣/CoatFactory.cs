﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式_制衣
{
	internal class CoatFactory
	{
		public static Coat CreateCoat(string coatType)
		{
			Coat coat = null;
			switch (coatType)
			{
				case "Business":
					coat = new BusinessCoat();
					break;
				case "Casual":
					coat = new CasualCoat();
					break;
				default:
					break;
			}

			return coat;
		}
	}
}