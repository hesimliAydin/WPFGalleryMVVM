using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFGalleryMVVM.Model;

namespace WPFGalleryMVVM.ViewModel
{
    public class MainViewModel:BaseViewModel
    {
        public List<Images> Imagess { get; set; }


        public MainViewModel()
        {

        }
    }
}
