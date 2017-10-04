using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KnoWhat
{
    public class User_Page : ContentPage
    {
        public User_Page()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Temp Profile Page" }
                }
            };
        }
    }
}