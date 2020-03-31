using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTPModule4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public string Error { get; set; }
        public MainPage()
        {
            InitializeComponent();
            
        }
        public void Login(object sender, EventArgs e)
        {
            if (CheckId(this.TwitterId.Text, this) && CheckPassword(this.Password.Text, this))
            {
                DisplayTweet();
            }
            else
            {
                HideTweet();
            }
        }

        private void DisplayTweet()
        {
            this.LoginForm.IsVisible = false;
            this.ProfilePic.IsVisible = true;
            this.TweetContainer.IsVisible = true;
            this.TweetButtonContainer.IsVisible = true;
            this.LoginError.IsVisible = false;
        }
        private void HideTweet()
        {
            this.LoginForm.IsVisible = true;
            this.ProfilePic.IsVisible = false;
            this.TweetContainer.IsVisible = false;
            this.TweetButtonContainer.IsVisible = false;
            this.LoginError.IsVisible = true;
        }
        private static bool CheckId(string id, MainPage mainPage)
        {
            bool res = true;
            if (string.IsNullOrEmpty(id) || id.Length < 3)
            {
                mainPage.LoginError.Text = "Merci de renseigner un identifiant valide.";
                res = false;
            }
            return res;
        }
        private static bool CheckPassword(string password, MainPage mainPage)
        {
            bool res = true;
            if (string.IsNullOrEmpty(password)|| password.Length < 6)
            {
                mainPage.LoginError.Text = "Merci de renseigner un mot de passe valide.";
                res = false;
            }
            return res;
        }
    }
}
