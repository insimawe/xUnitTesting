using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class WorldDubestFunction
    {
        public string ReturnsPikachuIfZero(int num)
        {
            if (num == 0)
            {
                return "Pikachu";
            }
            else
            {
                return "Not Pikachu";
            }
        }
    }
}
