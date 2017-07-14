﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Album
    {
        public virtual int AlbumId { get; set; }
        public virtual int GenreId { get; set; }
        public virtual int ArtistId { get; set; }
        public virtual String Title { get; set; }
        public virtual decimal Price { get; set; }
        public virtual String AlbumUrl { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }

    }

    public class Artist
    {
        public virtual int ArtistId { get; set; }
        public virtual String Name  { get; set; }
    }

    public class Genre
    {
        public virtual int GenreId { get; set; }
        public virtual String Name { get; set; }
        public virtual String Description { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}