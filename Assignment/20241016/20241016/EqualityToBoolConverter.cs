using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace _20241016
{
	public class EqualityToBoolConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			// 確保 value 是 Station 並且檢查 StationID 與 ConverterParameter 是否相等
			//return (value as Station)?.StationID == (string)parameter;
			return value != null && value.Equals(parameter);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			//if ((bool)value) // 如果 RadioButton 被選中
			//{
			//	// 取得當前的 ViewModel
			//	var viewModel = App.Current.MainWindow.DataContext as MainWindowViewModel;

			//	// 根據傳入的 StationID (parameter) 去 Stations 列表裡找對應的 Station 物件
			//	return viewModel?.Stations.FirstOrDefault(s => s.StationID == (string)parameter);
			//}

			//return Binding.DoNothing;
			return value != null && ((bool)value) ? parameter : Binding.DoNothing;
		}
	}
}
