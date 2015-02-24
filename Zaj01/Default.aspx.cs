using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Zaj01.Models;

namespace Zaj01
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var root = XElement.Load("http://news.google.com/news?pz=1&cf=all&ned=us&hl=en&output=rss");


            Repeater1.DataSource = root.Descendants("item").Select(x => new RssItem
            {
                Title = x.Element("title").Value,
                Description = x.Element("description").Value
            });
            Repeater1.DataBind();
        }
    }
}