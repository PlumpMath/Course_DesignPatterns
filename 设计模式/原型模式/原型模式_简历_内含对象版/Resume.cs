﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式_简历_内含对象版
{
	internal class Resume : ICloneable
	{
		private string _name;

		private string _sex;

		private string _age;

		private WorkExperience _work;

		public Resume(string name)
		{
			this._name = name;
			_work = new WorkExperience();
		}

		public void SetPersonalInfo(string sex, string age)
		{
			this._sex = sex;
			this._age = age;
		}

		public void SetWorkExperience(string timeArea, string company)
		{
			this._work.TimeArea = timeArea;
			this._work.Company = company;
		}

		public void Display()
		{
			Console.WriteLine("{0} {1} {2}", _name, _sex, _age);
			Console.WriteLine("工作经历：{0} {1}", _work.TimeArea, _work.Company);
			Console.WriteLine();
		}

		public object Clone()
		{
			return this.MemberwiseClone();
		}
	}
}