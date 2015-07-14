using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace MultiThemesMVC.Models
{
    public class StyleSite
    {
        public static string CurrentTheme
        {
            get
            {
                if (HttpContext.Current.Session["Style"] == null)
                {
                    HttpContext.Current.Session["Style"] = "Cerulean";
                }
                return "~/Content/" + HttpContext.Current.Session["Style"].ToString() + ".css";
            }
        }

        public void SetTheme(string theme)
        {
            HttpContext.Current.Session["Style"] = theme;
        }

    }
}
