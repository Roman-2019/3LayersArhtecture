using System.Collections.Generic;

namespace DAL
{
    public interface IDetailRepositoriy
    {
        IEnumerable<Detail> GetDetail();
    }
}
