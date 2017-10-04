using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XLabs.Forms.Controls;

using Xamarin.Forms;

namespace KnoWhat
{
    public class Idea_Page : ContentPage
    {

        // Initialize Toolbar Button Variables
        private ToolbarItem toolbar_Idea;
        private ToolbarItem toolbar_Search;

        public Idea_Page()
        {
            

            /* Set Title of page; 
             * Add images to toolbar buttons; 
             * Add buttons to toolbar;
             * Define when clicked actions */
            Title = "Categories";
            toolbar_Idea = new ToolbarItem() { Icon = "idea_icon.png" };
            this.ToolbarItems.Add(toolbar_Idea);
            toolbar_Idea.Clicked += toolbar_Idea_Clicked;
            toolbar_Search = new ToolbarItem() { Icon = "search_icon.png" };
            this.ToolbarItems.Add(toolbar_Search);
            toolbar_Search.Clicked += toolbar_Search_Clicked;

            var layout = new StackLayout();

            Entry post = new Entry
            {
                Placeholder = "What's your idea?",
                BackgroundColor = Color.White,
                HeightRequest = 250,
                HorizontalOptions = LayoutOptions.Fill
            };


            CheckBox outdoorCheck = new CheckBox()
            {
                FontSize = 10,
                DefaultText = "outdoors",
            };

            CheckBox indoorsCheck = new CheckBox()
            {
                FontSize = 10,
                DefaultText = "indoors"
            };

            CheckBox sportsCheck = new CheckBox()
            {
                FontSize = 10,
                DefaultText = "sports",
            };

            CheckBox localCheck = new CheckBox()
            {
                FontSize = 10,
                DefaultText = "local",
            };

            CheckBox cookingCheck = new CheckBox()
            {
                FontSize = 10,
                DefaultText = "cooking",
            };

            CheckBox gamesCheck = new CheckBox()
            {
                FontSize = 10,
                DefaultText = "games",
            };

            

            layout.Children.Add(post);
            layout.Children.Add(new Label { Text = "Please choose a category", FontSize = 10, HorizontalOptions = LayoutOptions.Start, Margin = new Thickness(5, 0, 0, 0) });
            layout.Children.Add(outdoorCheck);
            layout.Children.Add(indoorsCheck);
            layout.Children.Add(sportsCheck);
            layout.Children.Add(localCheck);
            layout.Children.Add(cookingCheck);
            layout.Children.Add(gamesCheck);
            Content = layout;
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
