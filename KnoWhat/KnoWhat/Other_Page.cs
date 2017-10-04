using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KnoWhat
{
    public class Other_Page : ContentPage
    {
        public Other_Page()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Temp Other Profile Page" }
                }
            };
        }
    }
}