using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    //o lista de studenti
    public class AutoPark
    {
        public List<Car> Cars { get; set; }

        public AutoPark()
        {
            Cars = new List<Car>();
        }

        public void Add(Car s)
        {
            Cars.Add(s);
        }

        public void AddPicture(int id, string name, string path)
        {
            Car c = Cars.FirstOrDefault(x => x.Id == id);

            if (c != null)
            {
                c.AddPicture(new Picture()
                {
                    Name = name,
                    FilePath = path
                });
            }
        }

        public override string ToString()
        {
            var result = "";
            foreach(var car in Cars)
            {
                result = result + car.ToString() + Environment.NewLine;
            }

            return result;
        }

        public void SaveOnDisk(string fileName)
        {
            File.WriteAllText(fileName, ToString());
        }
    }
}
