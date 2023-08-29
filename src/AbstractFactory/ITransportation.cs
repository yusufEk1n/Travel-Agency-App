using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiProjeV2.AbstractFactory
{
    public interface ITransportation
    {
        bool BuildTransportation();
        void RezFillTransportation(Dictionary<string, string> transportationInfo);
    }
}
