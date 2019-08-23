using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SetLists.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public string Title { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }

        public virtual ICollection<SetList> SetLists { get; set; }
    }
}