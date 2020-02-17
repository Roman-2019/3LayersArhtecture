using System.Collections.Generic;
using System.Linq;
using DAL;

namespace BussinesLayer
{
    public class DetailService : IDetailService
    {
        public IEnumerable<DetailModel> GetDetailModel()
        {
            IDetailRepositoriy detailrepositoriyes = new DetailRepositoriy();
            var result = from detail in detailrepositoriyes.GetDetail()
                         select new DetailModel()
                         {
                             Id = detail.Id,
                             NameDetail = detail.NameDetail,
                             Number = detail.Number,
                             CarId = detail.CarId
                         };
            return result;
        }

    }
}
