using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Source
{
	/// <summary>
	/// MainWindow.xaml 的互動邏輯
	/// </summary>
	public partial class MainWindow : Window
	{
		public ObservableCollection<Person> People { get; set; }

		public MainWindow()
		{
			InitializeComponent();

			// 初始化資料
			People = new ObservableCollection<Person>
			{
				new Person { Name = "Alice", Age = 30 },
				new Person { Name = "Bob", Age = 25 },
				new Person { Name = "Charlie", Age = 35 },
				new Person { Name = "Diana", Age = 28 }
			};

			// 設置 DataContext
			DataContext = this;
		}
	}

	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}
}
