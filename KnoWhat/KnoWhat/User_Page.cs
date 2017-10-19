using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KnoWhat
{
    public class User_Page : ContentPage
    {
        private ToolbarItem toolbar_Back;
        private ToolbarItem toolbar_Search;
        private Image user_Picture;

        public User_Page()
        {
            Title = "Profile";
            toolbar_Search = new ToolbarItem() { Icon = "search_icon.png" };
            this.ToolbarItems.Add(toolbar_Search);
            toolbar_Search.Clicked += toolbar_Search_Clicked;

            var layout = new StackLayout();

            Image user_Picture = new Image { Source = "userProfile.png" };

            Entry post = new Entry
            {
                Placeholder = "Tell people about yourself.",
                BackgroundColor = Color.White,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Fill
            };

            layout.Children.Add(post);
            Content = layout;
        }
        // Methods for when toolbar buttons are clicked 
        void toolbar_Search_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Categories_Page());
        }
    }
}
