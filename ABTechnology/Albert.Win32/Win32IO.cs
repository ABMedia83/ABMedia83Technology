namespace Albert.Win32
{
    #region Delegates 
    /// <summary>
    /// A special delegate designed for the SaveDialogTask
    /// </summary>
    /// <param name="_dialog"></param>
    /// <param name="_info"></param>
    public delegate void SaveDialogTaskEventHandler(SaveFileDialog _dialog, FileInfo _info );
	/// <summary>
	/// A special delegate deisned for the OpenDialogTask
	/// </summary>
	/// <param name="_dialog"></param>
	/// <param name="_info"></param>
	public delegate void OpenDialogTaskEventHandler(OpenFileDialog _dialog, FileInfo _info);


    #endregion 

    /// <summary>
    /// A special Module to speed up the IO Process on Windows Applications 
    /// </summary>
    public static class Win32IO
	{



		#region Win32 Dialog Boxes 
        /// <summary>
        /// Tuple to Quickly fill in Dialog Information 
        /// </summary>
        /// <param name="_title"></param>
        /// <param name="_filter"></param>
        /// <returns></returns>
        public static (string Title,string Filter) DialogInfoTuple(string _title,string _filter)
        {
			
            return (_title, _filter);
        }
		
		/// <summary>
		/// Make a Quick Filter 
		/// </summary>
		/// <param name="_description"></param>
		/// <param name="_extentsion"></param>
		/// <returns></returns>
		public static string MakeFilter(string _description,string _extentsion)
		{
			var rv = $"{_description}({_extentsion})|*{_extentsion}";
			return rv;

		}

	



		/// <summary>
		/// A special task to speed up the SaveDialog Proecss 
		/// </summary>
		/// <param name="_title">Title of the Window</param>
		/// <param name="_filter">Filter for the fileformats</param>
		/// <param name="_method">(diloag class)The Method that will be used</param>
		public static void SaveDialogTask(string _title, string _filter, SaveDialogTaskEventHandler _method)
		{
			
				var dialog = new SaveFileDialog { Title = _title, Filter = _filter };//Create a new dialog 

				if (dialog.ShowDialog() == true)
				{

					var info = new FileInfo(dialog.FileName);
					_method.Invoke(dialog, info); //Run the method
				}
			
		}

	
		/// <summary>
		/// A special task to speed up the OpenDialog Proecss 
		/// </summary>
		/// <param name="_title">Title of the Window</param>
		/// <param name="_filter">Filter for the fileformats</param>
		/// <param name="_method">(diloag class)The Method that will be used</param>
		public static void  OpenDialogTask(string _title, string _filter,  OpenDialogTaskEventHandler _method)
		{
			//Run this Task 
		
				var dialog = new OpenFileDialog { Title = _title, Filter = _filter }; //Create a new dialog 

				dialog.Multiselect = true; // Enable selecting multple vfiles  

				if (dialog.ShowDialog() == true)
				{
					//Create the FileInfo 
					var info = new FileInfo(dialog.FileName);
					//Invoke the Action 
					_method?.Invoke(dialog, info); //Run the method
				}
			
			
		}


		#endregion

		#region Ink 
		/// <summary>
		/// A process to save ink strokes 
		/// </summary>
		/// <param name="_ink">Ink Canvas</param>
		/// <param name="_fn">File Name</param>
		public static void SaveInkStrokes(InkCanvas _ink, string _fn)
		{
			
				using var stream = new FileStream(_fn, FileMode.Create);
				//Save Strokes 
				_ink.Strokes.Save(stream);
				//Flush your stream;
				stream.Flush();
			
        }
		/// <summary>
		/// Load Ink Strokes 
		/// </summary>
		/// <param name="_ink">InkCanvas </param>
		/// <param name="_fn">File Name</param>
		public static void LoadInkStrokes(InkCanvas _ink, string _fn)
		{
            using var stream = new FileStream(_fn, FileMode.Open);
            var collection = new StrokeCollection(stream);

            //Load Stroke Collection 
            _ink.Strokes = collection;
            //Flush Your Stream 
            stream.Flush();
        }
		#endregion

		#region Text Files 
		/// <summary>
		/// Save to a plain textfile 
		/// </summary>
		/// <param name="_text">Text Content</param>
		/// <param name="_fn">File Name</param>
		public static void SaveText(string _text, string _fn)
		{
			//Write the Text File 
			File.WriteAllText(_fn, _text);
		}
		/// <summary>
		/// Load Text File 
		/// </summary>
		/// <param name="_fn">File Name</param>
		/// <returns></returns>
		public static string LoadText(string _fn)
		{
			//Load the File 
			var rv = File.ReadAllText(_fn);
			//Return the File Contnets to a string
			return rv;
		}

		#endregion

		#region Rich Text Box 

		public static void SaveRichTextData(RichTextBox _rtb, string _fn)
		{
            using var stream = new FileStream(_fn, FileMode.Create);
            //Get the TexgRange
            var tr = new TextRange(_rtb.Document.ContentStart, _rtb.Document.ContentEnd);
            //Save Rich Text 
            tr.Save(stream, DataFormats.Xaml);
            //Flush your stream 
            stream.Flush();
        }
		public static void LoadRichTextData(RichTextBox _rtb, string _fn)
		{
            using var stream = new FileStream(_fn, FileMode.Open);
            //Create FlowDocuent 
            var fl = new FlowDocument();
            //Create a TextRange 
            var tr = new TextRange(fl.ContentStart, fl.ContentEnd);
            //Load the Document 
            tr.Load(stream, DataFormats.Xaml);
            //Load Document on to the RichTextBox 
            _rtb.Document = fl;
            //Flush your stream 
            stream.Flush();
        }


		#endregion


		#region Copy File and Create file Path Logic 
		/// <summary>
		/// Create File for a Directory 
		/// </summary>
		/// <param name="_name">File Name</param>
		/// <param name="_directory">Directory Location</param>
		public static void CreateFile(string _name, string _directory)
		{
			//Create the Path 
			var combine = Path.Combine(_directory, _name);
			//Create the File
			File.WriteAllText(combine,"");
		}
		/// <summary>
		/// Create File for a Directory 
		/// </summary>
		/// <param name="_name">Name of File</param>
		/// <param name="_directory">Directory location</param>
		/// <param name="_content">File Content</param>
		public static void CreateFile(string _name,string _directory, string _content)
		{
			//Create the Path 
			var combine = Path.Combine(_directory, _name);
			//Create the File
			File.WriteAllText(combine, _content);
		}

		

		public static void CopyTextFileFromFile(string _originalFilePath, string _directory, string _newName)
		{
			if (File.Exists(_originalFilePath))
			{
				var content = File.ReadAllText(_originalFilePath); // Read all the content in the file
				var newpath = Path.Combine(_directory, _newName); // Create a new directory and path for the file 
				File.WriteAllText(newpath, content); // Create the file 
				
			}
			else
			{
				MessageBox.Show($"Could not find{_originalFilePath}");
			}

		}
		/// <summary>
		/// Create a string filename 
		/// </summary>
		/// <param name="_name"></param>
		/// <param name="_directory"></param>
		/// <returns></returns>
		public static string StringFlieName(string _name, string _directory)
		{
			var rv = Path.Combine(_directory,_name);
			return rv;
		}


		#endregion


		#region Bitmap Section 
		/// <summary>
		/// Create a .png file 
		/// </summary>
		/// <param name="_fileName"></param>
		/// <param name="dpi"></param>
		/// <param name="element"></param>
		public static void CreatePng(string _fileName, int dpi, FrameworkElement element)
		{
			//Mesuse and Create the right size of the Element
			element.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
			element.Arrange(new Rect(new Point(0, 0), element.DesiredSize));

			//Convert width and height to whole pixels
			var width = (int)Math.Ceiling(element.ActualWidth);
			var height = (int)Math.Ceiling(element.ActualHeight);

			width = width == 0 ? 1 : width;
			height = height == 0 ? 1 : height;

			//Create a RenderTargetBitmap and discribe its properties 
			var bitmap = new RenderTargetBitmap(width, height, dpi, dpi, PixelFormats.Default);
			//Render the Visual 
			bitmap.Render(element);

			if (_fileName != string.Empty)
			{
                using var stream = new FileStream(_fileName, FileMode.Create);
                var encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmap));
                //Save the bitmap 
                encoder.Save(stream);
                //Close the stream 
                stream.Close();
            }

			//All done! 

		}
		/// <summary>
		/// Create a jpeg file 
		/// </summary>
		/// <param name="_fileName"></param>
		/// <param name="dpi"></param>
		/// <param name="element"></param>
		public static void CreateJpeg(string _fileName, int dpi, FrameworkElement element)
		{
			//Mesuse and Create the right size of the Element
			element.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
			element.Arrange(new Rect(new Point(0, 0), element.DesiredSize));

			//Convert width and height to whole pixels
			var width = (int)Math.Ceiling(element.ActualWidth);
			var height = (int)Math.Ceiling(element.ActualHeight);

			width = width == 0 ? 1 : width;
			height = height == 0 ? 1 : height;

			var bitmap = new RenderTargetBitmap(width, height, dpi, dpi, PixelFormats.Default);
			//Render the Visual 
			bitmap.Render(element);

			if (_fileName != string.Empty)
			{
                using var stream = new FileStream(_fileName, FileMode.Create);
                var encoder = new JpegBitmapEncoder();

                encoder.Frames.Add(BitmapFrame.Create(bitmap));
                //Save the bitmap 
                encoder.Save(stream);
                //Close the stream 
                stream.Close();
            }
		}


		public static void CreateTiff(string _fileName, int dpi, FrameworkElement element)
		{
			//Mesuse and Create the right size of the Element
			element.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
			element.Arrange(new Rect(new Point(0, 0), element.DesiredSize));

			//Convert width and height to whole pixels
			var width = (int)Math.Ceiling(element.ActualWidth);
			var height = (int)Math.Ceiling(element.ActualHeight);

			width = width == 0 ? 1 : width;
			height = height == 0 ? 1 : height;

			var bitmap = new RenderTargetBitmap(width, height, dpi, dpi, PixelFormats.Default);
			//Render the Visual 
			bitmap.Render(element);

			if (_fileName != string.Empty)
			{
				using var stream = new FileStream(_fileName, FileMode.Create);
				var encoder = new TiffBitmapEncoder();

				encoder.Frames.Add(BitmapFrame.Create(bitmap));
				//Save the bitmap 
				encoder.Save(stream);
				//Close the stream 
				stream.Close();
			}
		}

		#endregion




	}
}
