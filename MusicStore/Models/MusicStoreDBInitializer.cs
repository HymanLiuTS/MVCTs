using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class MusicStoreDBInitializer:System.Data.Entity.DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            context.Artists.Add(new Artist() { Name = "Hyman" });
            context.Genres.Add(new Genre() { Name = "摇滚", Description = "无" });
            context.Albums.Add(new Album()
            {
                Artist = new Artist { Name="Rush"},
                Genre = new Genre { Name="Rook"},
                Price=9.9m,
                Title="Pitles"
            });
            base.Seed(context);
        }
    }
}