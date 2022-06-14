using System;
using System.Windows.Media;
using static Albert.Win32.MediaConvert;

namespace Albert.Win32.Items
{
    /// <summary>
    /// Class is designed to Style the notes 
    /// </summary>
    public class NoteStyle: Item 
    {
        Color backgroundcolor, foregroundcolor;

        public NoteStyle()
        {
            BackgroundColor = HexColor("#ffffff");
            ForegroundColor = HexColor("#000000");
        }

        public NoteStyle(Color _foreground , Color _background)
        {
            BackgroundColor = _background;
            ForegroundColor = _foreground;
        }
        public Color BackgroundColor
        {
            get => backgroundcolor;
            set { backgroundcolor = value; OnPropertyChanged("BackgoundColor"); }
        }
        /// <summary>
        /// Gets or set the Color of the Text 
        /// </summary>
        public Color ForegroundColor
        {
            get => foregroundcolor;
            set { foregroundcolor = value; OnPropertyChanged("ForegroundColor"); }
        }
    }

}
