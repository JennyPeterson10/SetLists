using SetLists.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SetLists.DAL
{
    public class MusicInitializer : System.Data.Entity. DropCreateDatabaseAlways<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            var songs = new List<Song>
            {
                new Song{Title="All Of Me",Composer="Seymour Simons",Key="C"},
                new Song{Title="Fly Me to the Moon",Composer="Bart Howard",Key="C"},
                new Song{Title="Autumn Leaves",Composer="Joseph Kosma",Key="E minor"},
                new Song{Title="Lady Be Good",Composer="George Gershwin",Key="G"},
                new Song{Title="Trouble in Mind",Composer="Richard M. Jones",Key="F"},
                new Song{Title="Don't Mean a Thing",Composer="Duke Ellington",Key="G minor"},
                new Song{Title="After You've Gone",Composer="Turner Layton",Key="Bb"},
                new Song{Title="Ain't Misbehavin",Composer="Fats Waller",Key="D"},
                new Song{Title="Dinah",Composer="Harry Akst",Key="Ab"},
                new Song{Title="Do Nothing Till You Hear From Me",Composer="Duke Ellington",Key="Bb"},
                new Song{Title="Honeysuckle Rose",Composer="Fats Waller",Key="F"},
                new Song{Title="Exactly Like You",Composer="Jimmy McHugh",Key="C"},
            };
            songs.ForEach(x => context.Songs.Add(x));
            context.SaveChanges();

            var setlists = new List<SetList>
            {
                new SetList{Title="Jazz 1"}
            };
            setlists.ForEach(x => context.SetLists.Add(x));
            context.SaveChanges();

            //var setListSongs = new List<SetListSongs>
            //{
            //    new SetListSongs{songid=1,setlistid=1}
            //};
            //setListSongs.foreach (x => context.setListSongs.add(x)) ;
            //context.savechanges();
        }
    }
}