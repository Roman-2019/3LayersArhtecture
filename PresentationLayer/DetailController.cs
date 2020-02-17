using System.Collections.Generic;
using System.Linq;
using BussinesLayer;

namespace PresentationLayer
{
    public class DetailController: IDetailController
    {
        public IEnumerable<DetailViewModel> GetDetailViewModel()
        {
            IDetailService detailsevices = new DetailService();
            var result = from detail in detailsevices.GetDetailModel()
                         select new DetailViewModel()
                         {
                             Id = detail.Id,
                             NameDetail = detail.NameDetail,
                             Number=detail.Number,
                             CarId=detail.CarId
                         };
            return result;
        }
    }
}
