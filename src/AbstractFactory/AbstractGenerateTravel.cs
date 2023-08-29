using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiProjeV2.AbstractFactory
{
    public abstract class AbstractGenerateTravel
    {
        public abstract IAccommodation CreateAccommodation();
        public abstract ITransportation CreateTransportation();
    }
}
