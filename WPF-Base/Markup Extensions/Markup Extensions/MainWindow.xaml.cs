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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Markup_Extensions
{
	/// <summary>
	/// MainWindow.xaml 的互動邏輯
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
	}

	[MarkupExtensionReturnType(typeof(Style))]
	public class MergeStyle : MarkupExtension
	{
		public Style BasedOn { get; set; }
		public Style MergeWith { get; set; }

		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			return MergeWithStyle(BasedOn, MergeWith);
		}

		private static Style MergeWithStyle(Style style, Style mergeStyle)
		{
			if (mergeStyle.BasedOn != null)
				MergeWithStyle(style, mergeStyle.BasedOn);

			foreach (var setter in mergeStyle.Setters)
				style.Setters.Add(setter);

			foreach (var trigger in mergeStyle.Triggers)
				style.Triggers.Add(trigger);

			return style;
		}
	}
}
