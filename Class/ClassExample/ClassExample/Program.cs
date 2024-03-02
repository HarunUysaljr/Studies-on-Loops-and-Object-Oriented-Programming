using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{

    class RentAcar
    {

        public string Marka { get; set; }

        public string Model { get; set; }

        public int kiralamaUcreti { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //RentaCar Class example
            RentAcar rCar = new RentAcar()
            {
                Marka = "Mercedes",
                Model = "Sedan",
                kiralamaUcreti = 2500
            };

            RentAcar rCarTwo = new RentAcar()
            {
                Marka = "Bmw",
                Model = "Sedan",
                kiralamaUcreti = 3500
            };

            Console.WriteLine($"Arabanın markası {rCar.Marka}, arabanın modeli :{rCar.Model}, Kiralama ücreti: {rCar.kiralamaUcreti}");
            Console.WriteLine($"Arabanın markası {rCarTwo.Marka}, arabanın modeli :{rCarTwo.Model}, Kiralama ücreti: {rCarTwo.kiralamaUcreti}");

            Console.Read();

        }
    }
}
