using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CommunityToolKit
{

    public partial class MainPage : ContentPage
    {
        private int count = 10;
        public  int Count
        {
            get => count;
            set
            {
                count = value;
                OnPropertyChanged(nameof(Count));
            }
        }

        public ICommand PressedCommand { get => new Command(() => Count++); }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
