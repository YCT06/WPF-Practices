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

namespace HelloSample004
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        //private Grid MainGrid;
        //private TextBlock MyTextBlock;
        public MainWindow()
        {
            InitializeComponent();
            MainGrid.Background = new SolidColorBrush(Color.FromRgb(70, 0, 255));
            MyTextBlock.Foreground = new SolidColorBrush(Colors.Gold);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
