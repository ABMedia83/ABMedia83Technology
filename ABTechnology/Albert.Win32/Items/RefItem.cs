using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albert.Win32.Items
{
    /// <summary>
    /// Item that is designed to capture a Reference 
    /// </summary>
    public class RefItem: Item
    {
        //Feild 
        string  refer;
        /// <summary>
        /// Default Constuctor 
        /// </summary>
        public RefItem()
        {

        }

        public RefItem(string _name,string _ref)
        {
            Name = _name;
            Reference = _ref;
        }
     
        /// <summary>
        /// Get's the Website or name of a Book 
        /// </summary>
        public string Reference
        {
            get => refer; 
            set { refer = value; OnPropertyChanged("Reference"); }
        }

    }
}
