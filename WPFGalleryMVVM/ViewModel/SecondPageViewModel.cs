using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using WPFGalleryMVVM.Command;
using WPFGalleryMVVM.Model;

namespace WPFGalleryMVVM.ViewModel
{
    public class SecondPageViewModel:BaseViewModel
    {
        public Images image { get; set; }
        public int index;
        public ObservableCollection<Images> compyImage { get; set; }


        public RelayCommand ButtonClickCommand1 { get; set; }
        public RelayCommand MenuItemCommand1 { get; set; }
        public RelayCommand MenuItemCommand2 { get; set; }
        public RelayCommand MenuItemCommand3 { get; set; }
        public RelayCommand MenuItemCommand { get; set; }
        public RelayCommand AutoPlayBtnCommand { get; set; }
        public RelayCommand PauseBtnCommand { get; set; }
        public RelayCommand NextBtnCommand { get; set; }
        public RelayCommand PrevBtnCommand { get; set; }


        public SecondPageViewModel()
        {
            ButtonClickCommand1 = new RelayCommand((o) =>
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

            });

            MenuItemCommand = new RelayCommand((o) =>
            {

            });

            AutoPlayBtnCommand = new RelayCommand((o) =>
            {

            });

            PauseBtnCommand = new RelayCommand((o) =>
            {

            });

            NextBtnCommand = new RelayCommand((o) =>
            {

            });

            PrevBtnCommand = new RelayCommand((o) =>
            {

            });


        }

    }
}
