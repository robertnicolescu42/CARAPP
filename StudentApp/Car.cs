using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    //fullname StudentApp.Student
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public List<Picture> Pictures { get; set; }

        public Car()
        {
            Pictures = new List<Picture>();
        }

        public void AddPicture(Picture newPicture)
        {
            Pictures.Add(newPicture);
        }

        public void RemovePicture(string name)
        {
            Picture pic = null;

            foreach (Picture p in Pictures)
            {
                if (p.Name == name)
                {
                    pic = p;
                    break;
                }

            }

            if (pic != null)
            {
                Pictures.Remove(pic);
            }

        }


        public override string ToString()
        {
            return string.Format("{0}; {1}; {2}; {3}; [{4}];", Id, Model, Manufacturer, Year, string.Join(",", Pictures));
        }
    }
}
