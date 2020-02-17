using System.Collections.Generic;
using System.Linq;
using BussinesLayer;

namespace PresentationLayer
{
    public class CarController: ICarController
    {
        public IEnumerable<CarViewModel> GetCarsViewModel()
        {
            ICarService carservices = new CarService();
            var result = from car in carservices.GetCarModel()
                         select new CarViewModel()
                         {
                             Id = car.Id,
                             Name = car.Name
                         };
                return result;
        }

    }
}
