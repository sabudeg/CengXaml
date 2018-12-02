using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CengDepartment
{
  

    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Email = emailEntry.Text,
                Password = passwordEntry.Text
            };

            var isValid = AreCredentialsCorrect(user);
            if (isValid)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                messageLabel.Text = "Login failed";
                passwordEntry.Text = string.Empty;
            }
        }

        bool AreCredentialsCorrect(User user)
        {
            return user.Email == Constants.Email && user.Password == Constants.Password;
        }
    }

    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        
    }

    public static class Constants
    {
        //public static string Email = "sbdegirmenci@eskisehir.edu.tr";
        //public static string Password = "123";

        public static string Email = "123";
        public static string Password = "123";
    }

}