using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VM
{
	public class ChangeMessageCommand : ICommand
	{
		private readonly MainWindowViewModel _vm;

		public ChangeMessageCommand(MainWindowViewModel vm)
		{
			_vm = vm;
		}

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			_vm.Message = "!!!";
		}

		public event EventHandler CanExecuteChanged;
	}
}
