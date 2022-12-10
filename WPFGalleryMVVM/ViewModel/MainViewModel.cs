using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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

        public ObservableCollection<Images> Imagess = Repositories.FakeRepo.GetImages();
        



        public RelayCommand DoubleClickCommand { get; set; }
        public RelayCommand MenuItemCommand { get; set; }
        public RelayCommand MenuItemCommand1 { get; set; }
        public RelayCommand MenuItemCommand2 { get; set; }
        public RelayCommand MenuItemCommand3 { get; set; }
        public RelayCommand MenuItemCommand4 { get; set; }
        public MainViewModel()
        {

            DoubleClickCommand = new RelayCommand((d) =>
            {
                var ListBox= d as ListBox;

                if(ListBox.SelectedItem is Images item)
                {
                    SecondPageViewModel secondPage = new SecondPageViewModel();
                    secondPage.image = item;
                    secondPage.index=ListBox.SelectedIndex;
                    secondPage.compyImage = Imagess;
                    
                    
                    
                }
                
            });

            MenuItemCommand = new RelayCommand((o) =>
            {
                
            });

            MenuItemCommand1 = new RelayCommand((o) =>
            {

            });

            MenuItemCommand2 = new RelayCommand((o) =>
            {

            });

            MenuItemCommand3 = new RelayCommand((o) =>
            {
                AboutWindow aboutWindow = new AboutWindow();
                aboutWindow.ShowDialog();
            });

            MenuItemCommand4 = new RelayCommand((o) =>
            {

            });

        }
    }
}
