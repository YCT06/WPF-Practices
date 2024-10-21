using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance
{
	public class MyClass : INotifyPropertyChanged
	{
		private double _myValue = 2.0;
		public double MyValue
		{
			get => _myValue;
			set
			{
				_myValue = value;
				OnPropertyChanged(nameof(MyValue));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

		}
	}
	public class MyDataContext
	{
		public MyClass MyClass { get; set; } = new MyClass();
	}
}
