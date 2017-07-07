using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        public String Index()
        {
            return "Hello from Stor()";
        }

        public String Browse(string genre)
        {
            return HttpUtility.HtmlEncode( "传过来的参数是" + genre);
        }

        // GET: /Store/Details/id
        public String Details(int id)
        {
            return "Store.Details(),id=" + id ;
        }
    }
}