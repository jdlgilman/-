using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell.ViewModels
{
    internal class MainWindowViewModel:BindableBase
    {
        private string _title="WPF APP Test";
        public string Title 
        { 
            get { return _title; } 
            set { _title = value; RaisePropertyChanged(); }          
        }
    }
}
