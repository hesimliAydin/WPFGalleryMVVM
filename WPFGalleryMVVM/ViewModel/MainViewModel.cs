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
    public class MainViewModel : BaseViewModel
    {


        private Images selectedItem;

        public Images SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; OnPropertyChanged(); }
        }

        public int index { get; set; }

        private ObservableCollection<Images> images;

        public ObservableCollection<Images> Imagess
        {
            get { return images; }
            set { images = value; OnPropertyChanged(); }
        }




        public RelayCommand MediumCommand { get; set; }
        public RelayCommand SmallCommand { get; set; }
        public RelayCommand LargeCommand { get; set; }
        public RelayCommand AboutCommand { get; set; }
        public RelayCommand ExitCommand { get; set; }
        public RelayCommand SelectImageCommand { get; set; }
        public MainViewModel()
        {
            SelectedItem = new Images();
            Imagess = new ObservableCollection<Images>();
            Imagess = new ObservableCollection<Images>(Repositories.FakeRepo.GetImages());


            SelectImageCommand = new RelayCommand((o) =>
            {
                MessageBox.Show(SelectedItem.Name);
            });
            MediumCommand = new RelayCommand((o) =>
            {
                var w = o as Window;
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
