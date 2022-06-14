using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Albert.Win32
{
	/// <summary>
	/// Basic Command for dealing with the ViewModel	
	///</summary>
	public class ViewCommand : ICommand
	{

		#region Field's 
		Action method;
		Func<bool> canExecute;

		#endregion

		#region Constructors 
		
		public ViewCommand(Action _method)
        {
			method = _method;
			//Quick Lamba return's bool true 
			bool isTrue() => true;
			canExecute = isTrue;

        }

		public ViewCommand(Action _method,Func<bool> _canExecute)
		{
			 
			method = _method;
			canExecute = _canExecute;
		}

	
		#endregion


	

		#region ICommand 

		public event EventHandler? CanExecuteChanged;

		public bool CanExecute(object? parameter)
		{
			return canExecute();
			
			
		}

		public void Execute(object? parameter)
		{
			method();
		} 

		#endregion
	}
}
