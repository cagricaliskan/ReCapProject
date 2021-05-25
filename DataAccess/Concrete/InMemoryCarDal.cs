using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;


namespace DataAccess.Concrete
{
     public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    Id = 1,
                    ColorId = 1,
                    BrandId = 2,
                    DailyPrice = 500,
                    Description = "Günlük ücret 500TL",
                    ModelYear = 2020
                },
                new Car
                {
                    Id = 2,
                    ColorId = 3,
                    BrandId = 1,
                    DailyPrice = 600,
                    Description = "Günlük ücret 600TL",
                    ModelYear = 2020
                },
                new Car
                {
                    Id = 3,
                    ColorId = 1,
                    BrandId = 1,
                    DailyPrice = 400,
                    Description = "Günlük ücret 400TL",
                    ModelYear = 2018
                },
            };
                
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car c1;
            c1 = _cars.FirstOrDefault(x => x.Id == car.Id);
            _cars.Remove(c1);
        }
        public void Update(Car car)
        {
            Car c1 = _cars.FirstOrDefault(x => x.Id == car.Id);

            if(c1 != null)
            {
                c1.Id = car.Id;
                c1.ColorId = car.ColorId;
                c1.BrandId = car.BrandId;
                c1.DailyPrice = car.DailyPrice;
                c1.Description = car.Description;
                c1.ModelYear = car.ModelYear;
            }
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(x => x.Id == id).ToList();
        }

        
    }
}
