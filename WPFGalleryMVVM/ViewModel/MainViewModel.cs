using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPFGalleryMVVM.Command;
using WPFGalleryMVVM.Model;
using WPFGalleryMVVM.Windows;

namespace WPFGalleryMVVM.ViewModel
{
    public class MainViewModel:BaseViewModel
    {
        

        public Images image { get;set;}
        public int index { get; set; }

        public ObservableCollection<Images> Imagess { get; set; }

       

        public RelayCommand DoubleClickCommand { get; set; }
        public RelayCommand MediumCommand { get; set; }
        public RelayCommand SmallCommand { get; set; }
        public RelayCommand LargeCommand { get; set; }
        public RelayCommand AboutCommand { get; set; }
        public RelayCommand ExitCommand { get; set; }
        public MainViewModel()
        {
            Imagess = new ObservableCollection<Images>();
            Imagess= new ObservableCollection<Images>(Repositories.FakeRepo.GetImages());

            DoubleClickCommand = new RelayCommand((d) =>
            {
                var ListBox = d as ListBox;

                if (ListBox.SelectedItem is Images item)
                {
                    SecondPage secondPage = new SecondPage();
                    
                    //secondPage.compyImage = Imagess;



                }

            });

            MediumCommand = new RelayCommand((o) =>
            {
                var w= o as Window;
              w.Resources["ButtonFS"] = 150.0;
            });

            SmallCommand = new RelayCommand((o) =>
            {
                var w = o as Window;
               w.Resources["ButtonFS"] = 50.0;
            });

            LargeCommand = new RelayCommand((o) =>
            {
                var w = o as Window;
                w.Resources["ButtonFS"] = 250.0;
            });

            AboutCommand = new RelayCommand((o) =>
            {
                AboutWindow aboutWindow = new AboutWindow();
                aboutWindow.ShowDialog();
            });

            ExitCommand = new RelayCommand((o) =>
            {
                var w = o as Window;
                w.Close();
            });

        }
    }
}
