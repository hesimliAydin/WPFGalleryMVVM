using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using WPFGalleryMVVM.Command;
using WPFGalleryMVVM.Model;
using WPFGalleryMVVM.Windows;

namespace WPFGalleryMVVM.ViewModel
{
    public class SecondPageViewModel:BaseViewModel
    {
        public Images image { get; set; }
        public int index;
        public List<Images> compyImage { get; set; }


        public RelayCommand BackCommand { get; set; }
        public RelayCommand SmallCommand { get; set; }
        public RelayCommand MediumCommand { get; set; }
        public RelayCommand LargeCommand { get; set; }
        public RelayCommand AutoPlayBtnCommand { get; set; }
        public RelayCommand PauseBtnCommand { get; set; }
        public RelayCommand NextBtnCommand { get; set; }
        public RelayCommand PrevBtnCommand { get; set; }


        public SecondPageViewModel()
        {
            BackCommand = new RelayCommand((o) =>
            {
                var page = new SecondPage();
                page.Close();
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

            DispatcherTimer timer=new DispatcherTimer();

            

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
                if (index > 0)
                {
                    image = compyImage[index - 1];
                    index -= 1;
                    
                }
            });

           


        }

    }
}
