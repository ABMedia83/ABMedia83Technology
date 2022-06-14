using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Albert.Win32.Controls
{
    /// <summary>
    /// A spacial Frame designed to deal with MVVM 
    /// </summary>
    public class ViewFrame: Frame
    {
        public ViewFrame()
        {
            NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }

        #region SendMessage Override Method's 
        /// <summary>
        /// Send a simple message to the ViewMdoel
        /// </summary>
        /// <param name="_str"></param>
        public virtual void SendMessage(string _str)
        {
            // Do nothing for now 
        }
        /// <summary>
        /// Method is desgned to Log and send a Message to the View Model
        /// </summary>
        /// <param name="_str"></param>
        public virtual void LogAndSendMessage(string _str)
        {
            // Do nothing for now 
        }
        /// <summary>
        /// Method designed to send a File has been open Method to the Applcation 
        /// </summary>
        /// <param name="_info"></param>
        public virtual void OpenMessage(FileInfo _info)
        {
            // Do nothing for now 
        }
        /// <summary>
        /// Method designed to send a Save Message to the Application 
        /// </summary>
        /// <param name="_info"></param>
        public virtual void SaveMessage(FileInfo _info)
        {
            // Do nothing for now 
        }

        #endregion
    }
}
