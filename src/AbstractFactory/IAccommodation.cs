using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiProjeV2.AbstractFactory
{
    public interface IAccommodation
    {
        bool BuildAccommodation();
        void RezFillAccommodation(Dictionary<string, string> accommodationInfo);
    }
}
