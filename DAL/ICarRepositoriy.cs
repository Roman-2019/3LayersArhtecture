using System.Collections.Generic;

namespace DAL
{
    public interface ICarRepositoriy
    {
        IEnumerable<Car> GetCar();
    }
}
