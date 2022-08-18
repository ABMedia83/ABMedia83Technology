
namespace Albert.Win32
{
    /// <summary>
    /// Base/Abstract ViewModel for WPF Applications 
    /// </summary>
    public abstract class ViewModel : Notify, ILog
    {
        #region Field's 

        TabControl? tab;
        ViewFrame? frame;
        ViewModelList<LogRecord> logs = new ViewModelList<LogRecord>();
        ViewModelList<FileRecord> files = new ViewModelList<FileRecord>();
        string? title;
        WindowState winState; 
        




        #endregion




        #region Log and File 

      
        /// <summary>
        /// A special event that fire's when you send a Message to the Application 
        /// </summary>
        public event LogEventHandler? OnLog;

        /// <summary>
        /// Method is designed to display a Custom Method with the ONLog Event 
        /// </summary>
        /// <param name="_message"></param>
        /// <param name="_isLogged"></param>
        public void Message(string _message, bool _isLogged)
        {
            if(_isLogged == true)
            {
                if (Logs != null)
                    Logs.Add(new LogRecord(_message));
            }
            else if(_isLogged == false)
            {
                //Do nothing 
            }

            //Invoke Event OnLog
            OnLog!.Invoke(_message);
        }


        /// <summary>
        /// Get or set Log Record's 
        /// </summary>
        public ViewModelList<LogRecord> Logs
        {
            get => logs;
            set { logs = value; OnPropertyChanged("Logs"); }
        }
        /// <summary>
        /// Get or set Files worked on
        /// </summary>
        public ViewModelList<FileRecord> Files
        {
            get => files;
            set { files = value; OnPropertyChanged("Files"); }
        }
            



        #endregion

        #region Method's 
        /// <summary>
        /// Method allows the ViewModel to run other .exe on the system 
        /// </summary>
        /// <param name="exeFile">File path of the .exe file</param>
        public static void RunExeFile(string exeFile)
        {
            Process p = new Process();
            p.StartInfo.FileName = exeFile;
            p.Start();
        }







        #endregion

        public void NavigateVMFrame(object _page)
        {
            if (VMFrame != null)
                VMFrame.Navigate(_page);
        }


        #region Public Properties 
        /// <summary>
        /// Get of set the Default Frmae 
        /// </summary>
        public ViewFrame? VMFrame
        {
            get => frame;
            set { frame = value; OnPropertyChanged("Frame"); }
        }
        /// <summary>
        /// Get's or set the Default TabControl 
        /// </summary>
        public TabControl? VMTab
        {
            get => tab;
            set { tab = value; OnPropertyChanged("VMTab"); }
        }

        public WindowState WindowState
        {
            get => winState;
            set { winState = value; OnPropertyChanged("WindowState"); }
        }

        /// <summary>
        /// Get or set the Title of the Application 
        /// </summary>
        public string? Title
        {
            get => title;
            set { title = value; OnPropertyChanged("Title"); }
        }








 
      
      

        #endregion


    }
}
