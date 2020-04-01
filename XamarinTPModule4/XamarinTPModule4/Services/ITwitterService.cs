using System;
using System.Collections.Generic;
using System.Text;
using XamarinTPModule4.Models;

namespace XamarinTPModule4.Services
{
    interface ITwitterService
    {
        bool Authenticate(string user, string password);
        List<Tweet> GetTweets(string s);
    }
}
