﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂方法模式_两数计算
{
	class Operation
	{
		public double NumberA
		{
			get; set;
		}

		public double NumberB
		{
			get; set;
		}

		public virtual double GetResult()
		{
			double result = 0;
			return result;
		}
	}
}