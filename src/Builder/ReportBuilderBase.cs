using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiProjeV2.Builder
{
    public abstract class ReportBuilderBase
    {
        protected ReportInfo Info;

        public ReportBuilderBase(ReportInfo reportInfo)
        {
            this.Info = reportInfo;
        }

        public string BuildOutput()
        {
            string output = BuildHeader();
            output += BuildHeader();
            output += BuildFooter();
            return output;
        }

        public abstract string BuildHeader();
        public abstract string BuildFooter();
        public abstract string BuildContents();
    }
}
