﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DProperty
{
	public class MyDataContext
	{
		private double _myValue = 123.45;
		public double MyValue
		{
			get => _myValue;
			set
			{
				_myValue = value;
			}
		}
	}
}
