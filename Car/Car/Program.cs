using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Car
{    
    class Program
    {
        static void Main(string[] args)
        {
            //Car[] cars =
            //{
            //    new Car("Siat Ibiza", "new", 2019, "White", 3434, 5),
            //    new Car("Fiat uno", "good", 2015, "Red", 3767, 5),
            //    new Car("Kia Piqanto", "Excellent", 2017, "Grey", 2424, 5)
            //};            
            //foreach (Car c in cars)
            //Console.WriteLine(c);
            //XmlSerializer xml = new XmlSerializer(typeof(Car []));
            //using (Stream file = new FileStream(@"d:\XmlFiles\car.xml", FileMode.Create))
            //{
            //    xml.Serialize(file, cars);
            //}
            ////Car subaro;
            //Car[] cars2 = new Car[3]; 
            //using (Stream file = new FileStream(@"d:\XmlFiles\car.xml", FileMode.Open))
            //{
            //   cars2 = xml.Deserialize(file) as Car [];
            //}
            //foreach (Car c in cars2)
            //{
            //    Console.WriteLine(c);
            //}
            Car siat = new Car("Siat Ibiza", "new", 2019, "White", 3434, 5);
            //Car.SerializeCar(@"d:\XmlFiles\car.xml", siat);
            siat.CarCompare(@"d:\XmlFiles\car.xml");
        }
    }
}
