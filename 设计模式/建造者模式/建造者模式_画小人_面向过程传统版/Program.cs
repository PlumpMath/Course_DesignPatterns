﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 建造者模式_画小人_面向过程传统版
{
	internal static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}