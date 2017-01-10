using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BHSApplication
{
    public partial class MainPage : MasterDetailPage
    {
        MasterPage masterPage;
        public MainPage()
        {
            masterPage = new MasterPage();
            Master = masterPage;
            Detail = new NavigationPage(new BHSHomePage());
            //Detail = new BHSHomePage();

            masterPage.ListView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
