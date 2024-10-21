using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VM
{
	public class MainWindowViewModel : ViewModelBase
	{
		public MainWindowViewModel()
		{
			//ChangeMessage = new ChangeMessageCommand(this);
			ChangeMessage = new RelayCommand(() => Message = "!!!");
		}

		private string _name = "c.y.c";
		public string Name
		{
			get { return _name; }
			set
			{
				if (_name != value)
				{
					_name = value;
					OnPropertyChanged(nameof(Name)); // 通知 UI 更新
				}
			}
		}

		private string _message = "hello world!";
		public string Message
		{
			get { return _message; }
			set
			{
				if (_message != value)
				{
					_message = value;
					OnPropertyChanged(nameof(Message)); // 通知 UI 更新
				}
			}
		}

		public ICommand ChangeMessage { set; get; }
	}
}
