using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Models
{
    public class AlbumEditViewModel
    {
        public Album AlbumEdit { get; set; }
        public SelectList Geners { get; set; }
        public SelectList Artists { get; set; }
    }
}