using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarList();
        public Car GetByID(int id) => CarDBContext.Instance.GetByID(id);
        public void InsertCar(Car car) => CarDBContext.Instance.addCar(car);
        public void UpdateCar(Car car) => CarDBContext.Instance.Update(car);
        public void DeleteCar(int id) => CarDBContext.Instance.Remove(id);
    }
}
