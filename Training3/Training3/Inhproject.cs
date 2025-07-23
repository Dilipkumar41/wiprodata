using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Training3
{
    class Vehicle
    {
        public string Brand {  get; set; }
        public int Year { get; set; }
    public void Start()
        {
            Console.WriteLine($"{Brand} is starting");
        }
    public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand},Year: {Year}");
        }
    }
    class Car : Vehicle
    {
        public int NumberofDoors {  get; set; }
    public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Car has {NumberofDoors} doors");
        }
    }
    class  Motorcycle : Vehicle
    {
        public int NumberofTyres{ get; set; }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Motorcycle has {NumberofTyres}Tyres");
        }

    }
    internal class Inhproject
    {
        static void Main()
        {
            Car car=new Car
            {
                Brand = "Porsche",
                Year = 2023,
                NumberofDoors = 2,

            };
            Motorcycle motorcycle = new Motorcycle
            {
                Brand = "HyaBusa",
                Year = 2020,
                NumberofTyres = 2,
            };
            car.Start();
            car.DisplayInfo();
            Console.WriteLine();

            motorcycle.Start();
            motorcycle.DisplayInfo();
        }
    }
}
