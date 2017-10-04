using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KnoWhat
{
    public class Notification_Page : ContentPage
    {
        public Notification_Page()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Temp Notification Page" }
                }
            };
        }
    }
}