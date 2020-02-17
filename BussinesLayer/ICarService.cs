using System.Collections.Generic;

namespace BussinesLayer
{
    public interface ICarService
    {
        IEnumerable<CarModel> GetCarModel();
    }
}
