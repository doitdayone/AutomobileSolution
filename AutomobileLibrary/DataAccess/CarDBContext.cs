using AutomobileLibrary.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
     class CarDBContext
    {
        private List<Car> CarList = new List<Car>
        {
            new Car { CarID = 1, CarName = "CRV", Manufactor = "Honda", Price = 30000, YearRelease = 2021 },
            new Car { CarID = 2, CarName = "Ford Focus", Manufactor = "Ford", Price = 30000, YearRelease = 2021 }
        };
        private static CarDBContext instance = null;
        private static readonly object locker = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get { 
                if (instance == null) { instance = new CarDBContext(); }
                return instance;
            }
        }

        public List<Car> GetCarList() => CarList;
        public Car GetByID(int ID)
        {
            Car car = CarList.SingleOrDefault(pro => pro.CarID == ID);
            return car;
        }
        public void addCar(Car car)
        {
            Car p = GetByID(car.CarID);
            if (p == null)
            {
                CarList.Add(car);
            }
            else throw new Exception("Car is already exist");
        }
        public void Update(Car car)
        {
            Car p = GetByID(car.CarID);
            if (p != null) {
                int index = CarList.IndexOf(p);
                CarList[index] = car;
            }
            else throw new Exception("Car is not exist");
        }

        public void Remove(int ID)
        {
            Car p = GetByID(ID); 
            if (p != null)
            {
                CarList.Remove(p);
            }
            else throw new Exception("Car is not exist");
        }
    }
}
