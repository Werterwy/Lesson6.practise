using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZendeskApi_v2.Requests;

namespace Lesson6.practise
{
    public abstract class Trans
    {
        public  string brand { get; set; }
        public int number { get; set; }
        public double loadcapacity { get; set; }
        public double speed { get; set; }
        public bool presenceofstroller { get; set; }
        public bool availabilityoftrailer { get; set; }

        public abstract double Definitionofloadcapacity();
        public abstract void info();
    }
    public class PassengerCar : Trans
    {
        public PassengerCar(string brand, int number, double loadcapacity, double speed)
        {
            this.brand = brand;
            this.number = number;
            this.loadcapacity = loadcapacity;
            this.speed = speed;
        } 
        public override double Definitionofloadcapacity()
        {
            return loadcapacity;
        }

        public override void info()
        {
            Console.WriteLine("Марка: "+brand);
            Console.WriteLine("Номер: " + number);
            Console.WriteLine("Грузоподъемность: " + loadcapacity);
            Console.WriteLine("Скорость: " + speed);
        }

        public void SearchLoadcapacity(PassengerCar[] passengerCars, double Loadcapacity)
        {
            for(int i = 0; i < passengerCars.Length; i++)
            {
                if (passengerCars[i].loadcapacity >= Loadcapacity)
                {
                    passengerCars[i].info();
                    Console.WriteLine("");
                }
            }

        }
    }
    public class Motobike : Trans
    {
        public Motobike(string brand, int number, double loadcapacity, double speed, bool presenceofstroller)
        {
            this.brand = brand;
            this.number = number;
            this.loadcapacity = loadcapacity;
            this.speed = speed;
            this.presenceofstroller = presenceofstroller;
        }
        public override double Definitionofloadcapacity()
        {
            if (presenceofstroller)
                return loadcapacity;
            else 
                return 0;
        }

        public override void info()
        {
            Console.WriteLine("Марка: " + brand);
            Console.WriteLine("Номер: " + number);
            Console.WriteLine("Грузоподъемность: " + loadcapacity);
            Console.WriteLine("Скорость: " + speed);
            Console.WriteLine("Наличие коляски: "+presenceofstroller);
        }

        public void SearchLoadcapacity(Motobike[] motobikes, double Loadcapacity)
        {
            for (int i = 0; i < motobikes.Length; i++)
            {
                if (motobikes[i].loadcapacity >= Loadcapacity)
                {
                    motobikes[i].info();
                    Console.WriteLine("");
                }
            }
        }
    }
    public class Truck : Trans
    {
        public Truck(string brand, int number, double loadcapacity, double speed, bool availabilityoftrailer)
        {
            this.brand = brand;
            this.number = number;
            this.loadcapacity = loadcapacity;
            this.speed = speed;
            this.availabilityoftrailer = availabilityoftrailer;
        }
        public override double Definitionofloadcapacity()
        {
            if(availabilityoftrailer)
                return loadcapacity*2;
            else
                return loadcapacity;
        }

        public override void info()
        {
            Console.WriteLine("Марка: " + brand);
            Console.WriteLine("Номер: " + number);
            Console.WriteLine("Грузоподъемность: " + loadcapacity);
            Console.WriteLine("Скорость: " + speed);
            Console.WriteLine("Наличие прицепа: " + availabilityoftrailer);
        }

        public void SearchLoadcapacity(Truck[] trucks, double Loadcapacity)
        {
            for (int i = 0; i < trucks.Length; i++)
            {
                if (trucks[i].loadcapacity >= Loadcapacity)
                {
                    trucks[i].info();
                    Console.WriteLine("");
                }
            }
        }
    }
}
