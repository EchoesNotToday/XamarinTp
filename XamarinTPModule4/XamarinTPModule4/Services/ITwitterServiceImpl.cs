using System;
using System.Collections.Generic;
using System.Text;
using XamarinTPModule4.Models;

namespace XamarinTPModule4.Services
{
    class ITwitterServiceImpl : ITwitterService
    {
        public bool Authenticate(string user, string password)
        {
            if (user.Equals("Patrick", StringComparison.OrdinalIgnoreCase) && password.Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Tweet> GetTweets(string s)
        {
            List<Tweet> res = new List<Tweet>() {
            new Tweet { Id = "001", CreationDate="01/04/2020", Text= "gravida neque convallis a cras", UserAlias="LeRoiDesRoublards", UserId="001", UserName="Patrick" },
            new Tweet { Id = "002", CreationDate="01/02/2020", Text= "gravida rutrum quisque non tellus", UserAlias="ZazaOff", UserId="002", UserName="Isabelle" },
            new Tweet { Id = "003", CreationDate="15/01/2020", Text= "metus aliquam eleifend mi in", UserAlias="Bernard_Le_Tapir", UserId="003", UserName="Bernard" },
            new Tweet { Id = "004", CreationDate="16/02/2019", Text= "porttitor lacus luctus accumsan tortor", UserAlias="Sylvain_DuDrift", UserId="004", UserName="Sylvain" },
            new Tweet { Id = "005", CreationDate="25/04/2018", Text= "ultricies tristique nulla aliquet enim", UserAlias="RickRoll", UserId="005", UserName="Rick" },
            new Tweet { Id = "006", CreationDate="15/04/2017", Text= "quam adipiscing vitae proin sagittis", UserAlias="Carlos_Papayou", UserId="006", UserName="Carlos" },
            new Tweet { Id = "007", CreationDate="06/04/2016", Text= "nisi quis eleifend quam adipiscing", UserAlias="LeRoiDesRoublards", UserId="001", UserName="Patrick" },
            new Tweet { Id = "008", CreationDate="07/12/2018", Text= "sodales neque sodales ut etiam", UserAlias="ZazaOff", UserId="002", UserName="Isabelle" },
            new Tweet { Id = "009", CreationDate="01/09/2015", Text= "turpis tincidunt id aliquet risus", UserAlias="LeRoiDesRoublards", UserId="001", UserName="Patrick" }
            };

            return res;
        }
    }
}
