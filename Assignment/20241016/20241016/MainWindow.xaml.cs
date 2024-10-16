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

namespace _20241016
{
	/// <summary>
	/// MainWindow.xaml 的互動邏輯
	/// </summary>
	public partial class MainWindow : Window
	{
		public List<Station> Stations { get; set; }

		public MainWindow()
		{
			InitializeComponent();

			Stations = new List<Station>
			{
				new Station { StationID = "S001", StationName = "Station A", IsEquipError = false },
				new Station { StationID = "S002", StationName = "Station B", IsEquipError = true },
				new Station { StationID = "S003", StationName = "Station C", IsEquipError = false },
				new Station { StationID = "S004", StationName = "Station D", IsEquipError = true },
				new Station { StationID = "S005", StationName = "Station E", IsEquipError = false }
			};

			this.DataContext = this;
		}
	}
}
