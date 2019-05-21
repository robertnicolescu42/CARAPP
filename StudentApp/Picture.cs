using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class Picture
    {
        public string Name { get; set; }
        public string FilePath { get; set; }



        public override string ToString()
        {
            return string.Format("({0}: {1})", Name, FilePath);
        }

    }
}
