using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTPModule4.Models;
using XamarinTPModule4.Services;

namespace XamarinTPModule4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetListPage : ContentPage
    {
        public TweetListPage()
        {
            InitializeComponent();

            ITwitterServiceImpl twitterService = new ITwitterServiceImpl();
            ObservableCollection<Tweet> tweetList = new ObservableCollection<Tweet>();
            twitterService.GetTweets().ForEach(t=>tweetList.Add(t));

            this.TweetList.ItemsSource = tweetList;
        }
    }
}