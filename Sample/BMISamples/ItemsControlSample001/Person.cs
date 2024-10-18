using BindingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsControlSample001
{
    public class Person : NotifyPropertyBase
    {
        private string _name;
        public string Name
        {
            get => _name;
            set=> SetProperty(ref _name, value);
        }

        private int _age;
        public int Age
        {
            get => _age;
            set => SetProperty(ref _age, value);
        }
    }
}
