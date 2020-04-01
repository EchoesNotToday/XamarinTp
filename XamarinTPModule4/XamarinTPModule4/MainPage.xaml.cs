using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinTPModule4.Services;

namespace XamarinTPModule4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ITwitterServiceImpl twitterService = new ITwitterServiceImpl();
        public string Error { get; set; }
        public MainPage()
        {
            InitializeComponent();
            
        }
        public void Login(object sender, EventArgs e)
        {
            if (CheckId(this) && CheckPassword(this) && Auth(this))
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
        private static bool CheckId(MainPage mainPage)
        {
            bool res = true;
            if (string.IsNullOrEmpty(mainPage.TwitterId.Text) || mainPage.TwitterId.Text.Length < 3)
            {
                mainPage.LoginError.Text = "Merci de renseigner un identifiant valide.";
                res = false;
            }
            return res;
        }
        private static bool CheckPassword(MainPage mainPage)
        {
            bool res = true;
            if (string.IsNullOrEmpty(mainPage.Password.Text)|| mainPage.Password.Text.Length < 6)
            {
                mainPage.LoginError.Text = "Merci de renseigner un mot de passe valide.";
                res = false;
            }
            return res;
        }
        private static bool Auth(MainPage mainPage)
        {
            bool res = true;
            if (!mainPage.twitterService.Authenticate(mainPage.TwitterId.Text, mainPage.Password.Text))
            {
                res = false;
                mainPage.LoginError.Text = "Identifiant ou mot de passe inconnu.";
            }
            return res;
        }
    }
}
