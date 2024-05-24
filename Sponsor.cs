using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_26
{
    public class Sponsor
    {
        public string Name;
        public string PathToPhoto;
        public string Description;

        public Sponsor() 
        {
            Name = "";
            PathToPhoto = Directory.GetCurrentDirectory() + "\\resource\\None.jpg";
            Description = "None Description";
        }

        public Sponsor(string newName, string newPathToPhoto, string newDescription) 
        {
            Name = newName;
            PathToPhoto = newPathToPhoto;
            Description = newDescription;
        }
    }
}
