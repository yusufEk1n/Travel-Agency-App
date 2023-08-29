using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiProjeV2.AbstractFactory
{
    public class Travel
    {
        private AbstractGenerateTravel _abstractGenerateTravel;
        private ITransportation _transportation;
        private IAccommodation _accommodation;

        public Travel(AbstractGenerateTravel abstractGenerateTravel)
        {
            _abstractGenerateTravel = abstractGenerateTravel;
            _transportation = _abstractGenerateTravel.CreateTransportation();
            _accommodation = _abstractGenerateTravel.CreateAccommodation();
        }

        public void BuildTravel()
        {
            if (_transportation.BuildTransportation() && _accommodation.BuildAccommodation())
                System.Windows.Forms.MessageBox.Show("Seyehat oluşturuldu!");
            else
                System.Windows.Forms.MessageBox.Show("beklenmeyen hata! seyehat oluşturulamadı!");
        }

        public void RezFill(Dictionary<string, string> transportationInfo, Dictionary<string, string> accomodationInfo)
        {
            _transportation.RezFillTransportation(transportationInfo);
            _accommodation.RezFillAccommodation(accomodationInfo);
        }
    }
}
