using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KnoWhat
{
    public class Home_Page : ContentPage
    {
        // Initialize Toolbar Button Variables
        private ToolbarItem toolbar_Idea;
        private ToolbarItem toolbar_Search;

        public Home_Page()
        {

            /* Set Title of page; 
             * Add images to toolbar buttons; 
             * Add buttons to toolbar;
             * Define when clicked actions */
            Title = "KnoWhat";
            toolbar_Idea = new ToolbarItem() { Icon = "idea_icon.png" };
            this.ToolbarItems.Add(toolbar_Idea);
            toolbar_Idea.Clicked += toolbar_Idea_Clicked;
            toolbar_Search = new ToolbarItem() { Icon = "search_icon.png" };
            this.ToolbarItems.Add(toolbar_Search);
            toolbar_Search.Clicked += toolbar_Search_Clicked;


            var layout = new StackLayout();
        }


        

        // Methods for when toolbar buttons are clicked
        void toolbar_Idea_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Idea_Page());
        }
        void toolbar_Search_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Categories_Page());
        }

    }
}