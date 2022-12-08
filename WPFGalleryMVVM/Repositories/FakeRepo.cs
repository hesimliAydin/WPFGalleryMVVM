using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFGalleryMVVM.Model;

namespace WPFGalleryMVVM.Repositories
{
    public class FakeRepo
    {
        public static ObservableCollection<Images> GetImages()
        {
            return new ObservableCollection<Images>()
            {
                new Images()
                {
                    Name="Cristiano Ronaldo",
                    ImagePath="../../../Image/ronaldo.jpg",
                    Nationality="Portugal",
                    Price="500000000$",
                    Date=new DateTime(1985,05,05),
                    Description="Suuuuuuuiiii"
                },
                new Images()
                {
                    Name="Lionel Messi",
                    ImagePath="../../../Image/messi.jpg",
                    Nationality="Argentina",
                    Price="470000000$",
                    Date=new DateTime(1987,09,22),
                    Description="Suuuuuuuiiii"
                },
                new Images()
                {
                    Name="Fernando Maradona",
                    ImagePath="../../../Image/maradona.jpg",
                    Nationality="Argentina",
                    Price="3800000000$",
                    Date=new DateTime(1992,05,05),
                    Description="Suuuuuuuiiii"
                },
                new Images()
                {
                    Name="Oliver Kahn",
                    ImagePath="../../../Image/kahn.jpg",
                    Nationality="Almanya",
                    Price="2700000000$",
                    Date=new DateTime(1969,07,15),
                    Description="Suuuuuuuiiii"
                },
                new Images()
                {
                    Name="Pele",
                    ImagePath="../../../Image/pele.jpg",
                    Nationality="Brazil",
                    Price="3500000000$",
                    Date=new DateTime(1940,05,25),
                    Description="Suuuuuuuiiii"
                },
                new Images()
                {
                    Name="Johan Cruyff",
                    ImagePath="../../../Image/cruyff.jpg",
                    Nationality="Holland",
                    Price="1900000000$",
                    Date=new DateTime(1947,09,25),
                    Description="Suuuuuuuiiii"
                },
                new Images()
                {
                    Name="Carles Puyol",
                    ImagePath="../../../Image/puyol.jpg",
                    Nationality="Spain",
                    Price="3800000000$",
                    Date=new DateTime(1978,11,14),
                    Description="Suuuuuuuiiii"
                }

            };
        }
    }
}
