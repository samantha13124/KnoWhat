using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KnoWhat
{
    public class Signup_Page : ContentPage
    {
        public Signup_Page()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Temp Signup Page" }
                }
            };
        }
    }
}