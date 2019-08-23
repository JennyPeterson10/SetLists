using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SetLists.Models
{
    public class SongSetList
    {
        public int SongID { get; set; }
        public Song Song { get; set; }

        public int SetListID { get; set; }
        public SetList SetList { get; set; }
    }
}