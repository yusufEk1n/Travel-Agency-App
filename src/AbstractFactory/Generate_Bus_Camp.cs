using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiProjeV2.AbstractFactory
{
    public class Generate_Bus_Camp : AbstractGenerateTravel
    {
        public override ITransportation CreateTransportation()
        {
            return new Bus();
        }
        public override IAccommodation CreateAccommodation()
        {
            return new Camp();
        }
    }
}
