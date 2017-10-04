using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KnoWhat
{
    public class Post_Page : ContentPage
    {
        public Post_Page()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Temp Post Page" }
                }
            };
        }
    }
}