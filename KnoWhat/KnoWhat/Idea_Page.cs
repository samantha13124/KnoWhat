using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KnoWhat
{
    public class Idea_Page : ContentPage
    {
        public Idea_Page()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Temp New Idea Page" }
                }
            };
        }
    }
}