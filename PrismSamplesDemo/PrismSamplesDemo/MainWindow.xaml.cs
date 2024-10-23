using Prism.Ioc;
using Prism.Regions;
using PrismSamplesDemo.View;
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

namespace PrismSamplesDemo
{
	/// <summary>
	/// MainWindow.xaml 的互動邏輯
	/// </summary>
	public partial class MainWindow : Window
	{
		IContainerExtension _container;
		IRegionManager _regionManager;
		IRegion _region;
		ViewA _viewA;
		ViewB _viewB;

		public MainWindow()
		{
			InitializeComponent();
		}

		public MainWindow(IContainerExtension container, IRegionManager regionManager)
		{
			InitializeComponent();
			_container = container;
			_regionManager = regionManager;
			this.Loaded += MainWindow_Loaded;
		}

		private void MainWindow_Loaded(object sender, RoutedEventArgs e)
		{
			_region = _regionManager.Regions["ContentRegion"];
			_viewA = _container.Resolve<ViewA>();
			_viewB = _container.Resolve<ViewB>();
			_region.Add(_viewA);
			_region.Add(_viewB);
		}
		private void ActivateViewA_Click(object sender, RoutedEventArgs e)
		{
			_region.Activate(_viewA);
		}

		private void DeactivateViewA_Click(object sender, RoutedEventArgs e)
		{
			_region.Deactivate(_viewA);
		}

		private void ActivateViewB_Click(object sender, RoutedEventArgs e)
		{
			_region.Activate(_viewB);
		}

		private void DeactivateViewB_Click(object sender, RoutedEventArgs e)
		{
			_region.Deactivate(_viewB);
		}
	}
}
