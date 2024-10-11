using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Attached_Property
{
	public class HasText_Services
	{
		public static readonly DependencyProperty IsEnabledProperty = DependencyProperty.RegisterAttached(
	   "IsEnabled",
	   typeof(bool),
	   typeof(HasText_Services),
	   new PropertyMetadata(default(bool), OnIsEnabledChanged));

		private static void OnIsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var tb = d as TextBox;
			if ((bool)e.NewValue)
			{
				tb.TextChanged += Tb_TextChanged;
			}
			else
			{
				tb.TextChanged -= Tb_TextChanged;
			}
		}

		private static void Tb_TextChanged(object sender, TextChangedEventArgs e)
		{
			var tb = sender as TextBox;
			SetHasText(tb, !string.IsNullOrEmpty(tb.Text));
		}

		[AttachedPropertyBrowsableForType(typeof(TextBox))]
		public static bool GetIsEnabled(DependencyObject obj)
			=> (bool)obj.GetValue(IsEnabledProperty);
		public static void SetIsEnabled(DependencyObject obj, bool value)
			=> obj.SetValue(IsEnabledProperty, value);

		public static readonly DependencyProperty HasTextProperty = DependencyProperty.RegisterAttached(
			"HasText",
			typeof(bool),
			typeof(HasText_Services),
			new PropertyMetadata(default(bool)));

		[AttachedPropertyBrowsableForType(typeof(TextBox))]
		public static bool GetHasText(DependencyObject obj)
			=> (bool)obj.GetValue(HasTextProperty);
		public static void SetHasText(DependencyObject obj, bool value)
			=> obj.SetValue(HasTextProperty, value);
	}
}
