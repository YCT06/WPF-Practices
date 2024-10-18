using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ControlTemplateSample002
{
    public class MyButton : Button
    {
        public static readonly DependencyProperty StrokeThicknessProperty;

        static MyButton()
        {
            StrokeThicknessProperty = DependencyProperty.Register(nameof(StrokeThickness), typeof(double), typeof(MyButton),
                new PropertyMetadata(2.0));
        }

        public double StrokeThickness
        {
            get => (double)GetValue(StrokeThicknessProperty);
            set => SetValue(StrokeThicknessProperty, value);
        }

    }
}
