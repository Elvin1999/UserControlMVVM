using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.ViewModels
{
   public class AUserControlVM:BaseViewModel
    {
        private string myText;

        public string MyText
        {
            get { return myText; }
            set { myText = value; OnPropertyChanged(); }
        }
        public AUserControlVM()
        {

        }
    }
}
