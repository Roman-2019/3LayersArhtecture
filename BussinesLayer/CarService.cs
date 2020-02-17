using System.Collections.Generic;
using System.Linq;
using DAL;

namespace BussinesLayer
{
    public class CarService: ICarService
    {
        public IEnumerable<CarModel> GetCarModel()
        {
            ICarRepositoriy carservices = new CarRepositoriy();
            var result = from car in carservices.GetCar()
                         select new CarModel()
                         {
                             Id = car.Id,
                             Name = car.Name
                         };
            return result;
        }

    }
}
