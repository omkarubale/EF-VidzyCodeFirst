using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidzyCodeFirst.Enums;

namespace VidzyCodeFirst.Entities
{
    public class Video
    {
        public byte Id { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public Genre Genre { get; set; }

        public eClassification Classification { get; set; }
    }
}
