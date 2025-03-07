﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VM
{
	public class RelayCommand<TParam> : ICommand where TParam : class
	{
		private readonly Action<TParam> _execute;
		private readonly Func<TParam, bool> _canExecute;

		public RelayCommand(Action<TParam> execute)
		{
			_execute = execute;
		}
		public RelayCommand(Action<TParam> execute, Func<TParam, bool> canExecute)
		{
			_canExecute = canExecute;
			_execute = execute;
		}

		public bool CanExecute(object parameter) => _canExecute == null || _canExecute(parameter as TParam);

		public void Execute(object parameter) => _execute(parameter as TParam);

		public event EventHandler CanExecuteChanged;
	}
}
