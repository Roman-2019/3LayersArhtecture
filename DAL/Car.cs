using System.Collections.Generic;

namespace DAL
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Detail> Details { get; set; }
    }
}
