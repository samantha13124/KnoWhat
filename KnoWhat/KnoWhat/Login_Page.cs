using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KnoWhat
{
    public class Login_Page : ContentPage
    {
        public Login_Page()
        {

            NavigationPage.SetHasNavigationBar(this, false);
            BackgroundColor = Color.FromHex("#f8af35");

            // Initalize Stack Layout to properly display items
            var layout = new StackLayout();

            // Title Label
            var name = new Label
            {
                Text = "KnoWhat",
                FontSize = 36,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.Black,
                Margin = new Thickness(0, 100, 0, 0)

            };

            // Username Text Box
            var usernameEntry = new Entry
            {
                Placeholder = "Username",
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(30)
            };

            // Password Text Box
            var passwordEntry = new Entry
            {
                Placeholder = "Password",
                IsPassword = true,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(30)
            };

            // Login Button
            Button login = new Button
            {
                Text = "Login",
                TextColor = Color.White,
                BackgroundColor = Color.FromHex("#4f5154"),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };

            // Signup Text
            Label signUp = new Label()
            {
                Text = "Don't have an account? Sign up now!",
                FontSize = 10,
                HorizontalOptions = LayoutOptions.Center,
            };

            // Convert Signup Text into Button
            var temp = new TapGestureRecognizer();

            // On SignUp Button Clicked
            temp.Tapped += (s, e) =>
            {
                // Navigate to SignUp Page
                Navigation.PushAsync(new Signup_Page());
            };

            signUp.GestureRecognizers.Add(temp);

            // On Login Button Clicked, @Login_Clicked
            login.Clicked += Login_Clicked;

            // Add Text fields and Entry Boxes to Page
            layout.Children.Add(name);
            layout.Children.Add(usernameEntry);
            layout.Children.Add(passwordEntry);
            layout.Children.Add(login);
            layout.Children.Add(signUp);
            layout.Spacing = 10;

            // Display Stack Layout
            Content = layout;
        }

        // On Login Button Clicked
        private void Login_Clicked(object sender, EventArgs e)
        {



            Navigation.PushAsync(new Home_Page { Title = "KnoWhat" } );
        }


    }
}