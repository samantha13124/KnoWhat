using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KnoWhat
{
    public class Inbox_Page : ContentPage
    {
        public Inbox_Page()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Temp Inbox Page" }
                }
            };
        }
    }
}