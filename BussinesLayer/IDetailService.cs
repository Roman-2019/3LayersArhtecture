using System.Collections.Generic;

namespace BussinesLayer
{
    public interface IDetailService
    {
        IEnumerable<DetailModel> GetDetailModel();
    }
}
