using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp3.Commands;
using WpfApp3.Views.UC;

namespace WpfApp3.ViewModels
{
    public class AppViewModel:BaseViewModel
    {
        public StackPanel MyGrid { get; set; }


        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; OnPropertyChanged(); }
        }

        public RelayCommand SendCommand { get; set; }

        AUserControl view = new AUserControl();
        public AppViewModel()
        {
            var vm = new AUserControlVM();
            view.DataContext = vm;


            SendCommand = new RelayCommand((sender) =>
              {
                  vm.MyText = Text;
              });

        }
        public void SetGrid()
        {
            MyGrid.Children.Add(view);

        }    

    }
}
