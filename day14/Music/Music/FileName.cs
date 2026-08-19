using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public class Song
    {
        public long id { get; set; }
        public List<Artists> artists { get; set; }
    }

    public class Result
    {
        public List<Song> songs { get; set; }
    }

    public class Res
    {
        public Result result { get; set; }
    }

    public class Artists
    {
        public string name { get; set; }
    }
}
