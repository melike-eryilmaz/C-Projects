using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegTemp.Models
{
    public class UserArticle
    {
        public Users  users{ get; set; }
        public List<Article> articles { get; set; }
    }
}