using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarApp;
using Newtonsoft.Json;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args) //args reprezinta un array de string (eventuali parametrii din command line)
        {
            Car c = new Car()
            {
                Id = 5,
                Model = "Focus",
                Manufacturer = "Ford",
                Year = 2015,
                Pictures = new List<Picture>()
                {
                    new Picture()
                    {
                        Name = "Picture1",
                        FilePath = "C:\\Pictures\\5\\Picture1.jpg"
                    },
                    new Picture()
                    {
                        Name = "Picture2",
                        FilePath = "C:\\Pictures\\5\\Picture2.jpg"
                    }
                }
            };
            
            var carJsonData = File.ReadAllText("5.json");
            var objCar = JsonConvert.DeserializeObject<Car>(carJsonData);
            objCar.AddPicture(new Picture()
            {
                Name = "Picture3",
                FilePath = "C:\\Pictures\\5\\Picture3.jpg"
            });
            
            var json = JsonConvert.SerializeObject(objCar);
            
            File.WriteAllText(string.Format("{0}.json", c.Id), json);

            /*
            string carAsJson = JsonConvert.SerializeObject(c);

            File.WriteAllText(string.Format("{0}.json", c.Id), carAsJson);
            */
            AutoPark ap = new AutoPark();
            ap.Add(c);

            
            Console.WriteLine(ap);
            Console.ReadKey();
        }
    }
}
