using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SetLists.Models
{
    public class SetList
    {
        //public SetList()
        //{
        //    Songs = new List<Song>();
        //}
        public int SetListID { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}