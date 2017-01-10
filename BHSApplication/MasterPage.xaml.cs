using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BHSApplication
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }
        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Home",
                IconSource = "@drawable/phone.png",
                TargetType = typeof(BHSHomePage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Contact Us",
                IconSource = "@drawable/dot.png",
                TargetType = typeof(BHSContactUs)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Twitter",
                IconSource = "@drawable/mail.png",
                TargetType = typeof(BHSTwitterPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Facebook",
                IconSource = "@drawable/mail.png",
                TargetType = typeof(BHSFacebookPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "YouTube",
                IconSource = "@drawable/mail.png",
                TargetType = typeof(BHSYoutubePage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Blog",
                IconSource = "@drawable/mail.png",
                TargetType = typeof(BHSBlogPage)
            });

            listView.ItemsSource = masterPageItems;

            /*
            listView = new ListView
            {
                ItemsSource = masterPageItems,
                ItemTemplate = new DataTemplate (() =>
                {
                    var imageCell = new ImageCell();
                    imageCell.SetBinding(TextCell.TextProperty, "Title");
                    image
                })
            }
            */
        }
    }
}
