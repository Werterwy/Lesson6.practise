using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.practise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количетво легковых машин: ");
            int n=Convert.ToInt32(Console.ReadLine());
            PassengerCar[] cars = new PassengerCar[n];
            for(int i=0; i<cars.Length; i++)
            {
                Console.Write("Введите марку: ");
                string brand = Console.ReadLine();
                Console.Write("Введите номер: ");
                int number=Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите грузоподоемность: ");
                double loadcapasity=Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите скорость: ");
                double speed=Convert.ToDouble(Console.ReadLine());

                PassengerCar car = new PassengerCar(brand, number, loadcapasity, speed);
                cars[i] = car;
            }
            Console.WriteLine("");
            Console.Write("Введите количетво мотоциклов: ");
            int nM = Convert.ToInt32(Console.ReadLine());
            Motobike[] motobikes = new Motobike[nM];
            for (int i = 0; i < motobikes.Length; i++)
            {
                Console.Write("Введите марку: ");
                string brand = Console.ReadLine();
                Console.Write("Введите номер: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите грузоподоемность: ");
                double loadcapasity = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите скорость: ");
                double speed = Convert.ToDouble(Console.ReadLine());
                Console.Write("Есть ли коляска, если есть введите 1 если нет 0: ");
                int b=Convert.ToInt32(Console.ReadLine());
                bool presenceofstroller=false;
                if (b == 1)
                {
                    presenceofstroller = true;
                }
                Motobike motobike = new Motobike(brand, number, loadcapasity, speed, presenceofstroller);
                motobikes[i] = motobike;
            }

            Console.WriteLine("");
            Console.Write("Введите количетво мотоциклов: ");
            int nT = Convert.ToInt32(Console.ReadLine());
            Truck[] trucks = new Truck[nT];
            for (int i = 0; i < trucks.Length; i++)
            {
                Console.Write("Введите марку: ");
                string brand = Console.ReadLine();
                Console.Write("Введите номер: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите грузоподоемность: ");
                double loadcapasity = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите скорость: ");
                double speed = Convert.ToDouble(Console.ReadLine());
                Console.Write("Есть ли прицеп, если есть введите 1 если нет 0: ");
                int b = Convert.ToInt32(Console.ReadLine());
                bool availabilityoftrailer = false;
                if (b == 1)
                {
                    availabilityoftrailer = true;
                }
                Truck truck = new Truck(brand, number, loadcapasity, speed, availabilityoftrailer);
                trucks[i] = truck;
            }


        }
    }
}
