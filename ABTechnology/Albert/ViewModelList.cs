using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Albert
{
    /// <summary>
    /// An Enhanced ObservableCollection that has some more advance features  
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ViewModelList<T> : ObservableCollection<T>
    {

        

        /// <summary>
        /// ForEach Method for the Collection 
        /// </summary>
        /// <param name="_method"></param>
        public void ForEach(Action<T> _method)
        {
            
            foreach (var i in this)
            {

                _method.Invoke(i);
            }
        }

        /// <summary>
        /// Convert list to Json String 
        /// </summary>
        /// <returns></returns>
        public string ToJsonString()
        {
            return Serialize(this);
        }



    }
}
