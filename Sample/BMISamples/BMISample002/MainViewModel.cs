using BindingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BMISample002
{
    public class MainViewModel : NotifyPropertyBase
    {
        private double _height;
        public double Height
        {
            get => _height;
            set => SetProperty(ref _height, value);
        }

        private double _weight;
        public double Weight
        {
            get => _weight;
            set => SetProperty(ref _weight, value);
        }

        private double _result;
        public double Result
        {
            get => _result;
            set => SetProperty(ref _result, value);
        }

        private ICommand _computeCommand;
        public ICommand ComputeCommand
        {
            get
            {
                if(_computeCommand == null )
                {
                    _computeCommand = new RelayCommand((x) =>
                    {
                        Result = Weight / Math.Pow(Height, 2);
                    });
                }

                return _computeCommand;
            }
        }
    }
}
