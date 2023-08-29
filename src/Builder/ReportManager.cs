using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiProjeV2.Builder
{
    public class ReportManager
    {
        private ReportBuilderBase Builder;

        public ReportManager(ReportBuilderBase builder)
        {
            this.Builder = builder;
        }
        public string Build()
        {
            string reservasions = Builder.BuildOutput();
            return reservasions;
        }
        public string BuildUpsideDown()
        {
            string reservasions = Builder.BuildHeader();
            reservasions += Builder.BuildContents();
            reservasions += Builder.BuildFooter();
            return reservasions;
        }
    }
}
