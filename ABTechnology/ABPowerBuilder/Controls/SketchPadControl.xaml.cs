

namespace Controls
{
    /// <summary>
    /// sketcPad control is designed to draw things at diffrent sizes 
    /// </summary>
    public partial class SketchPadControl : PowerView 
    {
        public SketchPadControl()
        {
            InitializeComponent();
            Init();
        }

 
        /// <summary>
        /// Constuctor for new Sketch 
        /// </summary>
        /// <param name="_tab"></param>
        public SketchPadControl(TabControl _tab)
        {
            InitializeComponent();
            Init();
        }
        /// <summary>
        /// Consructor for Loading a Sketch 
        /// </summary>
        /// <param name="_tab"></param>
        /// <param name="_info"></param>
        public SketchPadControl(TabControl _tab, FileInfo _info)
        {
            InitializeComponent();
            Init();
        }

        public override void Init()
        {
            base.Init();

            formatComboBox.SelectionChanged += (sender, e) =>
            {

            };

            themeComboBox.SelectionChanged += (sender, e) =>
            {

            };




        }
    }
}
