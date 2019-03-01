using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Car
{   
    public class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        int codan;
        protected int numberOfSeats;

        public Car()
        {
        }

        public Car(string fileName)
        {
            Car newcar = Car.DesSerializeCar(fileName);
            this.Model = newcar.Model;
            this.Brand = newcar.Brand;
            this.Year = newcar.Year;
            this.Color = newcar.Color;          

        }

        public Car(string model, string brand, int year, string color, int codan, int numberOfSeats)
        {
            Model = model;
            Brand = brand;
            Year = year;
            Color = color;
            this.codan = codan;
            this.numberOfSeats = numberOfSeats;
        }
        public int GetCodan()
        {
            return codan;
        }
        public int GetNumberOfSeats()
        {
            return numberOfSeats;
        }
        public bool CarCompare(string file)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Car));            
            Car carfile = DesSerializeCar(file);
            if (carfile.Model == Model &&
                carfile.Brand == Brand &&
                carfile.Year == Year &&
                carfile.Color == Color)
            {
                Console.WriteLine("y");
                return true;
            }
            Console.WriteLine("n");
            return false;
        }
        protected void ChangeNumberOfSeats(int newNumberOfSeats)
        {
            numberOfSeats = newNumberOfSeats;
        }

        public static void SerializeACarArray(string fileName, Car [] cars)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Car[]));
            using (Stream file = new FileStream(fileName, FileMode.Create))
            {
                xml.Serialize(file, cars);
            }
            Console.WriteLine("Serialized succeed");
        }
        public static void DeserializeACarArray (string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Car[]));
            Car[] cars = null;
            using (Stream file = new FileStream(fileName, FileMode.Open))
            {
                cars = xml.Deserialize(file) as Car[];
            }
            Console.WriteLine("DesSerialized succeed");
        }

        public static void SerializeCar(string fileName, Car car)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Car));
            using (Stream file = new FileStream(fileName, FileMode.Create))
            {
                xml.Serialize(file, car);
            }
            Console.WriteLine("Serialized succeed");
        }
        public static Car DesSerializeCar(string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Car));
            Car r = null;
            using (Stream file = new FileStream(fileName, FileMode.Open))
            {
                r = xml.Deserialize(file) as Car;
            }            
            Console.WriteLine("DesSerialized succeed");
            return r;
        }

        public override string ToString()
        {
            return $"Model: {Model} Brand: {Brand} Year: {Year} Color: {Color} Codan {codan}";
        }
    }
}
