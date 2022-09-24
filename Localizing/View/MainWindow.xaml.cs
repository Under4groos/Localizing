using Localizing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Localizing
{
  
    public partial class MainWindow : Window
    {
        SetLocalized localized = new SetLocalized();
        bool b = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReUpdate();
        }
        void ReUpdate()
        {
            b = !b;
            localized.Set(b == true ? "Rus.xaml" : "Eng.xaml");
        }
    }
}
