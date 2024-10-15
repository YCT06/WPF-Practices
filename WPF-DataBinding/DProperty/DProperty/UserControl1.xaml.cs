using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DProperty
{
	/// <summary>
	/// UserControl1.xaml 的互動邏輯
	/// </summary>
	public partial class UserControl1 : UserControl
	{
		public UserControl1()
		{
			InitializeComponent();
		}

		//public double MyUserValue { get; set; }
		public static readonly DependencyProperty MyUserValueProperty = DependencyProperty.Register(
		nameof(MyUserValue),
		typeof(double),
		typeof(UserControl1),
		new PropertyMetadata());
		public double MyUserValue
		{
			get => (double)GetValue(MyUserValueProperty);
			set => SetValue(MyUserValueProperty, value);
		}
	}
}
