﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 迭代器模式_正反序
{
	internal class Aggregate
	{
		protected readonly IList<object> Items = new List<object>();

		public int Count
		{
			get
			{
				return Items.Count;
			}
		}

		public object this[int index]
		{
			get
			{
				return Items[index];
			}

			set
			{
				Items.Insert(index, value);
			}
		}
	}
}