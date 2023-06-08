using MonkeysGallery.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeysGallery.ViewModel
{
    public class MonkeyViewModel:ViewModel
    {
        public ObservableCollection<Monkey> Monkeys { get; set; }   
        private Monkey monkey { get; set; }
        public Monkey Monkey { get { return monkey; } set { if (value != monkey) {monkey=value; OnPropertyChanged(); } } }

        public MonkeyViewModel()
        {
     
        }

    }
}
