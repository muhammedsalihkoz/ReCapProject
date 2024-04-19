using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            { 
                new Car { CarId = 1, BrandId = 1, ColorId = 1, BrandName="Honda",ModelYear = "2015", DailyPrice = 30000, Description = "Good Performance" },
                new Car { CarId = 2, BrandId = 2, ColorId = 1, BrandName="Toyota", ModelYear = "2016", DailyPrice = 33000, Description = "Good Performance" },
                new Car { CarId = 3, BrandId = 3, ColorId = 2, BrandName="Nissan", ModelYear = "2020", DailyPrice = 40000, Description = "Like New" },
                new Car { CarId = 4, BrandId = 1, ColorId = 3, BrandName="Ford", ModelYear = "2022", DailyPrice = 45000, Description = "New Car" },
                new Car { CarId = 5, BrandId = 4, ColorId = 3, BrandName="Mercedes", ModelYear = "2014", DailyPrice = 29000, Description = "Still Good" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            carUpdate.ColorId = car.ColorId;
            carUpdate.BrandId = car.BrandId;
            carUpdate.BrandName = car.BrandName;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
        }
    }
}
