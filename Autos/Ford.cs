using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.BasicExample.Autos
{
    public class Ford : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("Ford engine turned on and is reving quietly!");
        }

        public void TurnOff()
        {
            Console.WriteLine("Ford engine has been turned off");
        }
    }
}
