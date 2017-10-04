using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KnoWhat
{
    public class Categories_Page : ContentPage
    {

        // Initialize Toolbar Button Variables
        private ToolbarItem toolbar_Idea;
        private ToolbarItem toolbar_Search;


        public Categories_Page()
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

            // Create StackLayout for the entire page
            var layout = new StackLayout
            {
                // Add children 
                Children =
                {
                    // Create label for message
                    new Label
                    {
                        Text = "Browse by category or search for a keyword!",
                        FontSize = 15,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center,
                        TextColor = Color.Black,
                        Margin = new Thickness(8)
                    }
                }
            };

            // Create User Entry for keyword search
            // BUG: need to implement functionality
            Entry keyword = new Entry
            {
                Placeholder = "Search for activities based on keyword",
                FontSize = 10,
            };

            // Create Button to search any keywords entered into keyword
            // BUG: need to implement functionality
            Button search = new Button
            {
                Text = "Search",
                TextColor = Color.FromHex("#f8af35"),
                BackgroundColor = Color.White,
                HeightRequest = 40
            };
            
            // Create Sub Stacklayout for Search to display keyword entry and search button side by side
            var search_layout = new StackLayout
            {
                // Add keyword and search to Stacklayout
                Children =
                {
                    keyword,
                    search
                },

                // Set orientation to horizontal to achieve side by side
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

           
            /*
             * Advanced Search when implemetned
             * Create TapGesture to create text into button
             * 
             *
            Entry advanced_search = new Entry
            {
                Text = "Advanced Search",
                FontSize = 7,
                TextColor = Color.FromHex("#f8af35"),
                HorizontalOptions = LayoutOptions.Start
            };

            var advanced_temp = new TapGestureRecognizer();

            advanced_temp.Tapped += (s, e) =>
            {

            };
            */
            
            /* Create all buttons to search by category
             * BUG: need to implement functionality behind buttons
             * Can add more if needed
             */
            Button outdoors = new Button
            {
                Text = "Outdoors",
                TextColor = Color.FromHex("#f8af35"),
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(0, 0)
                
            };

            Button indoors = new Button
            {
                Text = "Indoors",
                TextColor = Color.FromHex("#f8af35"),
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center,               
                Margin = new Thickness(0, 0, 0, 0)

            };

            Button sports = new Button
            {
                Text = "Sports",
                TextColor = Color.FromHex("#f8af35"),
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(0, 0, 0, 0)
            };

            Button local = new Button
            {
                Text = "Local",
                TextColor = Color.FromHex("#f8af35"),
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(0, 0, 0, 0)
            };

            Button cooking = new Button
            {
                Text = "Cooking",
                TextColor = Color.FromHex("#f8af35"),
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(0, 0, 0, 0)
            };

            Button games = new Button
            {
                Text = "Games",
                TextColor = Color.FromHex("#f8af35"),
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(0, 0, 0, 0)
            };

            // Add Sub Stacklayout for Search and category buttons to Stacklayout for page design
            layout.Children.Add(search_layout);
            layout.Children.Add(outdoors);
            layout.Children.Add(indoors);
            layout.Children.Add(sports);
            layout.Children.Add(local);
            layout.Children.Add(cooking);
            layout.Children.Add(games);
            layout.Spacing = 0;

            // Set the content of the page to the stack layout
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