using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiProjeV2.AbstractFactory
{
    public class Generate_Aeroplane_Camp : AbstractGenerateTravel
    {
        public override ITransportation CreateTransportation()
        {
            return new Aeroplane();
        }
        public override IAccommodation CreateAccommodation()
        {
            return new Camp();
        }
    }
}
