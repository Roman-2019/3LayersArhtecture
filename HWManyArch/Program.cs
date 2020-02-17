using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer;

namespace HWManyArch
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarController carsControllers = new CarController();
            IDetailController detailControllers = new DetailController();

            var rescar = carsControllers.GetCarsViewModel().ToList();
            var resdetail = detailControllers.GetDetailViewModel().ToList();

            foreach (var output in rescar)
            {
                Console.WriteLine(output);
            }
            Console.WriteLine("***************");
            foreach (var output in resdetail)
            {
                Console.WriteLine(output);
            }

            Console.ReadKey();
        }
    }
}
