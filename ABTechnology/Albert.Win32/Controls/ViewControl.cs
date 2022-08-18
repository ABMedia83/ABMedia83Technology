﻿
namespace Albert.Win32.Controls
{
    /// <summary>
    /// A special ContentControl desinged to work with a Tab Interface and the MVVM Pattern
    /// </summary>
    public class ViewControl : ContentControl, IAddCommand
    {

        ViewDialog? topDialog;


        #region Depedency Properties
        public static DependencyProperty TopDialogBarProperty = DependencyProperty.Register("TopDialogBar", typeof(object), typeof(ViewControl), null);
        public static DependencyProperty BottomDialogBarProperty = DependencyProperty.Register("BottomDialogBar", typeof(object), typeof(ViewControl), null);
        public static DependencyProperty TopDialogVisibilityProperty = DependencyProperty.Register("TopDialogVisibility", typeof(Visibility), typeof(ViewControl), new PropertyMetadata(Visibility.Visible));
        public static DependencyProperty BottomDialogVisibilityProperty = DependencyProperty.Register("BottomDialogVisibility", typeof(Visibility), typeof(ViewControl), new PropertyMetadata(Visibility.Visible));

        #endregion
        public ViewControl()
        {
            //ReDraw the Control 
            DefaultStyleKey = typeof(ViewControl);
          
        }

        /// <summary>
        /// Remove Tab Method  
        /// </summary>
        public void RemoveTab()
        {
            TabItem?.RemoveTab();
        }




        #region Tab and Initialize Method's 
        public void FrameInit(Frame _frame)
        {
            //Clean up if already use
            if(TabItem != null)
            {
                TabItem.Content = null;
            }
            Page = new ViewPage();
            Page.Content = this;
            _frame.Navigate(Page);
        }
        /// <summary>
        /// Method to Quickly Initialize TabItem, and decide rather or not you can remove the tab 
        /// </summary>
        /// <param name="_header"></param>
        /// <param name="_isClosedEnabled"></param>
        /// <param name="_tab"></param>
        public void CreateTab(string _header, bool _isClosedEnabled, TabControl _tab)
        {
            //Clean up if page is active 
            if(Page != null)
            {
                Page.Content = null;
            }

            //Create a new TabItem 
            TabItem = new ViewTabItem(_header, _isClosedEnabled, this, _tab);
            //Focus on the Tab 
            TabItem.Focus();
            this.Focus();

        }
        /// <summary>
        /// Method used to Initialize the TabItem, Load a File, and Setup the Tab Closed method  
        /// </summary>
        /// <param name="_tab">TabItem</param>
        /// <param name="_file  Name">FileName</param>
        /// <param name="__method">Close Method</param>
        public void CreateTab(TabControl _tab, FileInfo _info, Action __method)
        {
            if (Page != null)
            {
                Page.Content = null;
            }

            FileInfo = _info;
            CurrentFile = _info.FullName;

            //Create a new TabItem 
            TabItem = new ViewTabItem(_info.Name, this, _tab);
            CurrentFile = _info.FullName;
            //Close Method 
            TabItem.Closed += (sender, e) =>
            {
                __method?.Invoke();
            };

            //Focus on the Tab 
            TabItem.Focus();
            this.Focus();
        }

        /// <summary>
        /// Method to quickly Initialize the TabItem and Close Method 
        /// </summary>
        /// <param name="_header"></param>
        /// <param name="_tab"></param>
        /// <param name="_closeMethod"></param>
        public void CreateTab(string _header, TabControl _tab, Action _closeMethod)
        {
            if (Page != null)
            {
                Page.Content = null;
            }
            //Create a new TabItem 
            TabItem = new ViewTabItem(_header, this, _tab);

            //Close Method 
            TabItem.Closed += (sender, e) =>
            {
                //Focus on the Tab 
                TabItem.Focus();
                _closeMethod.Invoke();
            };

            //Focus on the Tab 
            TabItem.Focus();
            this.Focus();

        }

        #endregion

   


        #region Method from IAddCommand 

        /// <summary>
        /// Quick way to add a Coomamand to the control
        /// </summary>
        /// <param name="_command"></param>
        /// <param name="_method"></param>
        public void AddCommand(ICommand _command, ExecutedRoutedEventHandler _method)
		{
			CommandBindings.Add(new CommandBinding(_command, _method));
		}

        #endregion

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

        public void SetCurrentFilePath(string _filePath)
        {
            CurrentFile = _filePath; ;
            FileInfo = new FileInfo(_filePath);

        }

        #endregion

        #region Init and Close Override Method's  
        /// <summary>
        /// A virtual Method designed to work with  multiple constructor's 
        /// </summary>
        public virtual void Init()
        {
            // Do nothing for now ment to call with the Constructor's your create 
        }
        /// <summary>
        /// An virtural method used to Close when TabItem.Closed is called 
        /// </summary>
        public virtual void Close()
        {
            //Default behavior 
            if(TabItem != null && TabItem != null)
            {
                //Remove the Tab 
                RemoveTab();
            }
        }

        #endregion 


        #region Import and Export Settings Method 

        public virtual void ExportSettings(string _str)
        {

        }

        public virtual void ImportSettings(string _str)
        {

        }

        #endregion 









        #region Main Public Properties

        /// <summary>
        ///Get or Set the Default Top Dialog Box for getting stuff done  
        /// </summary>
        public ViewDialog TabDialog
        {
            get
            {
                topDialog = new ViewDialog();
                TopDialogBar = topDialog;
                return topDialog;

            }
        }

        public object TopDialogBar
        {
            get { return (object)GetValue(TopDialogBarProperty); }
            set { SetValue(TopDialogBarProperty, value); }
        }

        public object BottomDialogBar
        {
            get { return (object)GetValue(BottomDialogBarProperty); }
            set { SetValue(BottomDialogBarProperty, value); }
        }

        public object TopDialogVisibility
        {
            get { return (Visibility)GetValue(TopDialogVisibilityProperty); }
            set { SetValue(TopDialogVisibilityProperty, value); }
        }

        


        public Visibility BottomDialogVisibility
        {
            get { return (Visibility)GetValue(BottomDialogVisibilityProperty); }
            set { SetValue(BottomDialogVisibilityProperty, value); }
        }

        /// <summary>
        /// Gets or sets a Page that ueses the ViewControl
        /// </sBoxummary>
        public ViewPage? Page { get; set; }

        /// <summary>
        /// Gets or sets the TabItem that uses the ViewControl 
        /// </summary>
        public ViewTabItem? TabItem { get; set; }


        /// <summary>
        /// Gets or sets the TabControl that uses the ViewControl 
        /// </summary>
        public TabControl MainTabControl { get; set; }





        /// <summary>
        /// Gets or Sets a Url to a FIle you are working on 
        /// </summary>
        public string CurrentFile { get; set; }

        public DirectoryInfo FileDirectory { get; set; }

		public FileInfo FileInfo { get; set; }
        /// <summary>
        /// Get or sets the Number of documents created 
        /// </summary>
        public static int Count { get; set; } = 1;

        #endregion


    }
}
