using AutomobileLibrary.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetByID(int id);
        void InsertCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int id);
    }
}
