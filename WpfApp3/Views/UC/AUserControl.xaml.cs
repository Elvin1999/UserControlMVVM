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
using WpfApp3.ViewModels;

namespace WpfApp3.Views.UC
{
    /// <summary>
    /// Interaction logic for AUserControl.xaml
    /// </summary>
    public partial class AUserControl : UserControl
    {
        public AUserControl()
        {
            InitializeComponent();
            this.DataContext = new AUserControlVM();
        }
    }
}
