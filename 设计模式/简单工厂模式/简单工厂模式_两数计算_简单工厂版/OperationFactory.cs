﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式_两数计算_简单工厂版
{
	class OperationFactory
	{
		public static Operation CreateOperation(string oper)
		{
			Operation operation = null;
			switch (oper)
			{
				case "+":
					operation = new OperationAdd();
					break;
				case "-":
					operation = new OperationSub();
					break;
				case "*":
					operation = new OperationMul();
					break;
				case "/":
					operation = new OperationDiv();
					break;
			}
			return operation;
		}
	}
}