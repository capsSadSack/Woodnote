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

namespace WoodnoteWPF.Views
{
    /// <summary>
    /// Interaction logic for BirdSearchResultView.xaml
    /// </summary>
    public partial class BirdSearchResultView : UserControl
    {
        public BirdSearchResultView()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            //this.Visibility = Visibility.Hidden;
            //this.IsEnabled = false;
        }
    }
}
