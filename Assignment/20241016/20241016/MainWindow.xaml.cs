using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
		

		public MainWindow()
		{
			InitializeComponent();
		}
	}


	public class MainWindowViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		private string _selectedStation;

		public string SelectedStationID
		{
			get { return _selectedStation; }
			set
			{
				if (_selectedStation != value)
				{
					_selectedStation = value;
					OnPropertyChanged(nameof(SelectedStationID));
				}
			}
		}
		public Station SelectedStation { get; set; }

		public List<Station> Stations { get; set; }

		public MainWindowViewModel()
		{
			Stations = new List<Station>
			{
			new Station { StationID = "S001", StationName = "Station A", IsEquipError = false },
			new Station { StationID = "S002", StationName = "Station B", IsEquipError = true },
			new Station { StationID = "S003", StationName = "Station C", IsEquipError = false },
			new Station { StationID = "S004", StationName = "Station D", IsEquipError = true },
			new Station { StationID = "S005", StationName = "Station E", IsEquipError = false }
			};
			SelectedStationID = "S001";
			SelectedStation = new Station(Stations.First());
		}
	}
}
