
namespace Albert.Win32.Items
{
    public class SnipItem: Notify
    {
        string name, code, type;

        public string SnipName
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }

        }
        public string SnipCode
        {
            get { return code; }
            set { code = value; OnPropertyChanged("Code"); }
        }

        public string SnipType
        {
            get { return type; }
            set { type = value; OnPropertyChanged("Type"); }
        }

        public override string ToString()
        {
            return SnipName;
        }

    }
}
