﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_画小人_建造者模式版
{
	internal class PersonDirector
	{
		private PersonBuilder _pb;

		public PersonDirector(PersonBuilder pb)
		{
			_pb = pb;
		}

		public void CreatePerson()
		{
			_pb.BuildHead();
			_pb.BuildBody();
			_pb.BuildArmLeft();
			_pb.BuildArmRight();
			_pb.BuildLegLeft();
			_pb.BuildLegRight();
		}
	}
}