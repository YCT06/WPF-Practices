using BindingLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsControlSample001
{
    public class MainViewModel : NotifyPropertyBase
    {
        private ObservableCollection<Person> _people;
        public ObservableCollection<Person> People
        {
            get => _people;
            set => SetProperty(ref _people, value);
        }

        private Person _selected;
        public Person Selected
        {
            get => _selected;
            set => SetProperty(ref _selected, value);
        }
        public MainViewModel()
        {
            CreateData();
        }
        private void CreateData()
        {
            People = new ObservableCollection<Person>
            {
                new Person { Name = "Bill", Age = 47 },
                new Person { Name = "John", Age = 37 },
                new Person { Name = "Tom", Age = 48 },
                new Person { Name = "David", Age = 36 },
                new Person { Name = "Bill", Age = 35 },
            };
        }
    }

}
