using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,BrandId=1,ColorId=1,ModelYear=2010,DailyPrice=135000,Description="Beyaz Sedan BMW M4 Hatasız"},
                new Car{Id = 2,BrandId=2,ColorId=1,ModelYear=2015,DailyPrice=100000,Description="Beyaz Sedan Renault Clio Hatasız"},
                new Car{Id = 3,BrandId=3,ColorId=2,ModelYear=2021,DailyPrice=185000,Description="Mavi Station Mercedes C180 Kazalı"},
                new Car{Id = 4,BrandId=2,ColorId=3,ModelYear=2020,DailyPrice=210000,Description="Siyah Sedan Renault Captur Hatasız"},
                new Car{Id = 5,BrandId=5,ColorId=4,ModelYear=2018,DailyPrice=195000,Description="Beyaz Sedan Ford Focus Hasarlı"},
                new Car{Id = 6,BrandId=3,ColorId=3,ModelYear=2010,DailyPrice=200000,Description="Siyah Station Mercedes E220 Hatasız"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public int GetById(Car car)
        {
            return Convert.ToInt32(_cars.Where(c => c.Id == car.Id));
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
