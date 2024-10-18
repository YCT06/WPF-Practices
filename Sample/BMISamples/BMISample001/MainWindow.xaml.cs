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

namespace BMISample001
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

        /// <summary>
        ///  體重(公斤) / 身高 (公尺)的平方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void computeButton_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(heightTextbox.Text, out double height);
            double.TryParse(weightTextBox.Text, out double weight);
            var result = weight / Math.Pow(height, 2);
            resultText.Text = result.ToString();            
        }
    }
}
