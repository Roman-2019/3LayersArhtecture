using System.Collections.Generic;

namespace PresentationLayer
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<DetailViewModel> Details { get; set; }

    }
}
