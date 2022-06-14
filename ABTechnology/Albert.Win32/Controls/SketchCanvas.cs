using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Input;

using System.Windows.Markup;

namespace Albert.Win32.Oppsoleate  
{
	/// <summary>
	/// A special canvas designed for  Sketching
	/// </summary>
	public class SketchCanvas : Canvas
	{








	}

	public enum SketchState
	{
		Draw, Erase, Line, Disabled, Rectangle, Circle, Triangle, Star
	}
}
