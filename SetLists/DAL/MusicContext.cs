using SetLists.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SetLists.DAL
{
    public class MusicContext : DbContext
    {
        public MusicContext() : base("MusicContext")
        {
        }

        public DbSet<Song> Songs { get; set; }
        public DbSet<SetList> SetLists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<SetList>()
                .HasMany(t => t.Songs)
                .WithMany(t => t.SetLists)
                .Map(mc =>
                {
                    mc.ToTable("SetListSongs");
                    mc.MapLeftKey("SetListID");
                    mc.MapRightKey("SongID");
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}