using System.Collections.Generic;

namespace BussinesLayer
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<DetailModel> Details { get; set; }
    }
}
