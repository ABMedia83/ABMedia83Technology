
namespace Albert.Win32.Controls
{
	/// <summary>
	/// Basic Window for doing MVVM applicatoins 
	/// </summary>
	public class ViewShell : Window, IAddCommand
	{




		public virtual void Init()
        {
			// Do nothing for now 
        }
		/// <summary>
		/// Add Command Quickly 
		/// </summary>
		/// <param name="_command">ICommand</param>
		/// <param name="_method">Event Lamba</param>
		public void AddCommand(ICommand _command, ExecutedRoutedEventHandler _method)
		{
			//Add Command 
			CommandBindings.Add(new CommandBinding(_command, _method));
		}

		#region Override Import and Export Settings method's 

		public virtual void ImportSettings(string _filePath)
		{

		}
		public virtual void ExportSettings(string _filePath)
		{

		}


		#endregion



	}
}
