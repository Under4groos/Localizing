using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Localizing.Model

{
    public class SetLocalized
    {
        public SetLocalized()
        {
           
        }
        public void Set( string name)
        {
            string path_ = "DataResource";
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri(Path.Combine(path_ , name), UriKind.RelativeOrAbsolute);
            ResourceDictionary oldDict = (from d in Application.Current.Resources.MergedDictionaries
                                          where d.Source != null select d).First();
            int ind = Application.Current.Resources.MergedDictionaries.IndexOf(oldDict);
            Application.Current.Resources.MergedDictionaries.Remove(oldDict);
            Application.Current.Resources.MergedDictionaries.Insert(ind, dict);
        }
    }
}
